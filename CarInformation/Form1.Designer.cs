namespace CarInformation
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
            lblMarka = new Label();
            lblModel = new Label();
            lblRenk = new Label();
            lblKapi = new Label();
            lblPencere = new Label();
            lblYakit = new Label();
            txtMarka = new TextBox();
            txtModel = new TextBox();
            txtRenk = new TextBox();
            txtKapi = new TextBox();
            txtPencere = new TextBox();
            txtYakit = new TextBox();
            btnBilgiGoster = new Button();
            SuspendLayout();
            // 
            // lblMarka
            // 
            lblMarka.AutoSize = true;
            lblMarka.Location = new Point(177, 19);
            lblMarka.Name = "lblMarka";
            lblMarka.Size = new Size(50, 20);
            lblMarka.TabIndex = 0;
            lblMarka.Text = "Marka";
            lblMarka.Click += label1_Click;
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(175, 58);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(52, 20);
            lblModel.TabIndex = 1;
            lblModel.Text = "Model";
            // 
            // lblRenk
            // 
            lblRenk.AutoSize = true;
            lblRenk.Location = new Point(186, 114);
            lblRenk.Name = "lblRenk";
            lblRenk.Size = new Size(41, 20);
            lblRenk.TabIndex = 2;
            lblRenk.Text = "Renk";
            // 
            // lblKapi
            // 
            lblKapi.AutoSize = true;
            lblKapi.Location = new Point(147, 168);
            lblKapi.Name = "lblKapi";
            lblKapi.Size = new Size(80, 20);
            lblKapi.TabIndex = 3;
            lblKapi.Text = "Kapı Sayısı";
            // 
            // lblPencere
            // 
            lblPencere.AutoSize = true;
            lblPencere.Location = new Point(126, 218);
            lblPencere.Name = "lblPencere";
            lblPencere.Size = new Size(101, 20);
            lblPencere.TabIndex = 4;
            lblPencere.Text = "Pencere Sayısı";
            // 
            // lblYakit
            // 
            lblYakit.AutoSize = true;
            lblYakit.Location = new Point(49, 277);
            lblYakit.Name = "lblYakit";
            lblYakit.Size = new Size(178, 20);
            lblYakit.TabIndex = 5;
            lblYakit.Text = "100 km de yaktığı Yakıt /L";
            // 
            // txtMarka
            // 
            txtMarka.Location = new Point(233, 12);
            txtMarka.Name = "txtMarka";
            txtMarka.Size = new Size(125, 27);
            txtMarka.TabIndex = 6;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(233, 51);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(125, 27);
            txtModel.TabIndex = 7;
            // 
            // txtRenk
            // 
            txtRenk.Location = new Point(233, 107);
            txtRenk.Name = "txtRenk";
            txtRenk.Size = new Size(125, 27);
            txtRenk.TabIndex = 8;
            txtRenk.TextChanged += txtRenk_TextChanged;
            // 
            // txtKapi
            // 
            txtKapi.Location = new Point(233, 165);
            txtKapi.Name = "txtKapi";
            txtKapi.Size = new Size(125, 27);
            txtKapi.TabIndex = 9;
            // 
            // txtPencere
            // 
            txtPencere.Location = new Point(233, 215);
            txtPencere.Name = "txtPencere";
            txtPencere.Size = new Size(125, 27);
            txtPencere.TabIndex = 10;
            // 
            // txtYakit
            // 
            txtYakit.Location = new Point(233, 274);
            txtYakit.Name = "txtYakit";
            txtYakit.Size = new Size(125, 27);
            txtYakit.TabIndex = 11;
            // 
            // btnBilgiGoster
            // 
            btnBilgiGoster.Location = new Point(49, 341);
            btnBilgiGoster.Name = "btnBilgiGoster";
            btnBilgiGoster.Size = new Size(309, 50);
            btnBilgiGoster.TabIndex = 12;
            btnBilgiGoster.Text = "Bilgileri Göster";
            btnBilgiGoster.UseVisualStyleBackColor = true;
            btnBilgiGoster.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBilgiGoster);
            Controls.Add(txtYakit);
            Controls.Add(txtPencere);
            Controls.Add(txtKapi);
            Controls.Add(txtRenk);
            Controls.Add(txtModel);
            Controls.Add(txtMarka);
            Controls.Add(lblYakit);
            Controls.Add(lblPencere);
            Controls.Add(lblKapi);
            Controls.Add(lblRenk);
            Controls.Add(lblModel);
            Controls.Add(lblMarka);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMarka;
        private Label lblModel;
        private Label lblRenk;
        private Label lblKapi;
        private Label lblPencere;
        private Label lblYakit;
        private TextBox txtMarka;
        private TextBox txtModel;
        private TextBox txtRenk;
        private TextBox txtKapi;
        private TextBox txtPencere;
        private TextBox txtYakit;
        private Button btnBilgiGoster;
    }
}
