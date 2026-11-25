namespace WinFormsApp2
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
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            listBox1 = new ListBox();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20F);
            button1.Location = new Point(290, 154);
            button1.Name = "button1";
            button1.Size = new Size(195, 57);
            button1.TabIndex = 0;
            button1.Text = "Llogarit Mesataren";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            button1.MouseClick += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 20F);
            textBox1.Location = new Point(104, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 52);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 20F);
            textBox2.Location = new Point(325, 62);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 52);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 20F);
            textBox3.Location = new Point(563, 62);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 52);
            textBox3.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(89, 4);
            label1.Name = "label1";
            label1.Size = new Size(140, 46);
            label1.TabIndex = 4;
            label1.Text = "Numri 1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(310, 4);
            label2.Name = "label2";
            label2.Size = new Size(140, 46);
            label2.TabIndex = 5;
            label2.Text = "Numri 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(548, 4);
            label3.Name = "label3";
            label3.Size = new Size(140, 46);
            label3.TabIndex = 6;
            label3.Text = "Numri 3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 40F);
            label4.Location = new Point(250, 291);
            label4.Name = "label4";
            label4.Size = new Size(325, 89);
            label4.TabIndex = 7;
            label4.Text = "Mesatarja";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(89, 425);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(155, 244);
            listBox1.TabIndex = 8;
            listBox1.Click += listBox1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label5.Location = new Point(698, 465);
            label5.Name = "label5";
            label5.Size = new Size(177, 46);
            label5.TabIndex = 9;
            label5.Text = "Mesatarja";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label6.Location = new Point(719, 539);
            label6.Name = "label6";
            label6.Size = new Size(0, 46);
            label6.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 777);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(listBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "TBU";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ListBox listBox1;
        private Label label5;
        private Label label6;
    }
}
