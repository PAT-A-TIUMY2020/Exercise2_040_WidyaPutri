
namespace ClientRestB_040
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxNIM = new System.Windows.Forms.TextBox();
			this.textBoxNama = new System.Windows.Forms.TextBox();
			this.textBoxProdi = new System.Windows.Forms.TextBox();
			this.textBoxAngkatan = new System.Windows.Forms.TextBox();
			this.buttonUpdate = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonClear = new System.Windows.Forms.Button();
			this.btnTotal = new System.Windows.Forms.Button();
			this.btnData = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(71, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "NIM";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(71, 100);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nama";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(71, 152);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Prodi";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(71, 206);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(78, 20);
			this.label4.TabIndex = 3;
			this.label4.Text = "Angkatan";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(190, 273);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(104, 20);
			this.label5.TabIndex = 4;
			this.label5.Text = "DataJumblah";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(413, 276);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(164, 20);
			this.label6.TabIndex = 5;
			this.label6.Text = "Pemberitahuan server";
			// 
			// textBoxNIM
			// 
			this.textBoxNIM.Location = new System.Drawing.Point(231, 44);
			this.textBoxNIM.Name = "textBoxNIM";
			this.textBoxNIM.Size = new System.Drawing.Size(213, 26);
			this.textBoxNIM.TabIndex = 6;
			this.textBoxNIM.TextChanged += new System.EventHandler(this.textBoxNIM_TextChanged);
			// 
			// textBoxNama
			// 
			this.textBoxNama.Location = new System.Drawing.Point(231, 97);
			this.textBoxNama.Name = "textBoxNama";
			this.textBoxNama.Size = new System.Drawing.Size(213, 26);
			this.textBoxNama.TabIndex = 7;
			this.textBoxNama.TextChanged += new System.EventHandler(this.textBoxNama_TextChanged);
			// 
			// textBoxProdi
			// 
			this.textBoxProdi.Location = new System.Drawing.Point(231, 152);
			this.textBoxProdi.Name = "textBoxProdi";
			this.textBoxProdi.Size = new System.Drawing.Size(213, 26);
			this.textBoxProdi.TabIndex = 8;
			this.textBoxProdi.TextChanged += new System.EventHandler(this.textBoxProdi_TextChanged);
			// 
			// textBoxAngkatan
			// 
			this.textBoxAngkatan.Location = new System.Drawing.Point(231, 206);
			this.textBoxAngkatan.Name = "textBoxAngkatan";
			this.textBoxAngkatan.Size = new System.Drawing.Size(213, 26);
			this.textBoxAngkatan.TabIndex = 9;
			this.textBoxAngkatan.TextChanged += new System.EventHandler(this.textBoxAngkatan_TextChanged);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(475, 46);
			this.buttonUpdate.Name = "buttonUpdate";
			this.buttonUpdate.Size = new System.Drawing.Size(75, 34);
			this.buttonUpdate.TabIndex = 10;
			this.buttonUpdate.Text = "Update";
			this.buttonUpdate.UseVisualStyleBackColor = true;
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// buttonDelete
			// 
			this.buttonDelete.Location = new System.Drawing.Point(475, 113);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(75, 32);
			this.buttonDelete.TabIndex = 11;
			this.buttonDelete.Text = "Delete";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// buttonClear
			// 
			this.buttonClear.Location = new System.Drawing.Point(475, 176);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(75, 29);
			this.buttonClear.TabIndex = 12;
			this.buttonClear.Text = "Clear";
			this.buttonClear.UseVisualStyleBackColor = true;
			this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
			// 
			// btnTotal
			// 
			this.btnTotal.Location = new System.Drawing.Point(75, 270);
			this.btnTotal.Name = "btnTotal";
			this.btnTotal.Size = new System.Drawing.Size(75, 26);
			this.btnTotal.TabIndex = 13;
			this.btnTotal.Text = "Total Data";
			this.btnTotal.UseVisualStyleBackColor = true;
			this.btnTotal.Click += new System.EventHandler(this.button4_Click);
			// 
			// btnData
			// 
			this.btnData.Location = new System.Drawing.Point(417, 246);
			this.btnData.Name = "btnData";
			this.btnData.Size = new System.Drawing.Size(133, 27);
			this.btnData.TabIndex = 14;
			this.btnData.Text = "Tampilkan Data";
			this.btnData.UseVisualStyleBackColor = true;
			this.btnData.Click += new System.EventHandler(this.btnData_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(92, 333);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 62;
			this.dataGridView1.RowTemplate.Height = 28;
			this.dataGridView1.Size = new System.Drawing.Size(570, 150);
			this.dataGridView1.TabIndex = 15;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 503);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnData);
			this.Controls.Add(this.btnTotal);
			this.Controls.Add(this.buttonClear);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonUpdate);
			this.Controls.Add(this.textBoxAngkatan);
			this.Controls.Add(this.textBoxProdi);
			this.Controls.Add(this.textBoxNama);
			this.Controls.Add(this.textBoxNIM);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBoxNIM;
		private System.Windows.Forms.TextBox textBoxNama;
		private System.Windows.Forms.TextBox textBoxProdi;
		private System.Windows.Forms.TextBox textBoxAngkatan;
		private System.Windows.Forms.Button buttonUpdate;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Button buttonClear;
		private System.Windows.Forms.Button btnTotal;
		private System.Windows.Forms.Button btnData;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}

