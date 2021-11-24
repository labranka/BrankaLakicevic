using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Komunikacija;
using Biblioteka;
using System.Windows.Forms;
using System.ComponentModel;

namespace KontrolerKorisnickogInterfejsa
{
    public class KontrolerKl
    {
        public static Komunikacija.Komunikacija komunikacija;
        public static Advokat advokat;
        public static Klijent klijent;
        List<Klijent> listaKlijenta;
        List<Mesto> listaMesta;
        Slucaj novSlucaj;
        Termin termin;

        public static bool poveziSeNaServer()
        {
            komunikacija = new Komunikacija.Komunikacija();
            return komunikacija.poveziSeNaServer();
        }

		public int postaviVrednostiZaPromenuTermina(ComboBox cmbSlucaj, DataGridViewRow currentRow, DataGridView dgvListaTermina, Label lbl1)
		{
            
            List<Slucaj> listaSlucajeva = new List<Slucaj>();
            Klijent izabrani = new Klijent();
            izabrani = currentRow.DataBoundItem as Klijent;
            lbl1.Text = izabrani.ToString();
            Slucaj slu = new Slucaj();
            slu.Advokat = advokat;
            slu.Klijent = izabrani;

            listaSlucajeva = komunikacija.vratiSlucaje(slu) as List<Slucaj> ;
            if (listaSlucajeva.Count == 0)
            {
                MessageBox.Show("Ne postoji ni jedan slucaj za odabranog klijenta!");
                return 2;
            }
            else
            {
                cmbSlucaj.DataSource = listaSlucajeva;
                return 1;
            }
           
		}

		

		//Prikaz termina





		public void prikaziTermine(ComboBox cmbSlucaj, DataGridView dgvListaTermina)
		{
			if(cmbSlucaj.SelectedItem == null || cmbSlucaj.SelectedItem == "")
			{
                MessageBox.Show("Niste odabrali ni jedan slucaj!");
                return;
			}
			else
			{
                Slucaj odabrani = new Slucaj();
                odabrani = cmbSlucaj.SelectedItem as Slucaj;
               
                Termin termincic = new Termin();
                termincic.SlucajID = odabrani.Id;
                List<Termin> zaPrikaz = new List<Termin>();
                zaPrikaz = komunikacija.nadjiTermine(termincic) as List<Termin>;
                
                if (zaPrikaz.Count == 0)
                {
                    MessageBox.Show("Termini koji odgovaraju zadatoj vrednosti nisu pronađeni");
                    return;
                }
                else
                {
                    dgvListaTermina.DataSource = zaPrikaz;
                }
			}
		}

		//azuriranje
		Klijent nov = new Klijent();
        public void postaviPolja(DataGridView dataGridView1, TextBox txtImeKlijenta, TextBox txtPrezimeKlijenta, TextBox txtEmail, TextBox txtKontakt, TextBox txtAdresa, ComboBox cmbMesto)
		{
           
            nov = dataGridView1.CurrentRow.DataBoundItem as Klijent;
            cmbMesto.Text = vratiMesto(nov.Mesto.Id);
            txtImeKlijenta.Text = nov.Ime;
            txtPrezimeKlijenta.Text = nov.Prezime;
            txtEmail.Text = nov.Email;
            txtKontakt.Text = nov.Kontakt;
            txtAdresa.Text = nov.Adresa;
         
           
            
        }

		public void kreirajNovSlucaj(DataGridViewRow currentRow, DataGridView dataGridView1, TextBox txtNazivSlucaja, TextBox txtDatumSudjenja, TextBox txtTerminKonsultacija, TextBox txtNapomena)
		{
            if (txtNazivSlucaja.Text == "" || txtDatumSudjenja.Text == "" )
			{
                MessageBox.Show("Sva polja za Slucaj moraju biti popunjena!");
                return;
			}

             if(komunikacija.sacuvajSlucaj(novSlucaj) != null)
			{
                MessageBox.Show("Sistem je zapamtio slucaj!");
                return;
			}
			else
			{
                MessageBox.Show("Sistem ne moze da zapamti slucaj!");
                return;
            }

           
        }

