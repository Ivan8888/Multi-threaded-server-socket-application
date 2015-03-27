using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domen;
using System.Runtime.Serialization.Formatters.Binary;
using System.Net.Sockets;

namespace Klijent
{
    public partial class Klijent : Form
    {
        BinaryFormatter formater = new BinaryFormatter();
        NetworkStream tok;
        TcpClient klijent;

        public Klijent()
        {
            InitializeComponent();
        }

        private void Klijent_Load(object sender, EventArgs e)
        {
            klijent = new TcpClient("localhost", 10000);
            tok = klijent.GetStream();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Transfer_Klasa transfer = new Transfer_Klasa();
            Student s = new Student();

            s.BrojIndeksa = Convert.ToInt32(txtBrojIndeksa.Text);
            s.Ime = txtImeIPrezime.Text;

            transfer.Objekat = s;
            transfer.Operacija = (int)Operacije.sacuvaj_studenta;
            formater.Serialize(tok, transfer);
            transfer = formater.Deserialize(tok) as Transfer_Klasa;
            if (transfer.Signal == (int)Signali.izvrseno)
            {
                MessageBox.Show("Student je uspesno dodat u bazu.", "Dodaj");
                txtBrojIndeksa.Clear();
                txtImeIPrezime.Clear();
            }
            if (transfer.Signal == (int)Signali.nije_izvrseno)
            {
                MessageBox.Show("Student nije dodat u bazu, proverite podatke!!!", "Dodaj");
            }

        }

        private void btnPronadji_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            Transfer_Klasa transfer = new Transfer_Klasa();

            s.BrojIndeksa = Convert.ToInt32(txtPronadji.Text);
            transfer.Objekat = s;
            transfer.Operacija = (int)Operacije.pronadji_studenta;
            formater.Serialize(tok, transfer);
            transfer = formater.Deserialize(tok) as Transfer_Klasa;
            if (transfer.Signal == (int)Signali.izvrseno)
            {
                s = transfer.Objekat as Student;
                txtPronadjenBrojIndeksa.Text = s.BrojIndeksa.ToString();
                txtPronadjenImeIPrezime.Text = s.Ime;
                txtPronadji.Clear();
            }
            if (transfer.Signal == (int)Signali.nije_izvrseno)
            {
                txtPronadji.Clear();
                txtPronadjenBrojIndeksa.Clear();
                txtPronadjenImeIPrezime.Clear();
                MessageBox.Show("Nije pronadjen student sa unetim brojem indeksa!!!", "Pronadji");
            }
        }

        private void btnOsvezi_Click(object sender, EventArgs e)
        {
            this.dgvSpisakStudenata.DataSource = null;

            Transfer_Klasa transfer = new Transfer_Klasa();
            transfer.Operacija = (int)Operacije.vrati_studente;
            formater.Serialize(tok, transfer);
            transfer = formater.Deserialize(tok) as Transfer_Klasa;
            if (transfer.Signal == (int)Signali.izvrseno)
            {
                this.dgvSpisakStudenata.DataSource = transfer.Objekat as List<Student>;
            }
            if (transfer.Signal == (int)Signali.nije_izvrseno)
            {
                this.dgvSpisakStudenata.DataSource = transfer.Objekat as List<Student>;
                MessageBox.Show("Nema studenata u bazi. Prvo unesite studenta.", "Osvezi");
            }
        }

        private void Klijent_FormClosing(object sender, FormClosingEventArgs e)
        {
            Transfer_Klasa transfer = new Transfer_Klasa();
            transfer.Operacija = (int)Operacije.kraj;
            formater.Serialize(tok, transfer);
            transfer = formater.Deserialize(tok) as Transfer_Klasa;
            if (transfer.Signal == (int)Signali.kraj)
            {
                klijent.Close();
                MessageBox.Show("Hvala na konekciji.", "Server");
            }
            else
            {
                MessageBox.Show("Doslo je do greske prilikom zatvaranja forme!!!");
            }
        }


    }
}
