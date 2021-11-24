
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
    public partial class GlavnaForma : Form
    {
        KontrolerKl kki = new KontrolerKl();
        public GlavnaForma()
        {
         
            InitializeComponent();
            
        }

        private void GlavnaForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

      

        private void GlavnaForma_Load(object sender, EventArgs e)
        {
             
            kki.vratiSvaMesta(cbMesto);
            kki.vratiSveKlijente(dataGridView1);
            cbMesto.Text = "Izaberite mesto!";
        }

		private void btnUnos_Click(object sender, EventArgs e)
		{
            new UnosKlijenta().ShowDialog();
           
		}

        
		private void btnPretrazi_Click(object sender, EventArgs e)
		{
            if (cbMesto.Text == "Izaberite mesto!")
			{
                MessageBox.Show("Niste odabrali mesto!");
                return;
            }
            kki.pretraziKlijente(cbMesto.SelectedItem.ToString(),dataGridView1, cbMesto);
            
		}

		private void btnIzaberi_Click(object sender, EventArgs e)
		{
            try
            {
                if (dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Klijent nije pronadjen!");
                }
                else
                {
                    new KreirajSlucaj(dataGridView1.CurrentRow).Show(); 

                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Klijent nije pronadjen!");
            }

        }

		

		private void btnObrisiKlijenta_Click(object sender, EventArgs e)
		{
            try
            {
                if (dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Klijent nije pronadjen!");
                }
                else
                {
					if (kki.obrisiKlijenta(dataGridView1.CurrentRow)==false)
					{
                       
                        return;
					}
                    GlavnaForma_Load(sender, e);
                    dataGridView1.Refresh();

                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Klijent nije pronadjen!");
            }



        }

        private void btnIzmeni_Click(object sender, EventArgs e)
		{
            
            try
            {
                if (dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Klijent nije pronadjen!");
                }
                else
                {
                    new AzurirajKlijenta(dataGridView1).Show();
                    

                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Klijent nije pronadjen!");
            }
            
           
        }

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
            try
            {
                if (dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Klijent nije pronadjen!");
                }
                else
                {
                    new PregledTermina(dataGridView1.CurrentRow).Show();

                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Klijent nije pronadjen!");
            }


        }
	}
}
