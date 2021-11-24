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
	public partial class AzurirajKlijenta : Form
	{
		KontrolerKorisnickogInterfejsa.KontrolerKl kki = new KontrolerKorisnickogInterfejsa.KontrolerKl();
		DataGridView dataGridView1;

		public AzurirajKlijenta(DataGridView dataGridView1)
		{
			InitializeComponent();
			this.dataGridView1 = dataGridView1;
		}

		private void AzurirajKlijenta_Load(object sender, EventArgs e)
		{
			kki.vratiSvaMesta(cmbMesto);
			kki.postaviPolja(dataGridView1, txtImeKlijenta, txtPrezimeKlijenta, txtEmail, txtKontakt, txtAdresa, cmbMesto);
		}

		

		private void btnSacuvaj_Click(object sender, EventArgs e)
		{
			if (cmbMesto.Text == "Izaberite mesto!")
			{
				MessageBox.Show("Niste odabrali mesto!");
				return;
			}
			kki.sacuvajIzmene(txtImeKlijenta, txtPrezimeKlijenta, txtEmail, txtKontakt, txtAdresa, cmbMesto.SelectedItem);
			this.Close();
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}
	}
}
