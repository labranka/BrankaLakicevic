using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Server
{
    public partial class Form1 : Form
    {
        Server s;
        public Form1()
        {
            s = new Server();
            InitializeComponent();
            if (s.pokreniServer()) this.Text = "Pokrenut server!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
