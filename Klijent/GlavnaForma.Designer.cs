namespace Klijent
{
    partial class GlavnaForma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GlavnaForma));
			this.btnUnos = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnPretrazi = new System.Windows.Forms.Button();
			this.cbMesto = new System.Windows.Forms.ComboBox();
			this.btnIzaberi = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnIzmeni = new System.Windows.Forms.Button();
			this.btnObrisiKlijenta = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnUnos
			// 
			this.btnUnos.Location = new System.Drawing.Point(325, 168);
			this.btnUnos.Name = "btnUnos";
			this.btnUnos.Size = new System.Drawing.Size(146, 24);
			this.btnUnos.TabIndex = 1;
			this.btnUnos.Text = "Unesi novog klijenta";
			this.btnUnos.UseVisualStyleBackColor = true;
			this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
			// 
			// dataGridView1
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Green;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DarkGreen;
			this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.GreenYellow;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(6, 48);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(465, 106);
			this.dataGridView1.TabIndex = 2;
			// 
			// btnPretrazi
			// 
			this.btnPretrazi.Location = new System.Drawing.Point(139, 20);
			this.btnPretrazi.Name = "btnPretrazi";
			this.btnPretrazi.Size = new System.Drawing.Size(127, 22);
			this.btnPretrazi.TabIndex = 3;
			this.btnPretrazi.Text = "Pretrazi klijente";
			this.btnPretrazi.UseVisualStyleBackColor = true;
			this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
			// 
			// cbMesto
			// 
			this.cbMesto.FormattingEnabled = true;
			this.cbMesto.Location = new System.Drawing.Point(6, 20);
			this.cbMesto.Name = "cbMesto";
			this.cbMesto.Size = new System.Drawing.Size(127, 22);
			this.cbMesto.TabIndex = 6;
			// 
			// btnIzaberi
			// 
			this.btnIzaberi.Location = new System.Drawing.Point(18, 220);
			this.btnIzaberi.Name = "btnIzaberi";
			this.btnIzaberi.Size = new System.Drawing.Size(470, 24);
			this.btnIzaberi.TabIndex = 8;
			this.btnIzaberi.Text = "Definisi nov slucaj za odabranog klijenta";
			this.btnIzaberi.UseVisualStyleBackColor = true;
			this.btnIzaberi.Click += new System.EventHandler(this.btnIzaberi_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnIzmeni);
			this.groupBox1.Controls.Add(this.btnObrisiKlijenta);
			this.groupBox1.Controls.Add(this.dataGridView1);
			this.groupBox1.Controls.Add(this.btnUnos);
			this.groupBox1.Controls.Add(this.cbMesto);
			this.groupBox1.Controls.Add(this.btnPretrazi);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(486, 202);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Klijent";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// btnIzmeni
			// 
			this.btnIzmeni.Location = new System.Drawing.Point(170, 168);
			this.btnIzmeni.Name = "btnIzmeni";
			this.btnIzmeni.Size = new System.Drawing.Size(142, 24);
			this.btnIzmeni.TabIndex = 10;
			this.btnIzmeni.Text = "Izmeni klijenta";
			this.btnIzmeni.UseVisualStyleBackColor = true;
			this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
			// 
			// btnObrisiKlijenta
			// 
			this.btnObrisiKlijenta.Location = new System.Drawing.Point(6, 168);
			this.btnObrisiKlijenta.Name = "btnObrisiKlijenta";
			this.btnObrisiKlijenta.Size = new System.Drawing.Size(142, 24);
			this.btnObrisiKlijenta.TabIndex = 9;
			this.btnObrisiKlijenta.Text = "Obrisi klijenta";
			this.btnObrisiKlijenta.UseVisualStyleBackColor = true;
			this.btnObrisiKlijenta.Click += new System.EventHandler(this.btnObrisiKlijenta_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(18, 250);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(470, 24);
			this.button1.TabIndex = 10;
			this.button1.Text = "Pregled termina";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// GlavnaForma
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(500, 283);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnIzaberi);
			this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "GlavnaForma";
			this.Text = "Rad sa klijentima";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GlavnaForma_FormClosed);
			this.Load += new System.EventHandler(this.GlavnaForma_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnUnos;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnPretrazi;
		private System.Windows.Forms.ComboBox cbMesto;
		private System.Windows.Forms.Button btnIzaberi;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnIzmeni;
		private System.Windows.Forms.Button btnObrisiKlijenta;
		private System.Windows.Forms.Button button1;
	}
}