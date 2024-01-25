using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛР_8
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			button1.Text = "ПУСК";
			label1.Text = "Сумма второй строки: ";
			label2.Text = "Произведение первого стобца: ";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			dataGridView1.RowCount = 3; // Кол‐во строк
			dataGridView1.ColumnCount = 3; // Кол‐во столбцов
			int[,] a = new int[3, 3]; // Инициализируем массив
			int i, j;
			//Заполняем матрицу случайными числами
			Random rand = new Random();
			for (i = 0; i < 3; i++)
				for (j = 0; j < 3; j++)
					a[i, j] = rand.Next(-100, 100);
			// Выводим матрицу в dataGridView1
			for (i = 0; i < 3; i++)
				for (j = 0; j < 3; j++)
					dataGridView1.Rows[i].Cells[j].Value =
					a[i, j].ToString();
			int sum = 0;
			int pr = 1;
			for (j = 0; j < 3; j++)
				sum = sum + a[1, j];
			for (i = 0; i < 3; i++)
				pr = pr * a[i, 0];
			textBox1.Text = Convert.ToString(sum);
			textBox2.Text = Convert.ToString(pr);
		}
	}
}