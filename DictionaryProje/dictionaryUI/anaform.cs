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
    public partial class anaform : Form
    {
        dictionary.BLL.BusinessLogicLayer BLL;
        public anaform()
        {
            InitializeComponent();
            BLL = new dictionary.BLL.BusinessLogicLayer();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            int sonuc = BLL.yeniKayit(Guid.NewGuid(), txt_en.Text, txt_tr.Text, txt_örnek.Text, txt_aciklama.Text);
            if (sonuc > 0)
            {
                MessageBox.Show("Kaydınız Başarılı Bir Şekilde Eklendi");
                txt_en.Clear();
                txt_tr.Clear();
                txt_örnek.Clear();
                txt_aciklama.Clear();
            }
            else if (sonuc == -101)
            {
                MessageBox.Show("Eksik Parametre Hatası. Lütfen EN-TR Karşılık alanlarınız doldurunuz ");
            }
            else
            {
                MessageBox.Show("Kayıt Ekleme İşleminde Hata oluştu");
            }
        }

        private void btn_kutuphaneAc_Click(object sender, EventArgs e)
        {
            kutuphaneform form2 = new kutuphaneform();
            /*
             * Formu ben açık bırakmayı tercih ettiğimden dolayı yorum haline getiriyorum.
            *form2 formumuz kapandığı zaman form1 de kapatmak için formclosing ile kapatma işlemi yapıyoruz.
            *form2.FormClosing += Form2_FormClosing;
            this.Hide();*/
            form2.Show();
           
        }
        //Şuanlık ben açık bırakmayı tercih ediyorum. 
        //private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    //Form1 Kapatıyoruz
        //    this.Close();
        //}

        
    }
}
