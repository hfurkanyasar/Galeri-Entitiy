using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaleriEntity.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtKullanıcıAdi_Click(object sender, EventArgs e)
        {
            txtKullanıcıAdi.Text = "";
        }

        private void txtSifre_Click(object sender, EventArgs e)

        {
            txtSifre.UseSystemPasswordChar = true;
            txtSifre.Text = "";
            txtSifre.UseSystemPasswordChar = true;
        }
        int hak = 3;
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (txtKullanıcıAdi.Text == "" || txtSifre.Text == "")
            {
                MessageBox.Show("Kullanıcı adı ve/veya şifre boş geçilemez.", "Uyarı");
            }
            else
            {
                if (txtKullanıcıAdi.Text == "Hızır" && txtSifre.Text == "123" || txtKullanıcıAdi.Text == "Admin" && txtSifre.Text == "456")
                {
                    MessageBox.Show("Kullanıcı Adınız Doğru Giriş başarılı.");
                    İslemler frm = new İslemler();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    hak--;
                    MessageBox.Show("Kullanıcı adı ve/veya şifre yanlış.Kalan Hakkınız.=" + hak, "Uyarı2");
                    if (hak == 0)
                    {
                        MessageBox.Show("Uygulama kapanıyor.");
                        Application.Exit();
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
