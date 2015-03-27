using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace Domen
{
    public class Klijent
    {
        int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        Socket kSoket;
        public Socket KSoket
        {
            get { return kSoket; }
            set { kSoket = value; }
        }

        public Klijent(int id, Socket s)
        {
            this.id = id;
            this.kSoket = s;
        }

        public override string ToString()
        {
            return "Redni broj: " + id + " Adresa: " + kSoket.RemoteEndPoint;
        }


    }
}

