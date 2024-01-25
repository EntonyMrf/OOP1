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

namespace ЛР_3
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			label1.Text = "Введите x: ";
			label2.Text = "Введите y: ";
			label3.Text = "Результат работы программы";
			button1.Text = "Выполнить";
			button2.Text = "Очистить";
			radioButton1.Text = "sh(x)";
			radioButton2.Text = "x^2";
			radioButton3.Text = "exp(x)";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			double b = 0.0;
			double x, y;
			if (!double.TryParse(textBox1.Text, out x)|| !double.TryParse(textBox2.Text, out y))
			{
				MessageBox.Show("Некорректный ввод данных!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			textBox3.Text += "Лаб. работа #3 АСУ-22-1б Гимадеев Р., Базуев Д.";
			x = double.Parse(textBox1.Text);
			textBox3.Text += Environment.NewLine + "X = " + x.ToString();
			y = double.Parse(textBox2.Text);
			textBox3.Text += Environment.NewLine + "Y = " + y.ToString();
				if (radioButton1.Checked)
				{
					MessageBox.Show("Выбрана функция: гиперболический синус");
					if (x / y > 0)
					{
						b = Math.Log10(Math.Sinh(x)) + Math.Pow(Math.Pow(Math.Sinh(x), 2) + y, 3);
					}
					if (x / y < 0)
					{
						b = Math.Log10(Math.Abs(Math.Sinh(x) / y)) + Math.Pow(Math.Sinh(x) + y, 3);
					}
					if (x == 0)
					{
						b = Math.Pow(Math.Pow(Math.Sinh(x), 2) + y, 3);
					}
					if (y == 0)
					{
						b = 0;
					}
				}
				else if (radioButton2.Checked)
				{
					MessageBox.Show("Выбрана функция: икс в квадрате");
					if (x / y > 0)
					{
						b = Math.Log10(x * x) + Math.Pow(Math.Pow(x, 4) + y, 3);
					}
					if (x / y < 0)
					{
						b = Math.Log10(Math.Abs(x * x / y)) + Math.Pow(x * x + y, 3);
					}
					if (x == 0)
					{
						b = Math.Pow(Math.Pow(x, 4) + y, 3);
					}
					if (y == 0)
					{
						b = 0;
					}
				}
				else if (radioButton3.Checked)
				{
					MessageBox.Show("Выбрана функция: экспонента");
					if (x / y > 0)
					{
						b = Math.Log10(Math.Exp(x)) + Math.Pow(Math.Pow(Math.Exp(x), 2) + y, 3);
					}
					if (x / y < 0)
					{
						b = Math.Log10(Math.Abs(Math.Exp(x) / y)) + Math.Pow(Math.Exp(x) + y, 3);
					}
					if (x == 0)
					{
						b = Math.Pow(Math.Pow(Math.Exp(x), 2) + y, 3);
					}
					if (y == 0)
					{
						b = 0;
					}
				}
				textBox3.Text += Environment.NewLine + Environment.NewLine + "Результат b = " + b;
			}
		private void button2_Click_1(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();
		}
	}
}