using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using Galeri.Entitiy.Core.Context;
using Galeri.Entitiy.Core.Entities;

namespace GaleriEntity.UI
{
    public partial class Satışlar : Form
    {
        public Satışlar()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            İslemler frm = new İslemler();
            frm.Show();
            this.Hide();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Arac secilenBilgiler = comboBox1.SelectedItem as Arac;
            lblMarka.Text = secilenBilgiler.Marka;
            lblModel.Text = secilenBilgiler.Model;
            lblRenk.Text = secilenBilgiler.Renk;
            lblVitesTip.Text = secilenBilgiler.VitesTipi;
            lblYıl.Text = secilenBilgiler.Yıl;
            lblKM.Text = secilenBilgiler.KM;
            lblFiyat.Text = secilenBilgiler.Fiyat;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Müsteri secilenBilgiler = comboBox2.SelectedItem as Müsteri;
            lblAD.Text = secilenBilgiler.AD;
            lblSoyad.Text = secilenBilgiler.Soyad;
            lblEposta.Text = secilenBilgiler.Eposta;
            lblAdres.Text = secilenBilgiler.Adres;
            lblTC.Text = secilenBilgiler.TC;
            lblTelefon.Text = secilenBilgiler.Telefon;
        }

        private void Satışlar_Load(object sender, EventArgs e)
        {
            MüsterileriDoldur();
            AraclariDoldur();
            ListViewiDoldur();
            SatislariDoldur();

        }

        private void SatislariDoldur()
        {
            using (var db = new MyDbContext())
            {
                var result =
                from m in db.Müsteris  // List<TABLE_1>

                join s in db.Satis
                  on new { A = m.MüsteriID } equals new { A = s.MüsteriID }
                join arc in db.Aracs
                  on new { A = s.AracID } equals new { A = arc.AracID }
                select new
                {
                    Marka = arc.Marka,
                    SatisFiyati = s.SatisFiyatı,
                    MusteriAdSoyad = m.AD + " " + m.Soyad
                };

                listView1.Items.Clear();
                foreach (var item in result)
                {
                    ListViewItem li = new ListViewItem();

                    li.Text = item.Marka.ToString();
                    li.SubItems.Add(item.MusteriAdSoyad.ToString());
                    li.SubItems.Add(item.SatisFiyati.ToString());
                    listView1.Items.Add(li);

                }
            }
        }

        private void ListViewiDoldur()
        {


            listView1.Items.Clear();
            using (MyDbContext db = new MyDbContext())
            {
                List<Satis> satışListesi = db.Satis.ToList();

                foreach (Satis satis in satışListesi)
                {
                    ListViewItem listViewItem = new ListViewItem(satis.AracID.ToString());
                    listViewItem.SubItems.Add(satis.MüsteriID.ToString());
                    listViewItem.SubItems.Add(satis.SatisFiyatı.ToString());

                    // Diğer öğeleri burada ekleyebilirsiniz

                    listView1.Items.Add(listViewItem);
                }
            }
        }



        private List<Arac> AraclariDoldur()
        {
            comboBox1.Items.Clear();
            MyDbContext db = new MyDbContext();
            List<Arac> gelenliste = db.Aracs.Where(a => a.Stoktami == true).ToList();
            foreach (var item in gelenliste)
            {
                comboBox1.Items.Add(item);
            }
            return gelenliste;

        }

        private List<Müsteri> MüsterileriDoldur()
        {
            comboBox2.Items.Clear();
            using (MyDbContext db = new MyDbContext())
            {
                List<Müsteri> gelenliste = db.Müsteris.ToList();
                comboBox2.Items.AddRange(gelenliste.ToArray());
                return gelenliste;
            }
        }

        private void btnSatisYap_Click(object sender, EventArgs e)
        {
            // ilk önce comboboxdan veriyi alacak
            // sonra 2. combodan veriyim alıp
            //fiyat texten veriyi alacak

            // sonrası butona tıkladığında data base satış olarak yansıyacak
            // bu yansıma sonrası view gözükecek ve arac tablodan silinecek.
            if (comboBox1.SelectedItem != null && comboBox2.SelectedItem != null && !string.IsNullOrWhiteSpace(txtSatilanFiyat.Text))
            {
                Arac arac = comboBox1.SelectedItem as Arac;
                Müsteri müsteri = comboBox2.SelectedItem as Müsteri;

                using (TransactionScope tran = new TransactionScope())

                {
                    try
                    {
                        Satis a = new Satis();
                        a.SatisFiyatı = Convert.ToDecimal(txtSatilanFiyat.Text);
                        a.AracID = arac.AracID;
                        a.MüsteriID = müsteri.MüsteriID;

                        using (MyDbContext db = new MyDbContext())
                        {
                            Satis satisYapılan = db.Satis.Add(a);
                            db.Aracs.Single(arc => arc.AracID == arac.AracID).Stoktami = false;
                            db.SaveChanges();
                        }
                        lblMarka.Text = lblModel.Text = lblKM.Text = lblFiyat.Text = lblYıl.Text = lblRenk.Text = lblVitesTip.Text = string.Empty;
                        lblAD.Text = lblSoyad.Text = lblTC.Text = lblTelefon.Text = lblTelefon.Text = lblEposta.Text = txtSatilanFiyat.Text = lblAdres.Text = string.Empty;

                        arac.Stoktami = false;

                        tran.Complete();


                    }

                    catch (Exception ex)
                    {
                        tran.Dispose();
                    }

                }
                SatislariDoldur();
                AraclariDoldur();
            }
            else
            {
                MessageBox.Show("Gerekl Bilgilerini Seçili oldugundan veya Doldurduğunuzdan.");
            }










        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
