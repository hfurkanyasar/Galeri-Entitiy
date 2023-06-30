using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Transactions;
using System.Windows.Forms;
using Galeri.Entitiy.Core.Context;
using Galeri.Entitiy.Core.Entities;


namespace GaleriEntity.UI
{
    public partial class MüsteriEkleme : Form
    {
        public MüsteriEkleme()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            İslemler frm = new İslemler();
            frm.Show();
            this.Hide();
        }

        private void MüsteriEkleme_Load(object sender, EventArgs e)
        {
            MüsterileriDoldur();
        }

        public List<Müsteri> MüsterileriDoldur()
        {
            lstMüsteriler.Items.Clear();
            MyDbContext db = new MyDbContext();
            List<Müsteri> gelenliste = db.Müsteris.ToList();
            foreach (var item in gelenliste)
            {
                lstMüsteriler.Items.Add(item);
            }
            return gelenliste;
        }
        List<Müsteri> müsteriBilgileri = new List<Müsteri>();

        private void btnMüsEkle_Click(object sender, EventArgs e)
        {
            Müsteri m = new Müsteri();
            m.AD = txtMüsAd.Text;
            m.Soyad = txtMüsSoyad.Text;
            m.TC = mskMüsTc.Text;
            m.Telefon = mskMüsTel.Text;
            m.Eposta = txtMüsEposta.Text;
            m.Adres = txtMüsAdres.Text;

            if (!string.IsNullOrWhiteSpace(txtMüsAd.Text) && !string.IsNullOrWhiteSpace(txtMüsSoyad.Text) && !string.IsNullOrWhiteSpace(txtMüsEposta.Text) && !string.IsNullOrWhiteSpace(txtMüsAdres.Text) && !string.IsNullOrWhiteSpace(mskMüsTel.Text) && !string.IsNullOrWhiteSpace(mskMüsTel.Text))
            {
                using (TransactionScope tran = new TransactionScope())
                {
                    try
                    {
                        using (MyDbContext db = new MyDbContext())
                        {

                            Müsteri kayıtMüsteri = db.Müsteris.Add(m);
                            db.SaveChanges();
                            foreach (Müsteri item in müsteriBilgileri)
                            {
                                item.MüsteriID = kayıtMüsteri.MüsteriID;
                                db.Müsteris.Add(item);
                                db.SaveChanges();
                            }

                        }
                        lstMüsteriler.Items.Add(m);
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
                MessageBox.Show("Lütfen müşteri eklemek için bütün bilgileri doldurun. ");
            }
        }

        private void lstMüsteriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            Müsteri secilenBilgiler = lstMüsteriler.SelectedItem as Müsteri;
            txtMüsAd.Text = secilenBilgiler.AD;
            txtMüsSoyad.Text = secilenBilgiler.Soyad;
            txtMüsEposta.Text = secilenBilgiler.Eposta;
            txtMüsAdres.Text = secilenBilgiler.Adres;
            mskMüsTc.Text = secilenBilgiler.TC;
            mskMüsTel.Text = secilenBilgiler.Telefon;

            btnMüsGüncelleme.Tag = secilenBilgiler.MüsteriID;
        }

        private void BtnMüsSil_Click(object sender, EventArgs e)
        {
            Müsteri silinmesiniİstenenData = lstMüsteriler.SelectedItem as Müsteri;
            using (MyDbContext db = new MyDbContext())
            {
                if (lstMüsteriler.SelectedItem != null)
                {
                    Müsteri silinenData = db.Müsteris.Find(silinmesiniİstenenData.MüsteriID);
                    db.Müsteris.Remove(silinenData);
                    if (MessageBox.Show("Müşterinin silinmesinden emin misiniz ?? ", "HATA", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        db.SaveChanges();
                        MessageBox.Show("Kayıt Silindi");
                        MüsterileriDoldur();
                    }
                    else
                    {
                        MessageBox.Show("Kayıt Silinemedi");
                    }
                }
                else
                {
                    MessageBox.Show("Müşteri Seçiniz.");
                }

            }

        }

        private void btnMüsGüncelleme_Click(object sender, EventArgs e)
        {
            int müsID = Convert.ToInt32(btnMüsGüncelleme.Tag);
            using (MyDbContext db = new MyDbContext())
            {

                if (lstMüsteriler.Items!=null)
                {
                    try
                    {
                        Müsteri dbdekiData = db.Müsteris.Where(a => a.MüsteriID == müsID).SingleOrDefault();
                        dbdekiData.AD = txtMüsAd.Text;
                        dbdekiData.Soyad = txtMüsSoyad.Text;
                        dbdekiData.Adres = txtMüsAdres.Text;
                        dbdekiData.Eposta = txtMüsEposta.Text;
                        dbdekiData.TC = mskMüsTc.Text;
                        dbdekiData.Telefon = mskMüsTel.Text;
                        db.SaveChanges();
                        MessageBox.Show("Güncelleme Yapıldı.");
                        MüsterileriDoldur();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Güncelleme Yapılamadı. Hata : " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Müşteri Seçmelisiniz");
                }

            }
        }

        private void txtAranacakMüs_TextChanged(object sender, EventArgs e)
        {
            lstMüsteriler.Items.Clear();
            List<Müsteri> müsteriler = new List<Müsteri>();
            using (MyDbContext db = new MyDbContext())
            {
                müsteriler = db.Müsteris.OrderBy(a => a.AD).ToList();
                foreach (Müsteri müsteri in müsteriler)
                {
                    if (müsteri.AD.ToLower().Contains(txtAranacakMüs.Text.ToLower()))
                    {
                        lstMüsteriler.Items.Add(müsteri.AD);
                    }
                }
            }

        }
    }
}
