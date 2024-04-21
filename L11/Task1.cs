using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L11
{
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
            textBox1.Text = trackBar1.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = trackBar1.Value;
            textBox3.Text = Convert.ToString(n * (4 * n * n - 1) / 3);
            n = 2 * n - 1;
            textBox2.Text = Convert.ToString(SumSqr(n));
        }
        public static int SumSqr(int n)
        {
            if (n == 1)
                return 1;
            return Convert.ToInt32(Math.Pow(n, 2)) + SumSqr(n - 2);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox1.Text = trackBar1.Value.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
