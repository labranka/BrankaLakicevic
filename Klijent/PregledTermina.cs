using KontrolerKorisnickogInterfejsa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Klijent
{
	public partial class PregledTermina : Form
	{
		KontrolerKl kki = new KontrolerKl();
		DataGridViewRow currentRow;
		public PregledTermina(DataGridViewRow currentRow)
		{
			InitializeComponent();
			this.currentRow = currentRow;
		}

		private void PromeniTermine_Load(object sender, EventArgs e)
		{
			if ((kki.postaviVrednostiZaPromenuTermina(cmbSlucaj, currentRow, dgvListaTermina,lbl1))==2)
				{
				
				this.Close();
				return;
			}
			
			
		}

		

		private void btnIzmeni_Click(object sender, EventArgs e)
		{
			kki.prikaziTermine(cmbSlucaj, dgvListaTermina);
			
		}

		private void btnSacuvajIzmene_Click(object sender, EventArgs e)
		{
			
		}

		private void btnObrisi_Click(object sender, EventArgs e)
		{
			
		}

		private void btnPromeni_Click(object sender, EventArgs e)
		{
			
		}

		private void btnDodaj_Click(object sender, EventArgs e)
		{
			
		}
	}
}
