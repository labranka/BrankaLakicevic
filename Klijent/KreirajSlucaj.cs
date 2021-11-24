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
	public partial class KreirajSlucaj : Form
	{
		DataGridViewRow currentRow;
		KontrolerKorisnickogInterfejsa.KontrolerKl kki = new KontrolerKorisnickogInterfejsa.KontrolerKl();
		public KreirajSlucaj(DataGridViewRow currentRow)
		{
			InitializeComponent();
			this.currentRow = currentRow;
			
		}

		private void label11_Click(object sender, EventArgs e)
		{

		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		
		private void IzaberiKlijenta_Load_1(object sender, EventArgs e)
		{
			kki.postaviPoljaZaSlucaj(currentRow, txtImeKlijenta, txtPrezimeKlijenta, txtEmail, txtKontakt, txtAdresa, txtMesto);



		}

		private void btnUnesiTermin_Click(object sender, EventArgs e)
		{

			kki.ubaciTerminUListu(currentRow,txtDatumSudjenja,txtNazivSlucaja,txtTerminKonsultacija, txtNapomena, dataGridView1);

		}

		private void button1_Click(object sender, EventArgs e)
		{
			kki.kreirajNovSlucaj(currentRow, dataGridView1, txtNazivSlucaja, txtDatumSudjenja, txtTerminKonsultacija,txtNapomena);
			
		}

		private void button2_Click(object sender, EventArgs e)
		{
			
		}

		private void cbSlucajevi_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
