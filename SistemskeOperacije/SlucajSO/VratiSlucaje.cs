using Biblioteka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemskeOperacije.SlucajSO
{
	public class VratiSlucaje : OpstaSO
	{
		public override object Izvrsi(OpstiDomenskiObjekat odo)
		{
			return Sesija.Broker.dajSesiju().dajSveZaUslovVise(odo).OfType<Slucaj>().ToList<Slucaj>();
		}
	}
}
