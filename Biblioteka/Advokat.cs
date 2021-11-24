using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Biblioteka
{
    [Serializable]
    public class Advokat:OpstiDomenskiObjekat
    {
        public override string ToString()
        {
            return Ime + " " + Prezime;
        }
       



        int id;
        string ime;
        string prezime;
        string username;
        string password;

        public int Id { get => id; set => id = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        public string tabela
        {
            get { return "Advokat"; }
        }

        public string kljuc
        {
            get { return "AdvokatID"; }
        }

        public string uslovJedan
        {
            get { return "AdvokatID=" + id; }
        }

        public string uslovVise
        {
            get { return " Username='" + username.ToString() + "'and Password='" + password.ToString() +"'"; }
        }

        public string azuriranje
        {
            get { return null; }
        }

        public string upisivanje
        {
            get { return null; }
        }

        public OpstiDomenskiObjekat napuni(DataRow red)
        {
            Advokat d = new Advokat();
            d.Id = Convert.ToInt32(red[0]);
            d.Ime = red[1].ToString();
            d.Prezime = red[2].ToString();
            d.Username = red[3].ToString();
            d.Password = red[4].ToString();
            return d;
        }
    }
}

