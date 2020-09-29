using System;
using System.Drawing;
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

            tsslBilgi.Text = $@"{lboxListe.Items.Count} adet TC Kimlik No var.";
        }

        private void BtnKontrolEt_Click(object sender, EventArgs e)
        {
            // Her seferinde nesneyi sıfırlayıp kontrol yap
            if (txtTcKimlikNo.TextLength == 11 && !txtTcKimlikNo.Text.StartsWith("0"))
            {
                Islem islem = new Islem();
                if (islem.Kontrol(txtTcKimlikNo.Text))
                    MessageBox.Show(@"TC Kimlik Numarası doğru.", @"Sonuç", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
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

                MessageBox.Show(@"Üretilen TC Kimlik numaraları kaydedildi.", @"Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (lboxListe.Items.Count <= 0)
                return;

            txtTcKimlikNo.Text = lboxListe.SelectedItem.ToString().TrimEnd();
        }

        private void LboxListe_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (lboxListe.Items.Count <= 0)
                return;

            e = SecilenDegeriRenklendir(e);
            DegerleriRenklendir(e);
        }

        private DrawItemEventArgs SecilenDegeriRenklendir(DrawItemEventArgs e)
        {
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(e.Graphics, e.Font, e.Bounds, e.Index, e.State ^ DrawItemState.Selected, e.ForeColor, Color.LightGray);

            return e;
        }

        private void DegerleriRenklendir(DrawItemEventArgs e)
        {
            string numara = lboxListe.Items[e.Index].ToString();

            SolidBrush firca = new SolidBrush(Color.Green);
            if (numara.Contains("   "))
                firca = new SolidBrush(Color.Red);

            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            e.DrawBackground();
            e.Graphics.DrawString(numara, new Font("Calibri", 12), firca, e.Bounds.Left, e.Bounds.Top);
        }

        private void LboxListe_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Right) != 0)
            {
                lboxListe.SelectedIndex = lboxListe.IndexFromPoint(e.X, e.Y);
                txtTcKimlikNo.Text = lboxListe.SelectedItem.ToString().TrimEnd();
            }
        }

        private void LboxListe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                txtTcKimlikNo.Copy();
                Clipboard.SetText(lboxListe.SelectedItem.ToString().TrimEnd());
            }

            if (e.Control && e.KeyCode == Keys.X)
            {
                txtTcKimlikNo.Cut();
                Clipboard.SetText(lboxListe.SelectedItem.ToString().TrimEnd());
            }

            if (e.Control && e.KeyCode == Keys.V)
                tsmYapistir.PerformClick();
        }

        private void TsmKes_Click(object sender, EventArgs e)
        {
            txtTcKimlikNo.SelectAll();
            txtTcKimlikNo.Cut();
        }

        private void TsmKopyala_Click(object sender, EventArgs e)
        {
            txtTcKimlikNo.SelectAll();
            txtTcKimlikNo.Copy();
        }

        private void TsmYapistir_Click(object sender, EventArgs e)
        {
            txtTcKimlikNo.Clear();
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