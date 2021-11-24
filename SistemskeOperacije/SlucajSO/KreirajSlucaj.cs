using Biblioteka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemskeOperacije.SlucajSO
{
	public class KreirajSlucaj : OpstaSO
	{
		public override object Izvrsi(OpstiDomenskiObjekat odo)
		{

			Slucaj s = odo as Slucaj;
			s.Id = Sesija.Broker.dajSesiju().dajSifru(s);
			
			
			Sesija.Broker.dajSesiju().sacuvaj(s);




			foreach (Termin tr in s.ListaTermina)
			{
				tr.SlucajID = s.Id;
				Sesija.Broker.dajSesiju().sacuvaj(tr);
			}

			return 1;
		}
	}
}
