namespace CarInformation
{
  
    public partial class Form1 : Form
    {
        string marka = "";
        string model = "";
        string renk = "";
        string kapi = "";
        string pencere = "";
        string yakit = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            marka=txtMarka.Text;
            model=txtModel.Text;
            renk=txtRenk.Text;
            kapi=txtKapi.Text;
            pencere=txtPencere.Text;
            yakit=txtYakit.Text;
            MessageBox.Show("Markas�: " + marka + "Modeli: " + model + "Rengi: " + renk + "Kap� say�s�: " + kapi + "Pencere say�s�: " + pencere + "100 KM de yak�lan yak�t: " + yakit + "L");
        }

        private void txtRenk_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
