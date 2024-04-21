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

namespace L11
{
    public partial class Task2 : Form
    {
        public train[] trains = new train[10];
        public string[] trbuf = new string[10];
        public Task2()
        {

            InitializeComponent();

            openFileDialog1.Filter = "Текстовые файлы(*.txt)|*.txt|Все файлы(*.*)|*.*";
            saveFileDialog1.Filter = "Текстовые файлы(*.txt)|*.txt|Все файлы(*.*)|*.*";


        }

        private void Open_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            StreamReader rea = new StreamReader(filename);
            while (!rea.EndOfStream)
            {
                listBox1.Items.Add(rea.ReadLine());
            }
            rea.Close();
            for (int i = 0; i < 10; i++)
            {
                string bu = listBox1.Items[i].ToString();
                trains[i].Destination = bu.Remove(bu.IndexOf(";"));
                trains[i].number = Convert.ToInt32(bu.Remove(bu.LastIndexOf(";")).Substring(bu.IndexOf(" ")));
                trains[i].Stime = TimeOnly.Parse(bu.Substring(bu.LastIndexOf(" ")));
                trbuf[i] = trains[i].Destination + "; " + trains[i].number + "; " + trains[i].Stime;
            }

        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            StreamWriter writ = new StreamWriter(filename);
            for (int i = 0; i < 10; i++)
            {
                writ.WriteLine(listBox1.Items[i].ToString());
            }
            writ.Close();
            MessageBox.Show("Файл сохранен");
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            listBox1.Sorted = false;
            string[] Dest = { "Томск", "Новосибирск", "Москва", "Владивосток", "Владимир", "Анапа", "Екатеринбург", "Тольятти", "Иркутск", "Ярославль" };
            Random rnd = new Random();


            listBox1.Items.Clear();
            listBox2.Items.Clear();
            for (int i = 0; i < 10; i++)
            {
                trains[i].Destination = Dest[rnd.Next(0, 9)];
                trains[i].number = rnd.Next(10, 100);
                trains[i].Stime = new TimeOnly(rnd.Next(0, 23), rnd.Next(0, 60));
                trbuf[i] = trains[i].Destination + "; " + trains[i].number + "; " + trains[i].Stime;
                listBox1.Items.Add(trbuf[i]);
            }

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            listBox1.Sorted = false;
            listBox2.Sorted = false;
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            Array.Clear(trbuf);
            Array.Clear(trains);
        }

        private void Sort_Click(object sender, EventArgs e)
        {
            listBox1.Sorted = true;
            listBox2.Sorted = true;
        }

        private void Filt_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            bool Succ = TimeOnly.TryParse(textBox1.Text, out TimeOnly timese);
            if (Succ)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (trains[i].Stime.CompareTo(timese) > 0)
                    {
                        listBox2.Items.Add(trbuf[i]);
                    }
                }
                if (listBox2.Items.Count == 0)
                {
                    MessageBox.Show("Поезда отсутствуют");
                }
            }
            else
            {
                MessageBox.Show("Вы ввели не время");
            }
            
        }


        public struct train
        {
            public string Destination;
            public int number;
            public TimeOnly Stime;
        }
    }
}
