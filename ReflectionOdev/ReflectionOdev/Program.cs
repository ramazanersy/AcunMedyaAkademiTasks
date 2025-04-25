using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using OdemeSistemiWinForms.Interfaces;
using ReflectionOdev.IOdemeYontemi;

namespace OdemeSistemiWinForms.Forms
{
    public partial class MainForm : Form
    {
        private ComboBox cmbOdemeYontemi;
        private TextBox txtTutar;
        private Button btnOde;
        private Label lblSonuc;

        public MainForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.cmbOdemeYontemi = new ComboBox();
            this.txtTutar = new TextBox();
            this.btnOde = new Button();
            this.lblSonuc = new Label();
            this.SuspendLayout();

            // cmbOdemeYontemi
            this.cmbOdemeYontemi.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbOdemeYontemi.Location = new System.Drawing.Point(20, 20);
            this.cmbOdemeYontemi.Size = new System.Drawing.Size(200, 24);

            // txtTutar
            this.txtTutar.Location = new System.Drawing.Point(20, 60);
            this.txtTutar.Size = new System.Drawing.Size(200, 22);

            // btnOde
            this.btnOde.Location = new System.Drawing.Point(20, 100);
            this.btnOde.Size = new System.Drawing.Size(200, 30);
            this.btnOde.Text = "Öde";
            this.btnOde.Click += new EventHandler(this.BtnOde_Click);

            // lblSonuc
            this.lblSonuc.Location = new System.Drawing.Point(20, 140);
            this.lblSonuc.Size = new System.Drawing.Size(300, 30);
            this.lblSonuc.Text = "";

            // MainForm
            this.ClientSize = new System.Drawing.Size(350, 200);
            this.Controls.Add(this.cmbOdemeYontemi);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.btnOde);
            this.Controls.Add(this.lblSonuc);
            this.Text = "Ödeme Sistemi";
            this.Load += new EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Reflection ile tüm IOdemeYontemi implementasyonlarýný bul
            var odemeYontemleri = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => typeof(IOdemeYontemi).IsAssignableFrom(t) && !t.IsInterface);

            foreach (var yontem in odemeYontemleri)
            {
                cmbOdemeYontemi.Items.Add(yontem.FullName);
            }

            if (cmbOdemeYontemi.Items.Count > 0)
                cmbOdemeYontemi.SelectedIndex = 0;
        }

        private void BtnOde_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtTutar.Text, out decimal tutar))
            {
                MessageBox.Show("Lütfen geçerli bir tutar girin.");
                return;
            }

            string sinifAdi = cmbOdemeYontemi.SelectedItem.ToString();
            var tip = Assembly.GetExecutingAssembly().GetType(sinifAdi);

            if (tip != null && typeof(IOdemeYontemi).IsAssignableFrom(tip))
            {
                var odemeSinifi = Activator.CreateInstance(tip) as IOdemeYontemi;
                string sonuc = odemeSinifi.Ode(tutar);
                lblSonuc.Text = sonuc;
            }
        }
    }
}
