using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.ComponentModel;

namespace Biblioteka
{
    [Serializable]
    public class Klijent : OpstiDomenskiObjekat
    {
        public override string ToString()
        {
            return Ime + " " + Prezime;
        }



        int id;
        string ime;
        string prezime;
        string email;
        string kontakt;
        string adresa;
        Mesto mesto;

        [Browsable(false)]
        public int Id { get => id; set => id = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        
        public string Email { get => email; set => email = value; }
        
        public string Kontakt { get => kontakt; set => kontakt = value; }
        [Browsable(false)]
        public string Adresa { get => adresa; set => adresa = value; }
        [Browsable(false)]
        public Mesto Mesto { get => mesto; set => mesto = value; }
        
        #region ODO
        [Browsable(false)]
        public string tabela
        {
            get { return "Klijent"; }
        }
        [Browsable(false)]
        public string kljuc
        {
            get { return "KlijentID"; }
        }
        [Browsable(false)]
        public string uslovJedan
        {
            get { return "KlijentID=" + id; }
        }
        [Browsable(false)]
        public string uslovVise
        {
            get { return null; }
        }
        [Browsable(false)]
        public string azuriranje
        {
            get { return " ImeKlijenta='" + ime.ToString() + "', PrezimeKlijenta='" + prezime.ToString() + "', Email='" + email.ToString() + "', Kontakt='" + kontakt.ToString() + "', Adresa='" + adresa.ToString() + "', MestoID=" + mesto.Id + ""; }
        }
        [Browsable(false)]
        public string upisivanje
        {
            get { return "values('" + ime.ToString() + "','" + prezime.ToString() + "','" + email.ToString() + "','" + kontakt.ToString() + "', '" + adresa.ToString() + "'," + mesto.Id + ")"; }
        }
        [Browsable(false)]
        public OpstiDomenskiObjekat napuni(DataRow red)
        {
            Klijent l = new Klijent();
            l.id = Convert.ToInt32(red[0]);
            l.ime = red[1].ToString();
            l.prezime = red[2].ToString();
            l.email = red[3].ToString();
            l.kontakt = red[4].ToString();
            l.adresa = red[5].ToString();
            l.Mesto = new Mesto();
            l.Mesto.Id = Convert.ToInt32(red[6]);
            return l;
        }
        #endregion
    }
}
