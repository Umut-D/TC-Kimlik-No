using System;
using System.Windows.Forms;

namespace TcKimlikNo
{
    public partial class FrmTopluTest : Form
    {
        readonly FrmTcKimlik _frmTcKimlik;

        public FrmTopluTest(FrmTcKimlik frmTcKimlik)
        {
            _frmTcKimlik = frmTcKimlik;
            InitializeComponent();
        }

        private void BtnTopluTest_Click(object sender, EventArgs e)
        {
            if (txtListe.Lines.Length <= 0)
                return;

            _frmTcKimlik.lboxListe.Items.Clear();

            Islem islem = new Islem();
            foreach (var satir in txtListe.Lines)
            {
                if (satir.Length != 11 || satir.StartsWith("0")) 
                    continue;
                
                if (islem.Kontrol(satir))
                    _frmTcKimlik.lboxListe.Items.Add(satir);
            }

            Close();
            Dispose();
        }
    }
}