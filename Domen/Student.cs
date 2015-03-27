using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Student
    {
        int brojIndeksa;
        public int BrojIndeksa
        {
            get { return brojIndeksa; }
            set { brojIndeksa = value; }
        }

        string ime;
        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        public override string ToString()
        {
            return ime;
        }
    }
}