		public void ubaciTerminUListu(DataGridViewRow currentRow, TextBox txtDatumSudjenja, TextBox txtNazivSlucaja, TextBox txtTerminKonsultacija, TextBox txtNapomena, DataGridView dataGridView1)
		{
            

            novSlucaj.NazivSlucaja = txtNazivSlucaja.Text;
            try
            {
                novSlucaj.DatumSudjenja = DateTime.ParseExact(txtDatumSudjenja.Text, "dd.MM.yyyy HH:mm", null);
            }
            catch (Exception)
            {
                MessageBox.Show("Datum sudjenja nije u dobrom formatu!");
                return;
            }


            
            termin = new Termin();
            termin.Napomena = txtNapomena.Text;
            try
            {
                termin.Datum = DateTime.ParseExact(txtTerminKonsultacija.Text, "dd.MM.yyyy HH:mm", null);
            }
            catch (Exception)
            {
                MessageBox.Show("Datum i vreme termina nisu u dobrom formatu!");
                return;
            }

            if (txtTerminKonsultacija.Text == "" || txtNapomena.Text == "")
            {
                MessageBox.Show("Sva polja za termin moraju biti popunjena!");
                return;
            }

            novSlucaj.ListaTermina.Add(termin);


            dataGridView1.DataSource = novSlucaj.ListaTermina;

        }

		public void postaviPoljaZaSlucaj(DataGridViewRow currentRow, TextBox txtImeKlijenta, TextBox txtPrezimeKlijenta, TextBox txtEmail, TextBox txtKontakt, TextBox txtAdresa, TextBox txtMesto)
		{

            novSlucaj = new Slucaj();
            novSlucaj.ListaTermina = new BindingList<Termin>();
            Klijent klSlucaj = new Klijent();
            klSlucaj = currentRow.DataBoundItem as Klijent;
           
            txtImeKlijenta.Text = klSlucaj.Ime;
            txtImeKlijenta.Enabled = false;

            txtPrezimeKlijenta.Text = klSlucaj.Prezime;
            txtPrezimeKlijenta.Enabled = false;

            txtEmail.Text = klSlucaj.Email;
            txtEmail.Enabled = false;

            txtKontakt.Text = klSlucaj.Kontakt;
            txtKontakt.Enabled = false;

            txtAdresa.Text = klSlucaj.Adresa;
            txtAdresa.Enabled = false;

            txtMesto.Text = vratiMesto(klSlucaj.Mesto.Id);
            txtMesto.Enabled = false;

            novSlucaj.Klijent = klSlucaj;
            novSlucaj.Advokat = advokat;
            
        }

		private string vratiMesto(int id)
		{
            
            listaKlijenta = komunikacija.vratiSveKlijente() as List<Klijent>;
           
            listaMesta = komunikacija.vratiSvaMesta() as List<Mesto>;

            
			foreach(Klijent k in listaKlijenta)
			{
                foreach(Mesto m in listaMesta)
				{
                    if(k.Mesto.Id == m.Id)
					{
                        return m.NazivMesta;
					}
				}
			}
            return "";
		}

	

		public void sacuvajIzmene(TextBox txtImeKlijenta, TextBox txtPrezimeKlijenta, TextBox txtEmail, TextBox txtKontakt, TextBox txtAdresa, object selectedItem)
		{
            nov.Ime = txtImeKlijenta.Text;
            nov.Prezime = txtPrezimeKlijenta.Text;
            nov.Email = txtEmail.Text;
            nov.Kontakt = txtKontakt.Text;
            nov.Adresa = txtAdresa.Text;
           
            nov.Mesto = new Mesto();
            nov.Mesto = selectedItem as Mesto;

            if (komunikacija.azurirajKlijenta(nov) !=null)
			{
                MessageBox.Show("Klijent uspesno azuriran!");
                return;
            }

		}

