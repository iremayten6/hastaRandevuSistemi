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

            // randevu eklendi mesaj� verdim.
            MessageBox.Show("Randevu ba�ar�yla eklendi!");

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
            // randevu listesini olu�turdum.
            string randevuListesi = "";
            foreach (string randevu in randevular)
            {
                randevuListesi += randevu + "\n";
            }

            // listeyi mesaj kutusunda g�sterdim.
            MessageBox.Show(randevuListesi);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}