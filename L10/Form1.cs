namespace L10
{
    public partial class Title : Form
    {
        public Title()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task1 task1 = new Task1();
            task1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Task2 task2 = new Task2();
            task2.Show();
        }
    }
}