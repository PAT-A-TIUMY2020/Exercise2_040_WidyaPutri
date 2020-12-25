
namespace ClientRestA_040
{
	partial class Form1
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
			this.t = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtNIM = new System.Windows.Forms.TextBox();
			this.textNama = new System.Windows.Forms.TextBox();
			this.txtProdi = new System.Windows.Forms.TextBox();
			this.txtAngkatan = new System.Windows.Forms.TextBox();
			this.NIMSearch = new System.Windows.Forms.TextBox();
			this.Creat = new System.Windows.Forms.Button();
			this.btClear = new System.Windows.Forms.Button();
			this.btSearch = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// t
			// 
			this.t.AutoSize = true;
			this.t.Location = new System.Drawing.Point(62, 50);
			this.t.Name = "t";
			this.t.Size = new System.Drawing.Size(38, 20);
			this.t.TabIndex = 0;
			this.t.Text = "NIM";
			this.t.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(62, 113);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nama";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(62, 177);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Prodi";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(62, 242);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(78, 20);
			this.label4.TabIndex = 3;
			this.label4.Text = "Angkatan";
			// 
			// txtNIM
			// 
			this.txtNIM.Location = new System.Drawing.Point(218, 50);
			this.txtNIM.Name = "txtNIM";
			this.txtNIM.Size = new System.Drawing.Size(275, 26);
			this.txtNIM.TabIndex = 4;
			this.txtNIM.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// textNama
			// 
			this.textNama.Location = new System.Drawing.Point(218, 106);
			this.textNama.Name = "textNama";
			this.textNama.Size = new System.Drawing.Size(275, 26);
			this.textNama.TabIndex = 5;
			// 
			// txtProdi
			// 
			this.txtProdi.Location = new System.Drawing.Point(218, 177);
			this.txtProdi.Name = "txtProdi";
			this.txtProdi.Size = new System.Drawing.Size(275, 26);
			this.txtProdi.TabIndex = 6;
			// 
			// txtAngkatan
			// 
			this.txtAngkatan.Location = new System.Drawing.Point(218, 235);
			this.txtAngkatan.Name = "txtAngkatan";
			this.txtAngkatan.Size = new System.Drawing.Size(275, 26);
			this.txtAngkatan.TabIndex = 7;
			// 
			// NIMSearch
			// 
			this.NIMSearch.Location = new System.Drawing.Point(300, 299);
			this.NIMSearch.Name = "NIMSearch";
			this.NIMSearch.Size = new System.Drawing.Size(245, 26);
			this.NIMSearch.TabIndex = 8;
			// 
			// Creat
			// 
			this.Creat.Location = new System.Drawing.Point(557, 53);
			this.Creat.Name = "Creat";
			this.Creat.Size = new System.Drawing.Size(75, 35);
			this.Creat.TabIndex = 9;
			this.Creat.Text = "Create";
			this.Creat.UseVisualStyleBackColor = true;
			this.Creat.Click += new System.EventHandler(this.Creat_Click);
			// 
			// btClear
			// 
			this.btClear.Location = new System.Drawing.Point(557, 113);
			this.btClear.Name = "btClear";
			this.btClear.Size = new System.Drawing.Size(75, 34);
			this.btClear.TabIndex = 10;
			this.btClear.Text = "Clear";
			this.btClear.UseVisualStyleBackColor = true;
			this.btClear.Click += new System.EventHandler(this.btClear_Click);
			// 
			// btSearch
			// 
			this.btSearch.Location = new System.Drawing.Point(91, 301);
			this.btSearch.Name = "btSearch";
			this.btSearch.Size = new System.Drawing.Size(126, 35);
			this.btSearch.TabIndex = 11;
			this.btSearch.Text = "Search by NIM";
			this.btSearch.UseVisualStyleBackColor = true;
			this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(127, 353);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 62;
			this.dataGridView1.RowTemplate.Height = 28;
			this.dataGridView1.Size = new System.Drawing.Size(550, 150);
			this.dataGridView1.TabIndex = 12;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 542);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btSearch);
			this.Controls.Add(this.btClear);
			this.Controls.Add(this.Creat);
			this.Controls.Add(this.NIMSearch);
			this.Controls.Add(this.txtAngkatan);
			this.Controls.Add(this.txtProdi);
			this.Controls.Add(this.textNama);
			this.Controls.Add(this.txtNIM);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.t);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label t;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtNIM;
		private System.Windows.Forms.TextBox textNama;
		private System.Windows.Forms.TextBox txtProdi;
		private System.Windows.Forms.TextBox txtAngkatan;
		private System.Windows.Forms.TextBox NIMSearch;
		private System.Windows.Forms.Button Creat;
		private System.Windows.Forms.Button btClear;
		private System.Windows.Forms.Button btSearch;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}

