using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Net.Sockets;
using Biblioteka;

namespace Komunikacija
{
    public class Komunikacija
    {
        TcpClient klijent;
        BinaryFormatter formater;
        NetworkStream tok;

        public bool poveziSeNaServer()
        {
            try
            {
                klijent = new TcpClient("127.0.0.1", 10001);
                tok = klijent.GetStream();
                formater = new BinaryFormatter();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }


        public void kraj() 
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.Kraj;
            formater.Serialize(tok, transfer);
        }


        public object Login(Advokat l)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.Login;
            transfer.TransferObjekat = l;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }


        public object vratiSvaMesta()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.VratiMesta;
            transfer.TransferObjekat = new Mesto();
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public object sacuvajKlijenta(Biblioteka.Klijent klijent)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.SacuvajKlijenta;
            transfer.TransferObjekat = klijent;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }
        public object vratiSveKlijente()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.VratiKlijente;
            transfer.TransferObjekat = new Klijent();
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public object nadjiKlijente(string naziv)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.NadjiKlijente;
            transfer.TransferObjekat = naziv;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public object azurirajKlijenta(Biblioteka.Klijent klijent)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.AzurirajKlijenta;
            transfer.TransferObjekat = klijent;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }
        public object obrisiKlijenta(Biblioteka.Klijent klijent)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ObrisiKlijenta;
            transfer.TransferObjekat = klijent;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public object sacuvajSlucaj(Slucaj s)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.Zakazi;
            transfer.TransferObjekat = s;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }
        public object vratiSlucaje(Slucaj s)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.VratiSlucaje;
            transfer.TransferObjekat = s;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public object nadjiTermine(Termin s)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.NadjiTermine;
            transfer.TransferObjekat = s;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }
        public object izmeniSlucaj(Slucaj s)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.IzmeniSlucaj;
            transfer.TransferObjekat = s;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }



    }
}
