namespace L10
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
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label5 = new Label();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.ImeMode = ImeMode.NoControl;
            textBox1.Location = new Point(81, 6);
            textBox1.MaxLength = 10;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(115, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "1";
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 1;
            label1.Text = "Длина, м";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Enabled = false;
            label2.Location = new Point(12, 38);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 2;
            label2.Text = "Ширина, м";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(81, 35);
            textBox2.MaxLength = 10;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(115, 23);
            textBox2.TabIndex = 3;
            textBox2.Text = "1";
            textBox2.KeyPress += textBox1_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Enabled = false;
            label3.Location = new Point(12, 67);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 4;
            label3.Text = "Высота, м";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(81, 64);
            textBox3.MaxLength = 10;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(115, 23);
            textBox3.TabIndex = 5;
            textBox3.Text = "1";
            textBox3.KeyPress += textBox1_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 96);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 6;
            label4.Text = "% О2 ";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(81, 93);
            textBox4.MaxLength = 3;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(115, 23);
            textBox4.TabIndex = 7;
            textBox4.Text = "21";
            textBox4.KeyPress += textBox1_KeyPress;
            // 
            // button1
            // 
            button1.Location = new Point(12, 122);
            button1.Name = "button1";
            button1.Size = new Size(89, 23);
            button1.TabIndex = 8;
            button1.Text = "Вычислить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(107, 122);
            button2.Name = "button2";
            button2.Size = new Size(89, 23);
            button2.TabIndex = 9;
            button2.Text = "Закрыть";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(225, 9);
            label5.Name = "label5";
            label5.Size = new Size(124, 15);
            label5.TabIndex = 10;
            label5.Text = "Объём О2 в комнате:";
            // 
            // textBox5
            // 
            textBox5.Enabled = false;
            textBox5.Location = new Point(225, 27);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(115, 23);
            textBox5.TabIndex = 11;
            // 
            // Task1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 156);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Task1";
            Text = "Задание 1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
        private Label label5;
        private TextBox textBox5;
    }
}