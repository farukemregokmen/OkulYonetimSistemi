using static OkulYonetimSistemi.PersonDAL;

namespace OkulYonetimSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void OgrtGiris_Click(object sender, EventArgs e)
        {
            var ogrtAdSoyad = OgrtAdSoyadText.Text;
            var ogrtSifre = OgrtSifreText.Text;
            if (string.IsNullOrEmpty(ogrtAdSoyad) || string.IsNullOrEmpty(ogrtSifre))
            {
                MessageBox.Show("Lütfen tüm alanlarý doldurun.");
                return;
            }
            Ogretmenler ogretmen1 = new Ogretmenler() { AdSoyad = OgrtAdSoyadText.Text, Sifre = OgrtSifreText.Text };
            ogretmen1.GirisYap(ogrtAdSoyad, ogrtSifre);
        }
    }
}
