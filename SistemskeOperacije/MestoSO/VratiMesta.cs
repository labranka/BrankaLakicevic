using Biblioteka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemskeOperacije.MestoSO
{
	public class VratiMesta : OpstaSO
	{
		public override object Izvrsi(OpstiDomenskiObjekat odo)
		{
			return Sesija.Broker.dajSesiju().dajSve(odo).OfType<Mesto>().ToList<Mesto>();
		}
	}
}
