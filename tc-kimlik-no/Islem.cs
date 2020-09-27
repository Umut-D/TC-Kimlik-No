using System;
using System.Linq;
using System.Reflection;

namespace TcKimlikNo
{
    public class Islem
    {
        private string _tcKimlikNo = "";

        public bool Kontrol(string tcKimlikNo)
        {
            // Girilen numaranın ilk dokuz hanesini al (Son iki hanenin doğruluğunu program hesaplayacak)
            _tcKimlikNo = tcKimlikNo.Substring(0, 9);

            Hesapla();

            if (!Karsilastir(tcKimlikNo))
                return false;

            Sifirla();
            return true;
        }

        public object[] RastgeleOlustur(int adet)
        {
            Random rastgeleSayi = new Random();
            object[] tcKimlikNumaralari = new object[adet];

            for (int j = 0; j < adet; j++)
            {
                Sifirla();

                // İlk dokuz haneyi kafana göre oluştur
                for (int i = 0; i < 9; i++)
                    _tcKimlikNo += rastgeleSayi.Next(1, 10);

                Hesapla();

                tcKimlikNumaralari[j] = _tcKimlikNo;
            }

            return tcKimlikNumaralari;
        }

        private void Hesapla()
        {
            // 1) 1, 3, 5, 7 ve 9. sıradaki rakamın toplamının 7 katı 
            int tekBasamaklar = 0;
            for (int i = 0; i < 9; i += 2)
                tekBasamaklar += int.Parse(_tcKimlikNo.Substring(i, 1)) * 7;

            // 2) 2, 4, 6 ve 8.rakamın toplamının 9 katını topla
            int ciftBasamaklar = 0;
            for (int i = 1; i < 9; i += 2)
                ciftBasamaklar += int.Parse(_tcKimlikNo.Substring(i, 1)) * 9;

            // 3) Çıkan sonucun birler basamağı 10. rakamı veriyor
            int onuncuBasamak = (tekBasamaklar + ciftBasamaklar) % 10;

            // 4) Hesaplanan 10. basamağı, 9 basamağı oluşturan Tc kimlik numarasına ekle
            _tcKimlikNo += onuncuBasamak;

            // 5) ilk 10 rakamın toplamının birler basamağı 11. rakamı veriyor
            int onBirinciBasamak = 0;
            for (int i = 0; i < 10; i++)
                onBirinciBasamak += int.Parse(_tcKimlikNo.Substring(i, 1));
            onBirinciBasamak %= 10;

            // 6) Elde edilen ilk 10 ve 11. haneyi birleştirip diziye ekle
            _tcKimlikNo += onBirinciBasamak;
        }

        private bool Karsilastir(string tcKimlikNo)
        {
            // 7) 10. ve 11. basamağı hesaplanıp yeniden oluşturulan numarayla, sisteme girileni karşılaştır
            return _tcKimlikNo == tcKimlikNo;
        }

        public void Sifirla()
        {
            // _tcKimlikNo alanını (field) komutla sıfırlayacağıma, Reflection kullandım
            // İşte gerçek tembellik bu!
            foreach (FieldInfo alan in GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic).ToArray())
            {
                if (alan.FieldType == typeof(string))
                    alan.SetValue(this, null);
            }
        }
    }
}