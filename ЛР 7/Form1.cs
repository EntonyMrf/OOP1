using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛР_7
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			label1.Text = "Исходный массив: ";
			label2.Text = "Полученный массив: ";
			button1.Text = "Заполнить";
			button2.Text = "Заменить";
		}

		// Глобальная переменная видна всем методам
		int[] Mas = new int[15];
		int a, minIndex;

		private void button1_Click(object sender, EventArgs e)
		{
			// Очищаем элемент управления
			listBox1.Items.Clear();
			// Инициализируем класс случайных чисел
			Random rand = new Random();
			// Генерируем и выводим 15 элементов
			for (int i = 0; i < 15; i++)
			{
				Mas[i] = rand.Next(-50, 50);
			listBox1.Items.Add("Mas[" + i.ToString() +
			"] = " + Mas[i].ToString());
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			int minElement = 100;
			// Очищаем элемент управления
			listBox2.Items.Clear();
			// Обрабатываем все элементы
			for (int i = 0; i < 15; i++)
			{
				if (Mas[i] < minElement)
				{
					minElement = Mas[i];
					minIndex = i;
				}
			}
			a = Mas[13];
			Mas[13] = Mas[minIndex];
			Mas[minIndex] = a;

			for (int i = 0; i < 15; i++)
			{
				listBox2.Items.Add("Mas[" + Convert.ToString(i)
				+ "] = " + Mas[i].ToString());
			}
		}
	}
}
