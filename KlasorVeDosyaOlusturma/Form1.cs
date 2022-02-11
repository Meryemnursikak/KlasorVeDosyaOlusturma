using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlasorVeDosyaOlusturma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnklasor_Click(object sender, EventArgs e)
        {

            //dosya var mı diye lontrol eder
            bool kontrol = Directory.Exists("C:\\Sınıf403");

            //yoksa klasörü oluşturur.
            if (kontrol == false)
            {
                Directory.CreateDirectory("C:\\Sınıf403");
                MessageBox.Show("Klasör oluşturuldu.");
            }
            else
            {
                DialogResult cevap= MessageBox.Show("Klasör daha önce oluşturulmuş.Yeniden oluşturmak ister misiniz?",
                    "Klasör Oluştur",MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);
                if (cevap==DialogResult.Yes)
                {
                    Directory.Delete("C:\\Sınıf403", true); //true klasör dolu olsada siler false deseydik
                    Directory.CreateDirectory("C:\\Sınıf403");
                }
                
            }
        }
            
        private void btnklasortasi_Click(object sender, EventArgs e)
        {
            DirectoryInfo info = Directory.CreateDirectory("C:\\deneme");
            if (info.Exists)
            {
                Directory.Move("C:\\Sınıf403", "C:\\deneme\\Sınıf403");
                MessageBox.Show("Klasör taşındı.");
            }
            
        }

        private void btndosya_Click(object sender, EventArgs e)
        {
            bool kontrol = File.Exists("C:\\Sınıf403\\deneme.txt");
            if (kontrol==false)
            {
                //dosyayı kapatmak için filestream değişkenine atadık.
                FileStream fs=File.Create("C:\\Sınıf403\\deneme.txt");
                fs.Close();
                MessageBox.Show("Dosya Oluşturuldu");
            }
            else
            {
                File.AppendAllText("C:\\Sınıf403\\deneme.txt", "Merhaba dosya");
                MessageBox.Show("Dosya içine bir metin yazıldı.");
            }
            
        }

        private void btnkopyala_Click(object sender, EventArgs e)
        {
            File.Copy("\\Sınıf403\\deneme.txt", "C:\\deneme\\deneme.txt");
            MessageBox.Show("Dosya Kopyalandı.");
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            File.Delete("C:\\deneme\\deneme.txt");
            MessageBox.Show("Dosya Silindi");
        }

        private void btnoku_Click(object sender, EventArgs e)
        {
            string icerik = File.ReadAllText("C:\\deneme\\deneme.txt");
            MessageBox.Show(icerik);
        }
    }
}
