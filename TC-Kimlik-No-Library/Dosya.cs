using System.IO;
using System.Windows.Forms;

namespace TCKimlikNoLibrary
{
    public class Dosya
    {
        public static void Kaydet(string dosyaAdi, ListBox.ObjectCollection liste)
        {
            using (StreamWriter kayit = new StreamWriter(dosyaAdi))
            {
                // ListBox'taki her nesneyi metin belgesine kaydet
                foreach (object numaralar in liste)
                    kayit.WriteLine(numaralar);
            }
        }
    }
}