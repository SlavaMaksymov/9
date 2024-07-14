namespace _9
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button2 = new Button();
            textBox3 = new TextBox();
            label6 = new Label();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(170, 127);
            button1.Name = "button1";
            button1.Size = new Size(86, 23);
            button1.TabIndex = 0;
            button1.Text = "Зберегти";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(170, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(525, 23);
            textBox1.TabIndex = 1;
            textBox1.Text = "../../../files/file.txt";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(170, 83);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(525, 23);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 56);
            label1.Name = "label1";
            label1.Size = new Size(125, 15);
            label1.TabIndex = 3;
            label1.Text = "Шлях та назва файлу:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 81);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 4;
            label2.Text = "Текст файлу:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(197, 18);
            label3.Name = "label3";
            label3.Size = new Size(224, 15);
            label3.TabIndex = 5;
            label3.Text = "Створити файл з текстом можна нище ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(197, 189);
            label4.Name = "label4";
            label4.Size = new Size(312, 15);
            label4.TabIndex = 6;
            label4.Text = "Також можна прочитати файл у нашому додатку нище";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 222);
            label5.Name = "label5";
            label5.Size = new Size(94, 15);
            label5.TabIndex = 7;
            label5.Text = "Шлях до файла:";
            // 
            // button2
            // 
            button2.Location = new Point(170, 287);
            button2.Name = "button2";
            button2.Size = new Size(86, 23);
            button2.TabIndex = 8;
            button2.Text = "Завантажити";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(170, 214);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(525, 23);
            textBox3.TabIndex = 9;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 251);
            label6.Name = "label6";
            label6.Size = new Size(85, 15);
            label6.TabIndex = 10;
            label6.Text = "Текст з файлу:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(170, 243);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(525, 23);
            textBox4.TabIndex = 11;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Task";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button2;
        private TextBox textBox3;
        private Label label6;
        private TextBox textBox4;
    }
}