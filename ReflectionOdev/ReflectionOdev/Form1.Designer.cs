namespace ReflectionOdev
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
            txtKlasorYolu = new TextBox();
            btnTara = new Button();
            listBox1 = new ListBox();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtKlasorYolu
            // 
            txtKlasorYolu.Location = new Point(102, 49);
            txtKlasorYolu.Name = "txtKlasorYolu";
            txtKlasorYolu.Size = new Size(125, 27);
            txtKlasorYolu.TabIndex = 0;
            // 
            // btnTara
            // 
            btnTara.Location = new Point(114, 82);
            btnTara.Name = "btnTara";
            btnTara.Size = new Size(94, 29);
            btnTara.TabIndex = 1;
            btnTara.Text = "Tara";
            btnTara.UseVisualStyleBackColor = true;
            btnTara.Click += btnTara_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(233, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 184);
            listBox1.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(581, 71);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(607, 116);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(552, 167);
            button1.Name = "button1";
            button1.Size = new Size(180, 29);
            button1.TabIndex = 5;
            button1.Text = "Ödeme İşlemini Başlat";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(442, 74);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 6;
            label1.Text = "Ödeme Yöntemleri";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(552, 119);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 7;
            label2.Text = "Tutar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 52);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 8;
            label3.Text = "Hangi Klasör";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(listBox1);
            Controls.Add(btnTara);
            Controls.Add(txtKlasorYolu);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtKlasorYolu;
        private Button btnTara;
        private ListBox listBox1;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
