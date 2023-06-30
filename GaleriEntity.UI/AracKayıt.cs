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
    public partial class AracKayıt : Form
    {
        public AracKayıt()
        {
            InitializeComponent();
        }

        private void AracKayıt_Load(object sender, EventArgs e)
        {
            AraclariDoldur();
        }

        private List<Arac> AraclariDoldur()
        {
            lstArabalar.Items.Clear();
            MyDbContext db = new MyDbContext();
            List<Arac> gelenliste = db.Aracs.Where(a=> a.Stoktami ==true).ToList();

            //solid ne demek absturck class ne demek bakılacak.

            //itemin tipi category
            foreach (var item in gelenliste)
            {
                lstArabalar.Items.Add(item);
            }
            return gelenliste;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            İslemler frm = new İslemler();
            frm.Show();
            this.Hide();
        }
        List<Arac> aracBilgileri = new List<Arac>();
        
        private void btnAracEkle_Click(object sender, EventArgs e)
        {
            Arac a = new Arac();
            a.Marka = txtMarka.Text;
            a.Model = txtModel.Text;
            a.Renk = txtRenk.Text;
            a.KM = txtKm.Text;
            a.Yıl = txtYıl.Text;
            a.VitesTipi = txtVites.Text;
            a.Fiyat = txtFiyat.Text;

            if (!string.IsNullOrWhiteSpace(txtFiyat.Text) && !string.IsNullOrWhiteSpace(txtKm.Text) && !string.IsNullOrWhiteSpace(txtMarka.Text) && !string.IsNullOrWhiteSpace(txtModel.Text) && !string.IsNullOrWhiteSpace(txtRenk.Text) && !string.IsNullOrWhiteSpace(txtVites.Text) && !string.IsNullOrWhiteSpace(txtYıl.Text))
            {
                using (TransactionScope tran = new TransactionScope())
                {
                    try
                    {
                        using (MyDbContext db = new MyDbContext())
                        {
                            Arac kayıtArac = db.Aracs.Add(a);
                            db.SaveChanges();
                            foreach (Arac item in aracBilgileri)
                            {
                                item.AracID = kayıtArac.AracID;
                                db.Aracs.Add(item);
                                db.SaveChanges();
                            }
                        }
                        lstArabalar.Items.Add(a);
                        tran.Complete();

                    }

                    catch (Exception ex)
                    {

                        tran.Dispose();
                    }
                }

            }
            else
            {
                MessageBox.Show("Arac Bilgilerini Doldurun.");
            }
        }

        private void lstArabalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Arac secilenBilgiler = lstArabalar.SelectedItem as Arac;
            txtMarka.Text = secilenBilgiler.Marka;
            txtModel.Text = secilenBilgiler.Model;
            txtRenk.Text = secilenBilgiler.Renk;
            txtVites.Text = secilenBilgiler.VitesTipi;
            txtYıl.Text = secilenBilgiler.Yıl;
            txtKm.Text = secilenBilgiler.KM;
            txtFiyat.Text = secilenBilgiler.Fiyat;

            btnAracGüncelle.Tag = secilenBilgiler.AracID;
            

        }

        private void BtnAracSil_Click(object sender, EventArgs e)
        {
            Arac silinmesiniIstenenData = lstArabalar.SelectedItem as Arac;
            using (MyDbContext db = new MyDbContext())
            {
                if (lstArabalar.SelectedItem !=null)
                {
                    Arac silinenData = db.Aracs.Find(silinmesiniIstenenData.AracID);
                    db.Aracs.Remove(silinenData);
                    if (MessageBox.Show("Müşterinin silinmesinden emin misiniz ?? ", "HATA", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        db.SaveChanges();
                        MessageBox.Show("Kayıt silindi.");
                        AraclariDoldur();
                    }
                    else
                    {
                        MessageBox.Show("Kayıt Silinemedi.");
                    }
                }
                else
                {
                    MessageBox.Show("Müşteri Seçiniz.");
                }
            }
        }

        private void btnAracGüncelle_Click(object sender, EventArgs e)
        {
            int carID = Convert.ToInt32(btnAracGüncelle.Tag);
            using (MyDbContext db = new MyDbContext())
            {
                if (lstArabalar.Items!=null && !string.IsNullOrWhiteSpace(txtMarka.Text))
                {
                    try
                    {
                        Arac dbdekiData = db.Aracs.Where(a => a.AracID == carID).SingleOrDefault();
                        dbdekiData.Model = txtModel.Text;
                        dbdekiData.Marka = txtMarka.Text;
                        dbdekiData.Renk = txtRenk.Text;
                        dbdekiData.VitesTipi = txtVites.Text;
                        dbdekiData.Yıl = txtYıl.Text;
                        dbdekiData.KM = txtKm.Text;
                        dbdekiData.Fiyat = txtFiyat.Text;
                        db.SaveChanges();
                        MessageBox.Show("Güncelleme Yapıldı.");
                        AraclariDoldur();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Güncelleme Yapılamadı. Hata : " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Araba Seçmelisiniz.");
                }
            }
        }

        private void txtAranacakCar_TextChanged(object sender, EventArgs e)
        {
            lstArabalar.Items.Clear();
            List<Arac> araclar = new List<Arac>();
            using (MyDbContext db = new MyDbContext())
            {
                araclar = db.Aracs.OrderBy(a => a.Marka).ToList();
                foreach (Arac arac in araclar)
                {
                    if (arac.Marka.ToLower().Contains(txtMarka.Text.ToLower()))
                    {
                        lstArabalar.Items.Add(arac.Marka);
                    }
                }
            }
        }

        private void txtFiyat_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
