using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			label2.Text = textBox6.Text;
		}

		private void button5_Click(object sender, EventArgs e)
		{
			label2.Text = textBox5.Text;
		}

		private void button6_Click(object sender, EventArgs e)
		{
			label2.Text = textBox4.Text;
		}
	}
}
