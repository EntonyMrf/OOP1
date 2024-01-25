using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ЛР_4
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			label1.Text = "X0";
			label2.Text = "Xk";
			label3.Text = "Dx";
			label4.Text = "a";
			label5.Text = "b";
			textBox1.Text = "-0,75";
			textBox2.Text = "-1,5";
			textBox3.Text = "-0,05";
			textBox4.Text = "1,5";
			textBox5.Text = "1,2";
			button1.Text = "Вычислить";
			button2.Text = "Очистить";
		}

		private async void button1_Click(object sender, EventArgs e)
		{
			double x0, xk, dx, a, b;
			if (!double.TryParse(textBox1.Text, out x0) || !double.TryParse(textBox2.Text, out xk) || !double.TryParse(textBox3.Text, out dx) ||
				!double.TryParse(textBox4.Text, out a) || !double.TryParse(textBox5.Text, out b))
			{
				MessageBox.Show("Некорректный ввод данных!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (x0 > double.MaxValue || x0 < double.MinValue || xk > double.MaxValue || xk < double.MinValue || dx > double.MaxValue
				|| a > double.MaxValue || a < double.MinValue || b > double.MaxValue || b < double.MinValue)
			{
				MessageBox.Show("Некорректный ввод данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (((x0>0) & (dx<=0)) || ((x0<0) & (dx>=0)))
			{
				MessageBox.Show("Некорректный ввод данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			textBox6.Text += "Лаб. работа #4 АСУ-22-1б Гимадеев Р., Базуев Д." + Environment.NewLine;
			x0 = Convert.ToDouble(textBox1.Text);
			xk = Convert.ToDouble(textBox2.Text);
			dx = Convert.ToDouble(textBox3.Text);
			a = Convert.ToDouble(textBox4.Text);
			b = Convert.ToDouble(textBox5.Text);
			double x = x0;
			while (Math.Abs(x) <= ((Math.Abs(xk) + Math.Abs(dx) / 2)))
			{
				double y = 1.2 * Math.Pow((a - b), 3) * Math.Exp(x * x) + x;
				textBox6.Text += Environment.NewLine + "При X = " + x;
				textBox6.Text += "    Y = " + y;
				x = x + dx;
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();
			textBox4.Clear();
			textBox5.Clear();
			textBox6.Clear();
		}
	}
}