using dictionary.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dictionaryUI
{
    public partial class kutuphaneform : Form
    {
        dictionary.BLL.BusinessLogicLayer BLL;
        public kutuphaneform()
        {
            InitializeComponent();
            BLL = new dictionary.BLL.BusinessLogicLayer();
        }

        private void doldur()
        {
            //Json databasemizde kayıtlı olan dosyaları metot ile açılışta doldurmak için bu metotu kullanıyoruz.
            List<kutuphane> kutuphaneKayitlarim = BLL.kutuphaneKayitlariGetir();
            if (kutuphaneKayitlarim!= null &&kutuphaneKayitlarim.Count>0)
            {
                lst_kayitlar.DataSource = kutuphaneKayitlarim;
            }
        }

        private void kutuphaneform_Load(object sender, EventArgs e)
        {
            //Formumuz yüklenirken doldur metodu ile listbox içine databasede var olan bilgileri aktarımını yapıyoruz.
            doldur();
        }

        private void lst_kayitlar_DoubleClick(object sender, EventArgs e)
        {
            //ListBox'ta seçim yaptığımız zaman değerlerimizin TextBoxlara aktarma işlemi yapıyoruz.
            ListBox L = (ListBox)sender;
            kutuphane secilenDeger = (kutuphane)L.SelectedItem;
            txt_en.Text = secilenDeger.enKarsilik;
            txt_tr.Text = secilenDeger.trKarsilik;
            txt_örnek.Text = secilenDeger.örnekKullanim;
            txt_aciklama.Text = secilenDeger.aciklama;
        }

        private void btn_Güncelle_Click(object sender, EventArgs e)
        {
            if (lst_kayitlar.SelectedItem != null)
            {
                
                kutuphane A = (kutuphane)lst_kayitlar.SelectedItem;

                //BLL sınıfımızdaki metotun yardımıyla güncelleme işlemini yapıyoruz.
                int sonuc = BLL.kayitGüncelle(A.ID, txt_en.Text, txt_tr.Text, txt_örnek.Text, txt_aciklama.Text);
                
                if (sonuc > 0)
                {
                    MessageBox.Show("Kaydınız Başarılı Bir Şekilde Güncellendi");
                    lbl_durum.Text = "Kelime Kaydı Güncellendi";
                    doldur();
                }
                else if (sonuc == -100)
                {
                    MessageBox.Show("Eksik Parametre Hatası");
                }
                else
                {
                    MessageBox.Show("Kayıt Güncelleme İşleminde Hata Oluştu");
                }
            }  
            
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            Guid silinecekID = ((kutuphane)lst_kayitlar.SelectedItem).ID;
            int sonuc = BLL.kayitSil(silinecekID);
            
            if (sonuc > 0)
            {
                MessageBox.Show("Kaydınız Başarılı Bir Şekilde Silindi");
               //textboxlar kelime silindikten sonra eski bilgiler duracağından sıfırlama temizleme işlemi yaptık.
                txt_en.Clear();
                txt_tr.Clear();
                txt_örnek.Clear();
                txt_aciklama.Clear();
                doldur();
                lbl_durum.Text = "Kelime Kaydı Silindi. ";
            }

            else
            {
                MessageBox.Show("Kayıt Silme İşleminde Hata Oluştu");
            }
        }
    }
}
