using Biblioteka;
using Sesija;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemskeOperacije.AdvokatSO
{
	public class Login : OpstaSO
	{
		public override object Izvrsi(OpstiDomenskiObjekat odo)
		{
			Advokat a = new Advokat();
			a = Sesija.Broker.dajSesiju().dajZaUslovVise(odo) as Advokat;

			return a;
		}
	}
}
