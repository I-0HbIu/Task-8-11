namespace L11
{
    partial class Task1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            trackBar1 = new TrackBar();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(29, 9);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(87, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 2;
            label1.Text = "n:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 110);
            label2.Name = "label2";
            label2.Size = new Size(127, 15);
            label2.TabIndex = 3;
            label2.Text = "1^2+3^n+...+(2n-1)^2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(223, 110);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 4;
            label3.Text = "n(4n^2-1)/3";
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(29, 128);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(87, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(207, 128);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(87, 23);
            textBox3.TabIndex = 6;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(6, 50);
            trackBar1.Maximum = 100;
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(173, 45);
            trackBar1.TabIndex = 7;
            trackBar1.Value = 1;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // button1
            // 
            button1.Location = new Point(207, 4);
            button1.Name = "button1";
            button1.Size = new Size(87, 23);
            button1.TabIndex = 8;
            button1.Text = "Закрыть";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Task1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 163);
            Controls.Add(button1);
            Controls.Add(trackBar1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Task1";
            Text = "Задание 1";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox3;
        private TrackBar trackBar1;
        private Button button1;
    }
}