using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.ComponentModel;

namespace Biblioteka
{
    [Serializable]
    public class Slucaj:OpstiDomenskiObjekat
    {
        public Slucaj()
        {
            ListaTermina = new BindingList<Termin>();
        }

        public override string ToString()
        {
            return nazivSlucaja;
        }



        int id;
        string nazivSlucaja;
        DateTime datumSudjenja;
        Advokat advokat;
        Klijent klijent;
        BindingList<Termin> listaTermina;

        [Browsable(false)]
        public int Id { get => id; set => id = value; }
        public string NazivSlucaja { get => nazivSlucaja; set => nazivSlucaja = value; }
        public DateTime DatumSudjenja { get => datumSudjenja; set => datumSudjenja = value; }
        [Browsable(false)]
        public BindingList<Termin> ListaTermina { get => listaTermina; set => listaTermina = value; }
        public Advokat Advokat { get => advokat; set => advokat = value; }
        public Klijent Klijent { get => klijent; set => klijent = value; }


        #region ODO
        public string tabela
        {
            get { return "Slucaj"; }
        }

        public string kljuc
        {
            get { return "SlucajID"; }
        }

        public string uslovJedan
        {
            get { return "KlijentID=" + klijent.Id; }
        }

        public string uslovVise
        {
            get { return "KlijentID="+klijent.Id +" and AdvokatID=" + advokat.Id; }
        }

        public string azuriranje
        {
            get { return " NazivSlucaja='" + nazivSlucaja.ToString() + "', DatumSudjenja='" + datumSudjenja.ToString("yyyy-MM-dd HH:mm") + "', AdvokatID=" + advokat.Id + ", KlijentID=" + klijent.Id + ""; }
        }
        public string upisivanje
        {
            get { return " values (" + id + ", '"+nazivSlucaja.ToString()+"', '"+datumSudjenja.ToString("yyyy-MM-dd HH:mm")+"', "+advokat.Id+", "+klijent.Id+")"; }
        }

        public OpstiDomenskiObjekat napuni(DataRow red)
        {
            Slucaj s = new Slucaj();
            s.id = Convert.ToInt32(red[0]);
            s.nazivSlucaja = red[1].ToString();
            s.datumSudjenja = Convert.ToDateTime(red[2]);
            s.advokat = new Advokat();
            s.advokat.Id = Convert.ToInt32(red[3]);
            s.klijent = new Klijent();
            s.klijent.Id = Convert.ToInt32(red[4]);
            return s;
        }
        #endregion
    }
}
