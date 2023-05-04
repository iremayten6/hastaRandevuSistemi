using System.Globalization;

namespace yeni11nisan
{
    public partial class FormRandevu : Form
    {
        List<string> randevular = new List<string>();
        public FormRandevu()
        {
            InitializeComponent();
        }

        private void btnRandevuKaydet_Click(object sender, EventArgs e)
        {
            string randevu = txtAd.Text + " " + txtSoyad.Text + " - " + dtpTarih.Value.ToShortDateString() +
                " - " + txtTelefon.Text + " - " + txtBolum.Text + "\n" + txtSaat.Text +"-" + txtHekimAdi.Text;
            randevular.Add(randevu);

            // randevu eklendi mesajý verdim.
            MessageBox.Show("Randevu baþarýyla eklendi!");

            // girdileri temizle
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtTelefon.Text = "";
            txtBolum.Text = "";
            txtSaat.Text = "";
            txtHekimAdi.Text = "";
            dtpTarih.Value = DateTime.Now;

        }

        private void btnRandevuListele_Click(object sender, EventArgs e)
        {
            // randevu listesini oluþturdum.
            string randevuListesi = "";
            foreach (string randevu in randevular)
            {
                randevuListesi += randevu + "\n";
            }

            // listeyi mesaj kutusunda gösterdim.
            MessageBox.Show(randevuListesi);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}