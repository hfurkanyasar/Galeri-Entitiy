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
    public partial class AraçListeleme : Form
    {
        public AraçListeleme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            İslemler frm = new İslemler();
            frm.Show();
            this.Hide();
        }

        private void AraçListeleme_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'galeriDBDataSet1.Aracs' table. You can move, or remove it, as needed.
            this.aracsTableAdapter.Fill(this.galeriDBDataSet1.Aracs);
            

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.aracsTableAdapter.FillBy(this.galeriDBDataSet1.Aracs);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.aracsTableAdapter.FillBy1(this.galeriDBDataSet1.Aracs);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
