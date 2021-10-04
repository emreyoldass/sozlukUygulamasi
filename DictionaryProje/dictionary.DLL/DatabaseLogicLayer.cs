using dictionary.Entites;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary.Core

{
    public class DatabaseLogicLayer
    {
        List<kutuphane> kayitlarim;
        public DatabaseLogicLayer()
        {
            kayitlarim = new List<kutuphane>();
            veriTabaniKontrol();
        }

        //Veri Tabanı Kontrol ediyoruz böyle bir klasor varmı varsa birşey yapmıyoruz yok ise oluşturuyoruz
        private void veriTabaniKontrol()
        {
            //buraya kendi diskinizde nereye oluşturacaksanız seçmeniz gerek.
            bool klasorKontrol = Directory.Exists(@"D:\visual csharp çalışmalar\DictionaryProje\DictonaryDB\");
            if (!klasorKontrol)
            {
                Directory.CreateDirectory(@"D:\visual csharp çalışmalar\DictionaryProje\DictonaryDB\");

            }


        }
        public int yeniKayit(kutuphane A)
        {
            int sonuc = 0;
            try
            {
                //Kayıtlarımız getiriyoruz kayitlarim içine yeni kaydımızı dataya kayıt ediyoruz.
                kutuphaneKayitlariGetir();
                kayitlarim.Add(A);
                JsonDBGüncelle();
                sonuc = 1;
            }
            catch (Exception ex)
            {
                //Log
                sonuc = 0;
            }
            return sonuc;
        }

        public int kayitGuncelle(kutuphane A)
        {
            int sonuc = 0;
            try
            {
                //indexler arasında indeximizi arama işlemi yapıyoruz.
                kutuphaneKayitlariGetir();
                int index = kayitlarim.FindIndex(i => i.ID == A.ID);
                if (index>-1)
                {
                    kayitlarim[index].enKarsilik = A.enKarsilik;
                    kayitlarim[index].trKarsilik = A.trKarsilik;
                    kayitlarim[index].örnekKullanim = A.örnekKullanim;
                    kayitlarim[index].aciklama = A.aciklama;
                }
                JsonDBGüncelle();
                sonuc = 1;
            }
            catch (Exception ex)
            {

                sonuc = 0;
            }
            return sonuc;
        }
        public int kayitSil(Guid ID)
        {
            int sonuc = 0;
            try
            {
                //Datamız içerisinde ID buluyoruz sileceğimiz ID  eşit ise silme işlemini gerçekleştiriyoruz.
                kutuphaneKayitlariGetir();
                kutuphane silinecekDeger = kayitlarim.Find(i => i.ID == ID);
                if (silinecekDeger!=null)
                {
                    kayitlarim.Remove(silinecekDeger);
                }
                JsonDBGüncelle();
                sonuc = 1;
            }
            catch (Exception ex)
            {

                sonuc = 0;
            }
            return sonuc;
        }
        public List<kutuphane> kutuphaneKayitlariGetir()
        {
            //Datamız içerisindeki bilgileri List yapısı ile alıyoruz.
            if (File.Exists(@"D:\visual csharp çalışmalar\DictionaryProje\DictonaryDB\kutuphane.json"))
            {
                string JsonDBText = File.ReadAllText(@"D:\visual csharp çalışmalar\DictionaryProje\DictonaryDB\kutuphane.json");
                kayitlarim = Newtonsoft.Json.JsonConvert.DeserializeObject<List<kutuphane>>(JsonDBText);
            }
            return kayitlarim;
        }
        #region Yardımcı Metotumuz
        private void JsonDBGüncelle()
        {
            //kayitlarim boş ve içerisinde  değer var ise güncelleme işlemini yaparız.
            if (kayitlarim != null && kayitlarim.Count > 0)
            {
                string JsonDB = Newtonsoft.Json.JsonConvert.SerializeObject(kayitlarim);
                File.WriteAllText(@"D:\visual csharp çalışmalar\DictionaryProje\DictonaryDB\kutuphane.json", JsonDB);
            }
        }
        #endregion
    }
}