		public bool obrisiKlijenta(DataGridViewRow currentRow)
		{
            Klijent klzaObrisati = new Klijent();
            klzaObrisati = currentRow.DataBoundItem as Klijent;
            Object rez = komunikacija.obrisiKlijenta(klzaObrisati);

            if (rez == null)
            {
                MessageBox.Show("Zabranjeno je obrisati izabranog klijenta!");
                return false;
            }
            else
            {
                MessageBox.Show("Klijent je obrisan!");
                klijent = null;
                return true;
            }
        }

		public void kraj()
        {
            komunikacija.kraj();
        }

		public bool login(string text1, string text2)
		{
            advokat = new Advokat();
            advokat.Username = text1;
            advokat.Password = text2;

            advokat = komunikacija.Login(advokat) as Advokat;

			if (advokat == null)
			{
                MessageBox.Show("Prijavljivanje neuspesno!");
                return false;
			}
			else
			{
                MessageBox.Show("Prijavljivanje uspesno");
                return true;
			}
		}

		public bool sacuvajKlijenta(string text1, string text2, string text3, string text4, string text5, object selectedItem)
		{
            Klijent novKlijent = new Klijent();

            if (selectedItem.ToString() == "Izaberite mesto!" || selectedItem.ToString() == "")
            {
                MessageBox.Show("Niste odabrali mesto!");
                return false;
            }
            novKlijent.Ime = text1;
            novKlijent.Prezime =text2;
            novKlijent.Kontakt = text3;
            novKlijent.Email = text4;
            novKlijent.Adresa = text5;
            novKlijent.Mesto = new Mesto();
            novKlijent.Mesto = selectedItem as Mesto;

            if (novKlijent.Ime == "" || novKlijent.Prezime == "" || novKlijent.Email == "" || novKlijent.Kontakt == "" || novKlijent.Adresa == "")
            {
                MessageBox.Show("Sva polja moraju biti popunjena!");
                return false;
            }

            

            if (komunikacija.sacuvajKlijenta(novKlijent)!=null)
            {
                MessageBox.Show("Klijent je uspesno sacuvan!");

                return true;
            }
            else
            {
                MessageBox.Show("Klijent nije sacuvan!");
                return false;
            }
        }
        

       


        public void pretraziKlijente(string nazivMesta, DataGridView dataGridView1, ComboBox cbMesto)
		{
            
            
            listaKlijenta = new List<Klijent>();
            listaKlijenta = komunikacija.vratiSveKlijente() as List<Klijent>;
            
            List<Klijent> novaLista = new List<Klijent>();
            
            foreach (Klijent k in listaKlijenta)
            {
                foreach (Mesto m in listaMesta) { 
                    if (k.Mesto.Id == m.Id && m.NazivMesta== nazivMesta)
                    {
                        novaLista.Add(k);
                    } 
                }
            }
            dataGridView1.DataSource = novaLista;

           
            if (novaLista.Count == 0)
			{
                MessageBox.Show("Klijenti koji odgovaraju zadatoj vrednosti nisu pronadjeni!");
                dataGridView1.DataSource = listaKlijenta;
                cbMesto.Text = "Izaberite mesto!";
                return;
            }
            if(novaLista == null)
			{
                MessageBox.Show("Klijenti nisu pronadjeni!");
                return;
            }
            dataGridView1.DataSource = novaLista;
        }

		public void vratiSveKlijente(DataGridView dataGridView1)
		{

            listaKlijenta = new List<Klijent>();
            listaKlijenta = komunikacija.vratiSveKlijente() as List<Klijent>;


            if (listaKlijenta == null)
            {
                MessageBox.Show("Sistem ne moze da ucita Klijente!");
                return;
            }
            dataGridView1.DataSource = listaKlijenta;


        }

        public void vratiSvaMesta(ComboBox cbMesto)
		{
			

            listaMesta = new List<Mesto>();
            listaMesta = komunikacija.vratiSvaMesta() as List<Mesto>;

            if (listaMesta == null)
            {
                MessageBox.Show("Sistem ne moze da ucita Mesta!");
                return;
            }
            cbMesto.DataSource = listaMesta;


            cbMesto.Text = "Izaberite mesto!";
        }
	}
}