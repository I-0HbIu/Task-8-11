using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L10
{
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = "+";
        }

        private void Task2_Load(object sender, EventArgs e)
        {
            label2.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "-";
        }
    }
}
