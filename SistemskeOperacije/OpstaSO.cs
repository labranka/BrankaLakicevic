using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteka;
using Sesija;

namespace SistemskeOperacije
{
    public abstract class OpstaSO
    {
        public Object izvrsiSO(OpstiDomenskiObjekat odo)
        {
            Object rezultat = null;
            Broker.dajSesiju().otvoriKonekciju();
            Broker.dajSesiju().zapocniTransakciju();
            try
            {
                rezultat = Izvrsi(odo);
                Broker.dajSesiju().potvrdiTransakciju();
            }
            catch (Exception)
            {

                Broker.dajSesiju().ponistiTransakciju();
            }
            finally
            {
                Broker.dajSesiju().zatvoriKonekciju();
            }

            return rezultat;
        }

        public abstract object Izvrsi(OpstiDomenskiObjekat odo);
        

    }
}
