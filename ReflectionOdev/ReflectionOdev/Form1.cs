namespace ReflectionOdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTara_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string anaKlasor = txtKlasorYolu.Text;

            if (!Directory.Exists(anaKlasor))
            {
                MessageBox.Show("Geçerli bir klasör yolu girin.");
                return;
            }

            // Alt klasörleri gez
            foreach (string klasorYolu in Directory.GetDirectories(anaKlasor))
            {
                string klasorAdi = Path.GetFileName(klasorYolu);
                listBox1.Items.Add($"?? {klasorAdi}");

                // .cs dosyalarýný bul
                string[] csDosyalar = Directory.GetFiles(klasorYolu, "*.cs");

                foreach (string dosya in csDosyalar)
                {
                    string[] satirlar = File.ReadAllLines(dosya);

                    foreach (string satir in satirlar)
                    {
                        string temizSatir = satir.Trim();

                        if (temizSatir.StartsWith("public class") || temizSatir.StartsWith("class"))
                        {
                            string[] parcali = temizSatir.Split(' ');
                            int classIndex = Array.IndexOf(parcali, "class");

                            if (classIndex >= 0 && parcali.Length > classIndex + 1)
                            {
                                string classAdi = parcali[classIndex + 1];
                                listBox1.Items.Add($"   ?? {classAdi}");
                            }
                        }

                    }
                }
            }
            MessageBox.Show("Tarama tamamlandý.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}


