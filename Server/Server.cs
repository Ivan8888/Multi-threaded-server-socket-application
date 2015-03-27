using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Domen;

namespace Server
{
    public partial class Server : Form
    {
        List<Klijent> listaUlogovanih = new List<Klijent>();
        public delegate void delegatZaPrikazivanjeListe(Klijent k);

        public Server()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread nit = new Thread(new ThreadStart(poveziSe));
            nit.Start();
        }

        private void poveziSe()
        {
            int redBroj = 1;

            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            s.Bind(new IPEndPoint(IPAddress.Any, 10000));
            s.Listen(5);
            while (true)
            {
                Socket klijent = s.Accept();
                MessageBox.Show("Konekcija je uspesna.", "Server");
                Obrada o = new Obrada(klijent);
                Thread nit = new Thread(new ThreadStart(o.izvrsiNaredbu));
                nit.Start();
                delegatZaPrikazivanjeListe izmenaForme = noviKlijent;
                this.Invoke(izmenaForme, new Klijent(redBroj, klijent));
                redBroj++;
            }
        }

        public void noviKlijent(Klijent k)
        {
            listaUlogovanih.Add(k);
            Osvezi();
        }

        public void Osvezi()
        {
            lbUlogovaniKorisnici.Items.Clear();
            foreach (Klijent k in listaUlogovanih)
            {
                lbUlogovaniKorisnici.Items.Add(k);
            }
        }

        private void btnRefreshClient_Click(object sender, EventArgs e)
        {
            Osvezi();
        }

        private void btnDisconnectClient_Click(object sender, EventArgs e)
        {
            if (lbUlogovaniKorisnici.SelectedItem != null)
            {
                Klijent k = lbUlogovaniKorisnici.SelectedItem as Klijent;
                k.KSoket.Shutdown(SocketShutdown.Both);
                k.KSoket.Disconnect(false);

                listaUlogovanih.RemoveAt(k.Id - 1);
                Osvezi();
            }
            else
            {
                MessageBox.Show("Prvo morate selectovati klijenta koga zelite da diskonektujete.");
            }
        }
    }
}