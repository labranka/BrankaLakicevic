using Biblioteka;
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
    public partial class Login : Form
    {
        KontrolerKorisnickogInterfejsa.KontrolerKl kki = new KontrolerKorisnickogInterfejsa.KontrolerKl();
        public Login()
        {
            InitializeComponent();
            if (KontrolerKl.poveziSeNaServer()) this.Text = "Uspesno povezan!";
        }

        private void FormKlijent_Load(object sender, EventArgs e)
        {
            
        }

        private void FormKlijent_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (kki.login(txtKorIme.Text, txtLozinka.Text))
            {
                new GlavnaForma().Show();
                this.Hide();
            }
        }

		private void txtLozinka_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
