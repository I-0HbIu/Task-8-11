namespace L10
{
    partial class Task2
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
            button1 = new Button();
            button3 = new Button();
            button2 = new Button();
            button4 = new Button();
            button5 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(235, 129);
            button1.Name = "button1";
            button1.Size = new Size(131, 60);
            button1.TabIndex = 1;
            button1.Text = "Закрыть";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(104, 12);
            button3.Name = "button3";
            button3.Size = new Size(90, 90);
            button3.TabIndex = 3;
            button3.Text = "1 черверть";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(17, 12);
            button2.Name = "button2";
            button2.Size = new Size(90, 90);
            button2.TabIndex = 4;
            button2.Text = "2 черверть";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Location = new Point(17, 99);
            button4.Name = "button4";
            button4.Size = new Size(90, 90);
            button4.TabIndex = 5;
            button4.Text = "3 черверть";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button2_Click;
            // 
            // button5
            // 
            button5.Location = new Point(104, 99);
            button5.Name = "button5";
            button5.Size = new Size(90, 90);
            button5.TabIndex = 6;
            button5.Text = "4 черверть";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(232, 9);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 7;
            label1.Text = "Знак косинуса:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(328, 9);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 8;
            label2.Text = "ЗНАК";
            // 
            // Task2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 201);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Task2";
            Text = "Задание 2";
            Load += Task2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button3;
        private Button button2;
        private Button button4;
        private Button button5;
        private Label label1;
        private Label label2;
    }
}