using Biblioteka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemskeOperacije.KlijentSO
{
	public class VratiKlijente : OpstaSO
	{
		public override object Izvrsi(OpstiDomenskiObjekat odo)
		{
			return Sesija.Broker.dajSesiju().dajSve(odo).OfType<Klijent>().ToList<Klijent>();
		}
	}
	
}
