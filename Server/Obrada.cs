using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using Biblioteka;
using Sesija;
using System.Threading;


using SistemskeOperacije;
using SistemskeOperacije.AdvokatSO;
using SistemskeOperacije.MestoSO;
using SistemskeOperacije.KlijentSO;
using SistemskeOperacije.SlucajSO;

namespace Server
{
    public class Obrada
    {
        BinaryFormatter formater;
        NetworkStream tok;

        public Obrada(NetworkStream tok)
        {
            this.tok = tok;
            formater = new BinaryFormatter();

            ThreadStart ts = obradiKlijenta;
            Thread nit = new Thread(ts);
            nit.Start();
        }

        public void obradiKlijenta() 
        {
            int operacija = 0;
            while (operacija != (int)Operacije.Kraj) 
            {
                TransferKlasa transfer = formater.Deserialize(tok) as TransferKlasa;
                switch (transfer.Operacija)
                {

                    case Operacije.Login:
                        Login log = new Login();
                        transfer.Rezultat = log.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                        formater.Serialize(tok, transfer);
                        break;

                    case Operacije.VratiMesta:
                        VratiMesta vm = new VratiMesta();
                        transfer.Rezultat = vm.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                        formater.Serialize(tok, transfer);
                        break;

                    case Operacije.VratiKlijente:
                        VratiKlijente vk = new VratiKlijente();
                        transfer.Rezultat = vk.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                        formater.Serialize(tok, transfer);
                        break;

                    case Operacije.SacuvajKlijenta:
                        SacuvajKlijenta sk = new SacuvajKlijenta();
                        transfer.Rezultat = sk.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                        formater.Serialize(tok, transfer);
                        break;
                  
                    case Operacije.AzurirajKlijenta:
                        AzurirajKlijenta azk = new AzurirajKlijenta();
                        transfer.Rezultat = azk.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                        formater.Serialize(tok, transfer);
                        break;
                   
                    case Operacije.ObrisiKlijenta:
                        ObrisiKlijenta okl = new ObrisiKlijenta();
                        transfer.Rezultat = okl.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                        formater.Serialize(tok, transfer);
                        break;

                    case Operacije.Zakazi:
                        KreirajSlucaj kkslucaj = new KreirajSlucaj();
                        transfer.Rezultat = kkslucaj.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                        formater.Serialize(tok, transfer);
                        break;

                    case Operacije.VratiSlucaje:
                        VratiSlucaje vslucaje = new VratiSlucaje();
                        transfer.Rezultat = vslucaje.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                        formater.Serialize(tok, transfer);
                        break;

                    case Operacije.NadjiTermine:
                        NadjiTermine nt = new NadjiTermine();
                        transfer.Rezultat = nt.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                        formater.Serialize(tok, transfer);
                        break;
                    case Operacije.Kraj: operacija = 1;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
