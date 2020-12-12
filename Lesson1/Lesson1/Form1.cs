using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson1
{
    public partial class Form1 : Form
    {
        public Form1() //Создание формы
        {
            InitializeComponent();
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }


        private void button2_Click(object sender, EventArgs e)//Кнопка очистки 
        {
            textBox1.Clear();//Удаляет весь текст из текстбокса
        }

        private void button3_Click(object sender, EventArgs e)//Кнопка "О программе"
        {


        }

        private void button4_Click(object sender, EventArgs e)//Кнопка закрытия
        {
            Close();//Закрывает программу
        }

        private void button1_Click(object sender, EventArgs e)//Кнопка открытия
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)//
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            // читаем файл в строку
            string fileText = System.IO.File.ReadAllText(filename);
            textBox1.Text = fileText;

            MessageBox.Show("Файл открыт");

        }
    }
}
