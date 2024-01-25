using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ЛР_6
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			button1.Text = "Выполнить";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int index = listBox1.SelectedIndex;
			if (index == -1)
			{
				MessageBox.Show("Выделите нужную строку!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			// Считываем строку в переменную str
			string str = (string)listBox1.Items[index];
			// Узнаем количество символов в строке
			int len = str.Length;
			// Считаем, что количество пробелов равно 0
			int count = 0;
			// Устанавливаем счетчик символов в 0
			int i = 0;
			// Организуем цикл перебора всех символов в строке
			while (i < len)
			{
				if (str[i] == ' ')
				{
					if ((str[i + 1] != '-') & (str[i + 1] != ' ')) count++;
				}	
				i++;
			}
			count++;
			label1.Text = "Количество слов = " +
			count.ToString();
		}
	}
}
