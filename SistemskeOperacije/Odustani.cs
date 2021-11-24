using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemskeOperacije
{
    public class Odustani:OpstaSO
    {
        public override object Izvrsi(Biblioteka.OpstiDomenskiObjekat odo)
        {
            return Sesija.Broker.dajSesiju().obrisi(odo);
        }
    }
}
