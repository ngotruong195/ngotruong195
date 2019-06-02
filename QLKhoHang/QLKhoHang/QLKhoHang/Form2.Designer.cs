namespace QLKhoHang
{
	partial class Help
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
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnExit = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.linkLabel2 = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Location = new System.Drawing.Point(134, 56);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(53, 13);
			this.linkLabel1.TabIndex = 0;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "ClickHere";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(47, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(256, 26);
			this.label1.TabIndex = 1;
			this.label1.Text = "*Mọi thắc mắc về phần mềm xin liên hệ số điện thoại\r\n0123456789.\r\n";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(47, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Link Facebook:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(209, 56);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(176, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Email: Nqoquanqtruonq@gmail.com";
			// 
			// btnExit
			// 
			this.btnExit.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnExit.Location = new System.Drawing.Point(227, 78);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(85, 23);
			this.btnExit.TabIndex = 4;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(47, 83);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(65, 13);
			this.label4.TabIndex = 5;
			this.label4.Text = "Link Twitter:";
			// 
			// linkLabel2
			// 
			this.linkLabel2.AutoSize = true;
			this.linkLabel2.Location = new System.Drawing.Point(134, 83);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new System.Drawing.Size(53, 13);
			this.linkLabel2.TabIndex = 6;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = "ClickHere";
			this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
			// 
			// Help
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(391, 105);
			this.Controls.Add(this.linkLabel2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.linkLabel1);
			this.Name = "Help";
			this.Text = "Trợ Giúp";
			this.Load += new System.EventHandler(this.Help_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.LinkLabel linkLabel2;
	}
}