using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileWorks
{
    public partial class Form1 : Form
    {
        public string fN = "File.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!File.Exists(fN))
            {
                File.Create(fN).Close();
                MessageBox.Show("Файл создан", "Создан", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Файл уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (File.Exists(fN))
            {
                File.Delete(fN);
                MessageBox.Show("Файл удален", "Удален", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Файл не существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (File.Exists(fN))
            {
                textBox1.Text = null;
                //          File.WriteAllText(fN, textBox1.Text);
                using (StreamReader reader = File.OpenText(fN))
                {
                    textBox1.Text = reader.ReadToEnd();
                }
            }
            else
            {
                MessageBox.Show("Файл не существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
        if (File.Exists(fN)) 
            {
                string[] lines = {textBox1.Text};
                System.IO.File.WriteAllLines(fN, lines);
                MessageBox.Show("Текст записан", "Запись", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            } 
        else
            {
                File.Create(fN).Close();
                    string[] lines = { textBox1.Text };
                    System.IO.File.WriteAllLines(fN, lines);
                MessageBox.Show("Файл создан и текст записан", "Запись", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выйти?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                this.Close();
            }
            else
            {
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
