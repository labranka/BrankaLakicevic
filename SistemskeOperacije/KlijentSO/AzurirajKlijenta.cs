using Biblioteka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemskeOperacije.KlijentSO
{
	public class AzurirajKlijenta : OpstaSO
	{
		public override object Izvrsi(OpstiDomenskiObjekat odo)
		{
			return Sesija.Broker.dajSesiju().izmeni(odo);
		}
	}
}
