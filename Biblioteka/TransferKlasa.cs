using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteka
{
    public enum Operacije { Kraj = 1,
		VratiMesta = 2,
		VratiSlucaje = 3,
		IzmeniSlucaj = 4,
		Zakazi = 5,
		ObrisiKlijenta = 6,
		AzurirajKlijenta = 7,
		NadjiKlijente = 8,
		VratiKlijente = 9,
		SacuvajKlijenta = 10,
		Login = 11,
		NadjiTermine = 12
	}
    [Serializable]
    public class TransferKlasa
    {
        Operacije operacija;

        public Operacije Operacija
        {
            get { return operacija; }
            set { operacija = value; }
        }
        Object transferObjekat;

        public Object TransferObjekat
        {
            get { return transferObjekat; }
            set { transferObjekat = value; }
        }
        Object rezultat;

        public Object Rezultat
        {
            get { return rezultat; }
            set { rezultat = value; }
        }
    }
}
