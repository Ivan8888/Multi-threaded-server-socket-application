using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Domen;

namespace Sesija
{
    public class Broker
    {
        SqlConnection konekcija;
        SqlCommand komanda;

        private void konektujSe()
        {
            konekcija = new SqlConnection("Data Source = .; Initial Catalog = Student; Integrated Security=True");
            komanda = konekcija.CreateCommand();
        }

        static Broker instanca;

        private Broker()
        {
            konektujSe();

        }

        public static Broker dajBrokera()
        {
            if (instanca == null)
            {
                instanca = new Broker();
            }
            return instanca;
        }

        public int dodajStudenta(Student s)
        {
            int rezultat = 0;
            try
            {
                komanda.CommandText = "INSERT INTO StudentId VALUES ('" + s.BrojIndeksa + "' , '" + s.Ime + "')";
                komanda.CommandType = System.Data.CommandType.Text;
                konekcija.Open();
                rezultat = komanda.ExecuteNonQuery();
                return rezultat;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex1)
            {
                throw ex1;
            }
            finally
            {
                if (konekcija != null)
                {
                    konekcija.Close();
                }
            }
        }

        public Student pronadjiStudenta(int brInd)
        {
            Student s = new Student();
            try
            {
                komanda.CommandText = "SELECT * FROM StudentId WHERE StudentId.BrIndeksa = '" + brInd + "'";
                komanda.CommandType = System.Data.CommandType.Text;
                konekcija.Open();
                SqlDataReader reader = komanda.ExecuteReader();
                if (reader.Read())
                {
                    s.BrojIndeksa = reader.GetInt32(0);
                    s.Ime = Convert.ToString(reader[1]);
                }
                else
                {
                    s = null;
                }
                return s;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (konekcija != null)
                {
                    konekcija.Close();
                }
            }
        }

        public List<Student> vratiSveStudente()
        {
            List<Student> lista = new List<Student>();
            try
            {
                komanda.CommandText = "SELECT * FROM StudentId";
                komanda.CommandType = System.Data.CommandType.Text;
                konekcija.Open();
                SqlDataReader reader = komanda.ExecuteReader();
                while (reader.Read())
                {
                    Student s = new Student();
                    s.BrojIndeksa = reader.GetInt32(0);
                    s.Ime = reader.GetString(1);
                    lista.Add(s);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (konekcija != null)
                {
                    konekcija.Close();
                }
            }
        }
    }
}

