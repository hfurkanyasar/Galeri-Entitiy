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
    public partial class MüsteriListeleme : Form
    {
        public MüsteriListeleme()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            İslemler frm = new İslemler();
            frm.Show();
            this.Hide();
        }

        private void MüsteriListeleme_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'galeriDBDataSet.Müsteri' table. You can move, or remove it, as needed.
            this.müsteriTableAdapter.Fill(this.galeriDBDataSet.Müsteri);

        }
    }
}
