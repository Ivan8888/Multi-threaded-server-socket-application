using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Transfer_Klasa
    {
        int operacija;
        public int Operacija
        {
            get { return operacija; }
            set { operacija = value; }
        }

        int signal;
        public int Signal
        {
            get { return signal; }
            set { signal = value; }
        }

        Object objekat;
        public Object Objekat
        {
            get { return objekat; }
            set { objekat = value; }
        }
    }

    public enum Operacije
    {
        sacuvaj_studenta = 1, pronadji_studenta, vrati_studente, kraj
    };

    public enum Signali
    {
        izvrseno = 1, nije_izvrseno, kraj
    };
}

