using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TcKimlikNo
{
    public partial class FrmTcKimlik : Form
    {
        public FrmTcKimlik()
        {
            InitializeComponent();
        }

        private void BtnOlustur_Click(object sender, EventArgs e)
        {
            lboxListe.Items.Clear();
            txtTcKimlikNo.Clear();

            Islem islem = new Islem();
            int adet = Convert.ToInt32(nupSayi.Value);
            lboxListe.Items.AddRange(islem.RastgeleOlustur(adet));
        }

        private void BtnKontrolEt_Click(object sender, EventArgs e)
        {
            // Her seferinde nesneyi sıfırlayıp kontrol yap
            if (txtTcKimlikNo.TextLength == 11 && !txtTcKimlikNo.Text.StartsWith("0"))
            {
                Islem islem = new Islem();
                if (islem.Kontrol(txtTcKimlikNo.Text))
                    MessageBox.Show(@"TC Kimlik Numarası doğru.", @"Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(@"TC Kimlik Numarası yanlış.", @"Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show(@"11 Haneli bir TC Kimlik numarası giriniz.", @"Hata", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            DialogResult kayitDurumu = sfdKaydet.ShowDialog();
            if (lboxListe.Items.Count != 0 && kayitDurumu == DialogResult.OK)
            {
                ListBox.ObjectCollection liste = lboxListe.Items;
                Dosya.Kaydet(sfdKaydet.FileName, liste);

                MessageBox.Show(@"Üretilen TC Kimlik numaraları kaydedildi.", @"Sonuç", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void TxtTcKimlikNo_TextChanged(object sender, EventArgs e)
        {
            // Girilen değer rakam değilse (harf vs.) bunun yazılmasını kabul etme
            if (!Regex.IsMatch(txtTcKimlikNo.Text, "^[0-9]*$"))
                txtTcKimlikNo.Text = txtTcKimlikNo.Text.Remove(txtTcKimlikNo.Text.Length - 1);
        }

        private void LboxListe_Click(object sender, EventArgs e)
        {
            txtTcKimlikNo.Text = (string) lboxListe.SelectedItem;
        }

        private void LboxListe_DoubleClick(object sender, EventArgs e)
        {
            btnKontrolEt.PerformClick();
        }

        private void TsmKes_Click(object sender, EventArgs e)
        {
            txtTcKimlikNo.SelectAll();
            txtTcKimlikNo.Cut();
        }

        private void TsmKopyala_Click(object sender, EventArgs e)
        {
            txtTcKimlikNo.Copy();
        }

        private void TsmYapistir_Click(object sender, EventArgs e)
        {
            txtTcKimlikNo.SelectAll();
            txtTcKimlikNo.Paste();
        }

        private void BtnAktar_Click(object sender, EventArgs e)
        {
            FrmTopluTest frmTopluTest = new FrmTopluTest(this);
            frmTopluTest.ShowDialog();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}