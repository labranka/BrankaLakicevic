
namespace Klijent
{
	partial class AzurirajKlijenta
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AzurirajKlijenta));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtImeKlijenta = new System.Windows.Forms.TextBox();
			this.btnSacuvaj = new System.Windows.Forms.Button();
			this.txtPrezimeKlijenta = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtKontakt = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtAdresa = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cmbMesto = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.txtEmail);
			this.groupBox1.Controls.Add(this.txtImeKlijenta);
			this.groupBox1.Controls.Add(this.btnSacuvaj);
			this.groupBox1.Controls.Add(this.txtPrezimeKlijenta);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txtKontakt);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txtAdresa);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.cmbMesto);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(300, 263);
			this.groupBox1.TabIndex = 28;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Klijent";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(137, 92);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(157, 22);
			this.txtEmail.TabIndex = 15;
			// 
			// txtImeKlijenta
			// 
			this.txtImeKlijenta.Location = new System.Drawing.Point(137, 18);
			this.txtImeKlijenta.Name = "txtImeKlijenta";
			this.txtImeKlijenta.Size = new System.Drawing.Size(157, 22);
			this.txtImeKlijenta.TabIndex = 13;
			// 
			// btnSacuvaj
			// 
			this.btnSacuvaj.Location = new System.Drawing.Point(10, 229);
			this.btnSacuvaj.Name = "btnSacuvaj";
			this.btnSacuvaj.Size = new System.Drawing.Size(270, 23);
			this.btnSacuvaj.TabIndex = 25;
			this.btnSacuvaj.Text = "Azuriraj klijenta";
			this.btnSacuvaj.UseVisualStyleBackColor = true;
			this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
			// 
			// txtPrezimeKlijenta
			// 
			this.txtPrezimeKlijenta.Location = new System.Drawing.Point(137, 55);
			this.txtPrezimeKlijenta.Name = "txtPrezimeKlijenta";
			this.txtPrezimeKlijenta.Size = new System.Drawing.Size(157, 22);
			this.txtPrezimeKlijenta.TabIndex = 14;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(7, 205);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(96, 16);
			this.label6.TabIndex = 24;
			this.label6.Text = "Izaberite mesto:";
			// 
			// txtKontakt
			// 
			this.txtKontakt.Location = new System.Drawing.Point(137, 128);
			this.txtKontakt.Name = "txtKontakt";
			this.txtKontakt.Size = new System.Drawing.Size(157, 22);
			this.txtKontakt.TabIndex = 16;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(7, 169);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(45, 16);
			this.label5.TabIndex = 23;
			this.label5.Text = "Adresa";
			// 
			// txtAdresa
			// 
			this.txtAdresa.Location = new System.Drawing.Point(137, 163);
			this.txtAdresa.Name = "txtAdresa";
			this.txtAdresa.Size = new System.Drawing.Size(157, 22);
			this.txtAdresa.TabIndex = 17;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(7, 134);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 16);
			this.label4.TabIndex = 22;
			this.label4.Text = "Kontakt";
			// 
			// cmbMesto
			// 
			this.cmbMesto.FormattingEnabled = true;
			this.cmbMesto.Location = new System.Drawing.Point(137, 198);
			this.cmbMesto.Name = "cmbMesto";
			this.cmbMesto.Size = new System.Drawing.Size(157, 24);
			this.cmbMesto.TabIndex = 18;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(7, 98);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 16);
			this.label3.TabIndex = 21;
			this.label3.Text = "Email";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 16);
			this.label1.TabIndex = 19;
			this.label1.Text = "Ime klijenta:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 61);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(98, 16);
			this.label2.TabIndex = 20;
			this.label2.Text = "Prezime klijenta:";
			// 
			// AzurirajKlijenta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(320, 287);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "AzurirajKlijenta";
			this.Text = "AzurirajKlijenta";
			this.Load += new System.EventHandler(this.AzurirajKlijenta_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtImeKlijenta;
		private System.Windows.Forms.Button btnSacuvaj;
		private System.Windows.Forms.TextBox txtPrezimeKlijenta;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtKontakt;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtAdresa;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cmbMesto;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}