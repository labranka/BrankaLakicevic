using Biblioteka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemskeOperacije.KlijentSO
{
	public class SacuvajKlijenta : OpstaSO
	{
		public override object Izvrsi(OpstiDomenskiObjekat odo)
		{
			Klijent k = odo as Klijent;
			Sesija.Broker.dajSesiju().sacuvaj(k);
			return k;
		}
	}
}
