namespace CurrencyRate.WinApp
{
	partial class Form1
	{
		/// <summary>
		///Gerekli tasarımcı değişkeni.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///Kullanılan tüm kaynakları temizleyin.
		/// </summary>
		///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer üretilen kod

		/// <summary>
		/// Tasarımcı desteği için gerekli metot - bu metodun 
		///içeriğini kod düzenleyici ile değiştirmeyin.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.grd_kurgecmis = new System.Windows.Forms.DataGridView();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label12 = new System.Windows.Forms.Label();
			this.lbl_sterlin_alis = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.lbl_sterlin_satis = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label8 = new System.Windows.Forms.Label();
			this.lbl_euro_alis = new System.Windows.Forms.Label();
			this.lbl_euro_satis = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lbl_dolar_satis = new System.Windows.Forms.Label();
			this.lbl_dolar_alis = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grd_kurgecmis)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.grd_kurgecmis);
			this.groupBox4.Location = new System.Drawing.Point(218, 12);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(601, 312);
			this.groupBox4.TabIndex = 6;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Kur Geçmişi";
			// 
			// grd_kurgecmis
			// 
			this.grd_kurgecmis.AllowUserToAddRows = false;
			this.grd_kurgecmis.AllowUserToDeleteRows = false;
			this.grd_kurgecmis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grd_kurgecmis.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grd_kurgecmis.Location = new System.Drawing.Point(3, 16);
			this.grd_kurgecmis.Name = "grd_kurgecmis";
			this.grd_kurgecmis.ReadOnly = true;
			this.grd_kurgecmis.Size = new System.Drawing.Size(595, 293);
			this.grd_kurgecmis.TabIndex = 0;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.label12);
			this.groupBox3.Controls.Add(this.lbl_sterlin_alis);
			this.groupBox3.Controls.Add(this.label9);
			this.groupBox3.Controls.Add(this.lbl_sterlin_satis);
			this.groupBox3.Location = new System.Drawing.Point(12, 224);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(200, 100);
			this.groupBox3.TabIndex = 3;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Sterlin ";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(15, 63);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(38, 13);
			this.label12.TabIndex = 0;
			this.label12.Text = "SATIŞ";
			// 
			// lbl_sterlin_alis
			// 
			this.lbl_sterlin_alis.AutoSize = true;
			this.lbl_sterlin_alis.Location = new System.Drawing.Point(72, 32);
			this.lbl_sterlin_alis.Name = "lbl_sterlin_alis";
			this.lbl_sterlin_alis.Size = new System.Drawing.Size(28, 13);
			this.lbl_sterlin_alis.TabIndex = 0;
			this.lbl_sterlin_alis.Text = "12,2";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(15, 32);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(30, 13);
			this.label9.TabIndex = 0;
			this.label9.Text = "ALIŞ";
			// 
			// lbl_sterlin_satis
			// 
			this.lbl_sterlin_satis.AutoSize = true;
			this.lbl_sterlin_satis.Location = new System.Drawing.Point(72, 63);
			this.lbl_sterlin_satis.Name = "lbl_sterlin_satis";
			this.lbl_sterlin_satis.Size = new System.Drawing.Size(28, 13);
			this.lbl_sterlin_satis.TabIndex = 0;
			this.lbl_sterlin_satis.Text = "12,2";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.lbl_euro_alis);
			this.groupBox2.Controls.Add(this.lbl_euro_satis);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Location = new System.Drawing.Point(12, 118);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(200, 100);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "EURO $";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(15, 62);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(38, 13);
			this.label8.TabIndex = 0;
			this.label8.Text = "SATIŞ";
			// 
			// lbl_euro_alis
			// 
			this.lbl_euro_alis.AutoSize = true;
			this.lbl_euro_alis.Location = new System.Drawing.Point(72, 31);
			this.lbl_euro_alis.Name = "lbl_euro_alis";
			this.lbl_euro_alis.Size = new System.Drawing.Size(28, 13);
			this.lbl_euro_alis.TabIndex = 0;
			this.lbl_euro_alis.Text = "12,2";
			// 
			// lbl_euro_satis
			// 
			this.lbl_euro_satis.AutoSize = true;
			this.lbl_euro_satis.Location = new System.Drawing.Point(72, 62);
			this.lbl_euro_satis.Name = "lbl_euro_satis";
			this.lbl_euro_satis.Size = new System.Drawing.Size(28, 13);
			this.lbl_euro_satis.TabIndex = 0;
			this.lbl_euro_satis.Text = "12,2";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(15, 31);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(30, 13);
			this.label5.TabIndex = 0;
			this.label5.Text = "ALIŞ";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.lbl_dolar_satis);
			this.groupBox1.Controls.Add(this.lbl_dolar_alis);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 100);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Dolar $";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(15, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "SATIŞ";
			// 
			// lbl_dolar_satis
			// 
			this.lbl_dolar_satis.AutoSize = true;
			this.lbl_dolar_satis.Location = new System.Drawing.Point(72, 60);
			this.lbl_dolar_satis.Name = "lbl_dolar_satis";
			this.lbl_dolar_satis.Size = new System.Drawing.Size(28, 13);
			this.lbl_dolar_satis.TabIndex = 0;
			this.lbl_dolar_satis.Text = "12,2";
			// 
			// lbl_dolar_alis
			// 
			this.lbl_dolar_alis.AutoSize = true;
			this.lbl_dolar_alis.Location = new System.Drawing.Point(72, 29);
			this.lbl_dolar_alis.Name = "lbl_dolar_alis";
			this.lbl_dolar_alis.Size = new System.Drawing.Size(28, 13);
			this.lbl_dolar_alis.TabIndex = 0;
			this.lbl_dolar_alis.Text = "12,2";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(15, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(30, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "ALIŞ";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(830, 338);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "Exchange Rate Tracker";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grd_kurgecmis)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.DataGridView grd_kurgecmis;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label lbl_sterlin_alis;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label lbl_sterlin_satis;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label lbl_euro_alis;
		private System.Windows.Forms.Label lbl_euro_satis;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lbl_dolar_satis;
		private System.Windows.Forms.Label lbl_dolar_alis;
		private System.Windows.Forms.Label label1;
	}
}

