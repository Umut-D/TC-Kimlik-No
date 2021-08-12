using System;
using System.Windows.Forms;
using TCKimlikNoLibrary;

namespace TcKimlikNoUI
{
    public partial class FrmTopluTest : Form
    {
        private readonly FrmTcKimlik _frmTcKimlik;

        public FrmTopluTest(FrmTcKimlik frmTcKimlik)
        {
            InitializeComponent();
            _frmTcKimlik = frmTcKimlik;
        }

        private void BtnTopluTest_Click(object sender, EventArgs e)
        {
            if (txtListe.Lines.Length <= 0)
                return;

            _frmTcKimlik.lboxListe.Items.Clear();

            ListeyeAktar();

            _frmTcKimlik.tsslBilgi.Text = Adet();

            Close();
            Dispose();
        }

        private static bool NumaraKontrol(string satir)
        {
            return satir.Length != 11 || satir.StartsWith("0");
        }

        private void ListeyeAktar()
        {
            Islem islem = new Islem();
            foreach (var satir in txtListe.Lines)
            {
                if (NumaraKontrol(satir))
                    continue;

                if (islem.Kontrol(satir) && !chkHatalilariGoster.Checked)
                    _frmTcKimlik.lboxListe.Items.Add(satir);
                else if (!islem.Kontrol(satir) && chkHatalilariGoster.Checked)
                    _frmTcKimlik.lboxListe.Items.Add(satir + "   ");
            }
        }

        private string Adet()
        {
            return $@"{_frmTcKimlik.lboxListe.Items.Count} adet TC Kimlik No var.";
        }

        private void TxtListe_KeyPress(object sender, KeyPressEventArgs e)
        {
            GirilenKarakterSayiMi(e);
            SatirEkle();
        }

        private void GirilenKarakterSayiMi(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private int _harfSayisi;
        private void SatirEkle()
        {
            if (_harfSayisi >= 11 && _harfSayisi % 11 == 0)
                txtListe.AppendText(Environment.NewLine);

            _harfSayisi++;
        }
    }
}