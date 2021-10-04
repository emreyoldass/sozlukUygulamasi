using dictionary.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary.BLL
{
    public class BusinessLogicLayer
    {
        dictionary.Core.DatabaseLogicLayer DLL;
        public BusinessLogicLayer()
        {
            DLL = new Core.DatabaseLogicLayer();
        }

        public int yeniKayit(Guid ID , string enKarsilik,string trKarsilik,string örnekKullanim,string aciklama)
        {
            int sonuc = 0;
            if (ID != Guid.Empty && !string.IsNullOrEmpty(enKarsilik) && !string.IsNullOrEmpty(trKarsilik))//zorunlu alanlar
            {
                kutuphane kayit = new kutuphane();
                kayit.ID = ID;
                kayit.trKarsilik = trKarsilik;
                kayit.enKarsilik = enKarsilik;
                kayit.örnekKullanim = örnekKullanim;
                kayit.aciklama = aciklama;
                sonuc = DLL.yeniKayit(kayit);

            }
            else
            {
                sonuc = -101;//Eksik parametre hatası
            }
            return sonuc;
        }

        public int kayitGüncelle(Guid ID, string enKarsilik, string trKarsilik, string örnekKullanim, string aciklama)
        {
            int sonuc = 0;
            if (ID != Guid.Empty && !string.IsNullOrEmpty(enKarsilik) && !string.IsNullOrEmpty(trKarsilik))//zorunlu alanlar
            {
                kutuphane kayit = new kutuphane();
                kayit.ID = ID;
                kayit.trKarsilik = trKarsilik;
                kayit.enKarsilik = enKarsilik;
                kayit.örnekKullanim = örnekKullanim;
                kayit.aciklama = aciklama;
                sonuc = DLL.yeniKayit(kayit);

            }
            else
            {
                sonuc = -101;//Eksik parametre hatası
            }
            return sonuc;
        }
        public int kayitSil(Guid ID)
        {
            //DatabaseLogicLayer içerisinde oluşturduğumuz kayitSil metotunu kullanıyoruz.
            return DLL.kayitSil(ID);
        }
        public List<kutuphane> kutuphaneKayitlariGetir()
        {
            //DatabaseLogicLayer içerisinde oluşturduğumuz kutuphaneKayitlariGetir metotunu kullanıyoruz.
            return DLL.kutuphaneKayitlariGetir();
        }
    }
}
