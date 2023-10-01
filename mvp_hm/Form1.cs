using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mvp_hm
{
    public partial class Form1 : Form
    {
        FileStream fs;
        StreamReader sr;
        string CopyOfTextfile = null;

        public Form1()
        {
            InitializeComponent();

            fs = new FileStream("info.txt", FileMode.OpenOrCreate);
            sr = new StreamReader(fs);

            string text_from_file = sr.ReadToEnd();
            CopyOfTextfile = text_from_file;
            int tab = 0;
            string text = null;

            for (int i = 0; i < text_from_file.Length; i++)
            {
                text += text_from_file[i];
                if (text_from_file[i] == '\n')
                {
                    listBox1.Items.Add(text);
                    text = null;
                }
            }
            fs.Close();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string login = textBox2.Text;
            string password = textBox3.Text;

            listBox1.Items.Add($"Name: {name}\tLogin: {login}\tPassword: {password}\n");
            File.AppendAllText("info.txt", $"Name: {name}\tLogin: {login}\tPassword: {password}\n");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            catch
            {
                MessageBox.Show("Choose element!");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string text = null;

            for (int i = 0; i < CopyOfTextfile.Length; i++)
            {
                text += CopyOfTextfile[i];
                if (CopyOfTextfile[i] == '\n')
                {
                    listBox1.Items.Add(text);
                    text = null;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string find_word = textBox4.Text;
            string[] mas = new string[listBox1.Items.Count];

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                mas[i] = listBox1.Items[i].ToString();
            }
            listBox1.Items.Clear();

            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i].Contains(find_word))
                {
                    listBox1.Items.Add(mas[i]);
                }
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

    }
}
