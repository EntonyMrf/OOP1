using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ЛР_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Введите x";
            label2.Text = "Введите y";
            label3.Text = "Введите z";
            label4.Text = "Результат работы программы";
            textBox1.Text = "-4,5";
            textBox2.Text = "0,000075";
            textBox3.Text = "84,5";
            button1.Text = "Выполнить";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Text += "Лаб. работа #2 АСУ-22-1б Гимадеев Р., Базуев Д.";
            double x = double.Parse(textBox1.Text);
            textBox4.Text += Environment.NewLine + "X = " + x.ToString();
            double y = double.Parse(textBox2.Text);
            textBox4.Text += Environment.NewLine + "Y = " + y.ToString();
            double z = double.Parse(textBox3.Text);
            textBox4.Text += Environment.NewLine + "Z = " + z.ToString();
            double u = (Math.Pow((8 + Math.Pow(Math.Abs(x - y), 2) + 1), 1 / 3) / (x * x + y * y + 2) - Math.Exp(Math.Abs(x - y)) * Math.Pow(Math.Pow(Math.Tan(z), 2) + 1, x));
            textBox4.Text += Environment.NewLine + Environment.NewLine + "Результат U = " + u.ToString();
        }
    }
}