using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using Domen;
using Sesija;

namespace Server
{
    class Obrada
    {
        //Socket klijent;
        NetworkStream tok;
        BinaryFormatter formater = new BinaryFormatter();

        public Obrada(Socket k)
        {
            //this.klijent = k;
            tok = new NetworkStream(k, System.IO.FileAccess.ReadWrite);
        }

        public void izvrsiNaredbu()
        {
            int operacija = 0;

            while (operacija != (int)Operacije.kraj)
            {
                Transfer_Klasa transfer = formater.Deserialize(tok) as Transfer_Klasa;
                operacija = transfer.Operacija;
                switch (operacija)
                {
                    case (int)Operacije.sacuvaj_studenta:
                        sacuvajStudenta(transfer);
                        break;

                    case (int)Operacije.pronadji_studenta:
                        pronadjiStudenta(transfer);
                        break;

                    case (int)Operacije.vrati_studente:
                        vratiStudente(transfer);
                        break;

                    case (int)Operacije.kraj:
                        krajSesije(transfer);
                        break;

                }
            }
        }

        private void sacuvajStudenta(Transfer_Klasa transfer)
        {
            int rez = Broker.dajBrokera().dodajStudenta(transfer.Objekat as Student);
            transfer.Signal = rez == 1 ? (int)Signali.izvrseno : (int)Signali.nije_izvrseno;
            formater.Serialize(tok, transfer);
        }

        private void pronadjiStudenta(Transfer_Klasa transfer)
        {
            Student s = transfer.Objekat as Student;
            transfer.Objekat = Broker.dajBrokera().pronadjiStudenta(s.BrojIndeksa);
            transfer.Signal = transfer.Objekat != null ? (int)Signali.izvrseno : (int)Signali.nije_izvrseno;
            formater.Serialize(tok, transfer);
        }

        private void vratiStudente(Transfer_Klasa transfer)
        {
            transfer.Objekat = Broker.dajBrokera().vratiSveStudente();
            transfer.Signal = (transfer.Objekat as List<Student>).Count > 0 ? (int)Signali.izvrseno : (int)Signali.nije_izvrseno;
            formater.Serialize(tok, transfer);
        }

        private void krajSesije(Transfer_Klasa transfer)
        {
            transfer.Signal = (int)Signali.kraj;
            formater.Serialize(tok, transfer);
        }

    }
}

