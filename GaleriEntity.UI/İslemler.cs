using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Galeri.Entitiy.Core.Context;

namespace GaleriEntity.UI
{
    public partial class İslemler : Form
    {
        public İslemler()
        {
            InitializeComponent();

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MüsteriEkleme frm = new MüsteriEkleme();


            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MüsteriListeleme frm = new MüsteriListeleme();

            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AracKayıt frm = new AracKayıt();

            frm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AraçListeleme frm = new AraçListeleme();

            frm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Satışlar frm = new Satışlar();

            frm.Show();
            this.Hide();



        }


        private void İslemler_Load(object sender, EventArgs e)
        {

        }
        
        private void button6_Click(object sender, EventArgs e)
        {
            int aracAdet;
            using (MyDbContext db = new MyDbContext())
            {
                aracAdet = db.Aracs.Where(a => a.Stoktami == true).Count();
               
            }
            MessageBox.Show($"Toplam {aracAdet} aracınız vardır ", "Toplam Araç Adediniz");

        }

        private void button7_Click(object sender, EventArgs e)
        {
            decimal stokCiro;
            using (MyDbContext db = new MyDbContext())
            {
                stokCiro = db.Satis.Sum(a => a.SatisFiyatı);
                
            }
            MessageBox.Show($"Toplam {stokCiro} TL cironuz vardır ", "Toplam Cironuz");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int müsteriadet;
            using (MyDbContext db = new MyDbContext())
            {
                müsteriadet = db.Müsteris.Count();
            }
            MessageBox.Show($"Toplam {müsteriadet} müşteriniz vardır ", "Toplam Müşteri Adediniz");
        }
    }
}
