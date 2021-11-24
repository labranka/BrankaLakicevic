
namespace Klijent
{
	partial class PregledTermina
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PregledTermina));
			this.cmbSlucaj = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dgvListaTermina = new System.Windows.Forms.DataGridView();
			this.lbl1 = new System.Windows.Forms.Label();
			this.btnIzmeni = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvListaTermina)).BeginInit();
			this.SuspendLayout();
			// 
			// cmbSlucaj
			// 
			this.cmbSlucaj.FormattingEnabled = true;
			this.cmbSlucaj.Location = new System.Drawing.Point(12, 12);
			this.cmbSlucaj.Name = "cmbSlucaj";
			this.cmbSlucaj.Size = new System.Drawing.Size(422, 21);
			this.cmbSlucaj.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 84);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(86, 13);
			this.label2.TabIndex = 9;
			this.label2.Text = "Definisani termini";
			// 
			// dgvListaTermina
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkOliveGreen;
			this.dgvListaTermina.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvListaTermina.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvListaTermina.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvListaTermina.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvListaTermina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvListaTermina.Location = new System.Drawing.Point(12, 100);
			this.dgvListaTermina.Name = "dgvListaTermina";
			this.dgvListaTermina.Size = new System.Drawing.Size(425, 179);
			this.dgvListaTermina.TabIndex = 5;
			// 
			// lbl1
			// 
			this.lbl1.AutoSize = true;
			this.lbl1.Location = new System.Drawing.Point(12, 36);
			this.lbl1.Name = "lbl1";
			this.lbl1.Size = new System.Drawing.Size(44, 13);
			this.lbl1.TabIndex = 10;
			this.lbl1.Text = "Korisnik";
			// 
			// btnIzmeni
			// 
			this.btnIzmeni.Location = new System.Drawing.Point(318, 39);
			this.btnIzmeni.Name = "btnIzmeni";
			this.btnIzmeni.Size = new System.Drawing.Size(116, 23);
			this.btnIzmeni.TabIndex = 12;
			this.btnIzmeni.Text = "Prikazi termine";
			this.btnIzmeni.UseVisualStyleBackColor = true;
			this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
			// 
			// PregledTermina
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(447, 291);
			this.Controls.Add(this.btnIzmeni);
			this.Controls.Add(this.lbl1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dgvListaTermina);
			this.Controls.Add(this.cmbSlucaj);
			this.ForeColor = System.Drawing.Color.Black;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "PregledTermina";
			this.Text = "PregledTermina";
			this.Load += new System.EventHandler(this.PromeniTermine_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvListaTermina)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cmbSlucaj;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dgvListaTermina;
		private System.Windows.Forms.Label lbl1;
		private System.Windows.Forms.Button btnIzmeni;
	}
}