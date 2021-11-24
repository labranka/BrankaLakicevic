using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.ComponentModel;

namespace Biblioteka
{
    [Serializable]
    public class Termin:OpstiDomenskiObjekat
    {
        int id;
        int slucajID;
        DateTime datum;
        string napomena;

        [Browsable(false)]
        public int Id { get => id; set => id = value; }
        public DateTime Datum { get => datum; set => datum = value; }
        public string Napomena { get => napomena; set => napomena = value; }
        [Browsable(false)]
        public int SlucajID { get => slucajID; set => slucajID = value; }

        #region ODO
        [Browsable(false)]

        public string tabela
        {
            get { return "Termin"; }
        }
        [Browsable(false)]

        public string kljuc
        {
            get { return null; }
        }
        [Browsable(false)]

        public string uslovJedan
        {
            get { return null; }
        }
        [Browsable(false)]

        public string uslovVise
        {
            get { return " SlucajID=" + slucajID; }
        }
        [Browsable(false)]

        public string azuriranje
        {
            get { return null; }
        }
        [Browsable(false)]

        public string upisivanje
        {
            get { return " values (" + slucajID + ",'" + datum.ToString("yyyy-MM-dd HH:mm") + "','" + napomena.ToString() + "')"; }

        }



        public OpstiDomenskiObjekat napuni(DataRow red)
        {
            Termin sr = new Termin();
            sr.slucajID = Convert.ToInt32(red[0]);
            sr.id = Convert.ToInt32(red[1]);
            sr.datum = Convert.ToDateTime(red[2]);
            sr.napomena = red[3].ToString();


            return sr;
        }
        #endregion
    }
}
