using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKhoHang
{
	public partial class Help : Form
	{
		public Help()
		{
			InitializeComponent();
		}

		
		private void Help_Load(object sender, EventArgs e)
		{
			linkLabel1.Text = "Click here";
			linkLabel1.Links.Add(6, 4, "https://www.facebook.com/truong95.it");
			linkLabel2.Text = "Click here";
			linkLabel2.Links.Add(6, 4, "https://twitter.com/nqo_truonq");
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
			new Form1().Show();
		}

		private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
		}
	}
}
