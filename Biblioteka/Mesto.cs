using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.ComponentModel;

namespace Biblioteka
{
    [Serializable]
    public class Mesto:OpstiDomenskiObjekat
    {

        public override string ToString()
        {
            return NazivMesta;
        }

        

        public Mesto()
        {
            ListaKlijenata = new BindingList<Klijent>();
        }

        int id;
        string nazivMesta;
        int ptt;
        BindingList<Biblioteka.Klijent> listaKlijenata;

        public int Id { get => id; set => id = value; }
        public string NazivMesta { get => nazivMesta; set => nazivMesta = value; }
        public BindingList<Klijent> ListaKlijenata { get => listaKlijenata; set => listaKlijenata = value; }
        public int Ptt { get => ptt; set => ptt = value; }

        #region ODO
        public string tabela
        {
            get { return "Mesto"; }
        }

        public string kljuc
        {
            get { return "MestoID"; }
        }

        public string uslovJedan
        {
            get { return "MestoID=" + id; }
        }

        public string uslovVise
        {
            get { return null; }
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
            Mesto s = new Mesto();
            s.id = Convert.ToInt32(red[0]);
            s.nazivMesta = red[1].ToString();
            s.ptt = Convert.ToInt32(red[2]);
            return s;
        }
        #endregion
    }
}
