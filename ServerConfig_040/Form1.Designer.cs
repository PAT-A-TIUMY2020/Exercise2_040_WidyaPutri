
namespace ServerConfig_040
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
			this.ON = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.buttonON = new System.Windows.Forms.Button();
			this.buttonOFF = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ON
			// 
			this.ON.AutoSize = true;
			this.ON.Location = new System.Drawing.Point(197, 147);
			this.ON.Name = "ON";
			this.ON.Size = new System.Drawing.Size(51, 20);
			this.ON.TabIndex = 0;
			this.ON.Text = "label1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(467, 147);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "OFF";
			// 
			// buttonON
			// 
			this.buttonON.Location = new System.Drawing.Point(187, 242);
			this.buttonON.Name = "buttonON";
			this.buttonON.Size = new System.Drawing.Size(75, 31);
			this.buttonON.TabIndex = 2;
			this.buttonON.Text = "ON";
			this.buttonON.UseVisualStyleBackColor = true;
			this.buttonON.Click += new System.EventHandler(this.buttonON_Click);
			// 
			// buttonOFF
			// 
			this.buttonOFF.Location = new System.Drawing.Point(455, 241);
			this.buttonOFF.Name = "buttonOFF";
			this.buttonOFF.Size = new System.Drawing.Size(75, 32);
			this.buttonOFF.TabIndex = 3;
			this.buttonOFF.Text = "OFF";
			this.buttonOFF.UseVisualStyleBackColor = true;
			this.buttonOFF.Click += new System.EventHandler(this.buttonOFF_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.buttonOFF);
			this.Controls.Add(this.buttonON);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.ON);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label ON;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonON;
		private System.Windows.Forms.Button buttonOFF;
	}
}

