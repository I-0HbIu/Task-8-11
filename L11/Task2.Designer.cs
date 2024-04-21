namespace L11
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
            listBox1 = new ListBox();
            Open = new Button();
            Generate = new Button();
            Clear = new Button();
            Sort = new Button();
            Save = new Button();
            Filt = new Button();
            textBox1 = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            listBox2 = new ListBox();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(17, 8);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(425, 349);
            listBox1.TabIndex = 0;
            // 
            // Open
            // 
            Open.Location = new Point(12, 363);
            Open.Name = "Open";
            Open.Size = new Size(103, 29);
            Open.TabIndex = 1;
            Open.Text = "Открыть";
            Open.UseVisualStyleBackColor = true;
            Open.Click += Open_Click;
            // 
            // Generate
            // 
            Generate.Location = new Point(121, 363);
            Generate.Name = "Generate";
            Generate.Size = new Size(103, 29);
            Generate.TabIndex = 2;
            Generate.Text = "Сгенерировать";
            Generate.UseVisualStyleBackColor = true;
            Generate.Click += Generate_Click;
            // 
            // Clear
            // 
            Clear.Location = new Point(230, 363);
            Clear.Name = "Clear";
            Clear.Size = new Size(103, 29);
            Clear.TabIndex = 3;
            Clear.Text = "Очистить";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += Clear_Click;
            // 
            // Sort
            // 
            Sort.Location = new Point(339, 363);
            Sort.Name = "Sort";
            Sort.Size = new Size(103, 29);
            Sort.TabIndex = 4;
            Sort.Text = "Сортировать";
            Sort.UseVisualStyleBackColor = true;
            Sort.Click += Sort_Click;
            // 
            // Save
            // 
            Save.Location = new Point(448, 363);
            Save.Name = "Save";
            Save.Size = new Size(103, 29);
            Save.TabIndex = 5;
            Save.Text = "Сохранить";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // Filt
            // 
            Filt.Location = new Point(666, 363);
            Filt.Name = "Filt";
            Filt.Size = new Size(103, 29);
            Filt.TabIndex = 6;
            Filt.Text = "Фильтрация";
            Filt.UseVisualStyleBackColor = true;
            Filt.Click += Filt_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(557, 367);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(103, 23);
            textBox1.TabIndex = 7;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(448, 8);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(321, 349);
            listBox2.TabIndex = 8;
            // 
            // Task2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 395);
            Controls.Add(listBox2);
            Controls.Add(textBox1);
            Controls.Add(Filt);
            Controls.Add(Save);
            Controls.Add(Sort);
            Controls.Add(Clear);
            Controls.Add(Generate);
            Controls.Add(Open);
            Controls.Add(listBox1);
            Name = "Task2";
            Text = "Задание 2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Open;
        private Button Generate;
        private Button Clear;
        private Button Sort;
        private Button Save;
        private Button Filt;
        private TextBox textBox1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private ListBox listBox2;
        public ListBox listBox1;
    }
}