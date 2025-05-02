using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomAttribute
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDogrula_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci
            {
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                Bolum = txtBolum.Text
            };

            Type type = typeof(Ogrenci);
            var properties = type.GetProperties();

            foreach (var prop in properties)
            {
                var attr = prop.GetCustomAttributes(typeof(ZorunluAlanAttribute), false)
                               .FirstOrDefault() as ZorunluAlanAttribute;

                if (attr != null)
                {
                    var value = prop.GetValue(ogrenci) as string;

                    if (string.IsNullOrWhiteSpace(value))
                    {
                        MessageBox.Show(attr.HataMesaji, "Doğrulama Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }

            lblSonuc.Text = $"Ad: {ogrenci.Ad}, Soyad: {ogrenci.Soyad}, Bölüm: {ogrenci.Bolum}";
        }
    
    }
    
}
