namespace Umnik2
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            listBox1 = new ListBox();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(222, 89);
            label1.Name = "label1";
            label1.Size = new Size(66, 46);
            label1.TabIndex = 0;
            label1.Text = "L1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(393, 89);
            label2.Name = "label2";
            label2.Size = new Size(66, 46);
            label2.TabIndex = 1;
            label2.Text = "L2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(489, 159);
            label3.Name = "label3";
            label3.Size = new Size(261, 25);
            label3.TabIndex = 3;
            label3.Text = "ввести ответ и нажать <Enter>";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 4;
            label4.Text = "label4";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(541, 99);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(172, 31);
            textBox1.TabIndex = 5;
            textBox1.KeyDown += textBox1_KeyDown;
            textBox1.KeyUp += textBox1_KeyUp;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(319, 89);
            label5.Name = "label5";
            label5.Size = new Size(44, 46);
            label5.TabIndex = 6;
            label5.Text = "+";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label8.Location = new Point(480, 89);
            label8.Name = "label8";
            label8.Size = new Size(44, 46);
            label8.TabIndex = 9;
            label8.Text = "=";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(933, 106);
            label9.Name = "label9";
            label9.Size = new Size(38, 25);
            label9.TabIndex = 10;
            label9.Text = "сек";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label10.Location = new Point(891, 106);
            label10.Name = "label10";
            label10.Size = new Size(36, 25);
            label10.TabIndex = 11;
            label10.Text = "10";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(846, 68);
            label11.Name = "label11";
            label11.Size = new Size(141, 25);
            label11.TabIndex = 12;
            label11.Text = "время на ответ:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(12, 236);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(1005, 129);
            listBox1.TabIndex = 13;
            // 
            // button1
            // 
            button1.Location = new Point(843, 159);
            button1.Name = "button1";
            button1.Size = new Size(139, 48);
            button1.TabIndex = 14;
            button1.Text = "Старт";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 378);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Umnik2";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private Label label5;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private ListBox listBox1;
        private Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}
