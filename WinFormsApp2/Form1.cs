namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        Galeri galeri = new Galeri();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void EkranTemizle()
        {
            txtMarka.Text = txtModel.Text = txtRenk.Text = "";
            txtMarka.Focus();
        }
        private void bttnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Araba araba = new Araba();
                araba.Marka = txtMarka.Text;
                araba.Model = Convert.ToInt16(txtModel.Text);
                araba.Renk = txtRenk.Text;

                galeri.ArabaEkle(araba);
                EkranTemizle();
                MessageBox.Show("Araba baþarýyla eklendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " +  ex.Message);
            }
        }

        private void bttnListele_Click(object sender, EventArgs e)
        {
            txtArabalar.Text = galeri.ArabalariListele();
            dataAraba.DataSource = galeri.ArabaListesiVer() ;
        }
    }
}
