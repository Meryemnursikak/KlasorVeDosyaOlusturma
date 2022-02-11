using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FakeDataUzerindenKlasorOlusturma1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Kisi> liste = new List<Kisi>();
        private void btngetir_Click(object sender, EventArgs e)
        {
            Dataislemleri di = new Dataislemleri();
            liste = di.KisiGetir();
            lstkisiler.DataSource = liste;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            Dataislemleri ds = new Dataislemleri();
            ds.KlasorOlustur(liste);
            MessageBox.Show("Klasörler oluşturuldu.");
        }

        private void lstkisiler_DoubleClick(object sender, EventArgs e)
        {
            Kisi secilenkisi = (Kisi)lstkisiler.SelectedItem;
            txtad.Text = secilenkisi.isim;
            txtsoyad.Text = secilenkisi.soyisim;
            txtemail.Text = secilenkisi.email;
            txtulke.Text = secilenkisi.ulke;
        }
    }
}
