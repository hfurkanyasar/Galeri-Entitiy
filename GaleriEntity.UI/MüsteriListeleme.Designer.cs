
namespace GaleriEntity.UI
{
    partial class MüsteriListeleme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.müsteriIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.epostaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.müsteriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.galeriDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.galeriDBDataSet = new GaleriEntity.UI.GaleriDBDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.müsteriTableAdapter = new GaleriEntity.UI.GaleriDBDataSetTableAdapters.MüsteriTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.müsteriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galeriDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galeriDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.müsteriIDDataGridViewTextBoxColumn,
            this.aDDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.tCDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.epostaDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.müsteriBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(33, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(746, 341);
            this.dataGridView1.TabIndex = 0;
            // 
            // müsteriIDDataGridViewTextBoxColumn
            // 
            this.müsteriIDDataGridViewTextBoxColumn.DataPropertyName = "MüsteriID";
            this.müsteriIDDataGridViewTextBoxColumn.HeaderText = "MüsteriID";
            this.müsteriIDDataGridViewTextBoxColumn.Name = "müsteriIDDataGridViewTextBoxColumn";
            this.müsteriIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aDDataGridViewTextBoxColumn
            // 
            this.aDDataGridViewTextBoxColumn.DataPropertyName = "AD";
            this.aDDataGridViewTextBoxColumn.HeaderText = "AD";
            this.aDDataGridViewTextBoxColumn.Name = "aDDataGridViewTextBoxColumn";
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "Soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            // 
            // tCDataGridViewTextBoxColumn
            // 
            this.tCDataGridViewTextBoxColumn.DataPropertyName = "TC";
            this.tCDataGridViewTextBoxColumn.HeaderText = "TC";
            this.tCDataGridViewTextBoxColumn.Name = "tCDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // epostaDataGridViewTextBoxColumn
            // 
            this.epostaDataGridViewTextBoxColumn.DataPropertyName = "Eposta";
            this.epostaDataGridViewTextBoxColumn.HeaderText = "Eposta";
            this.epostaDataGridViewTextBoxColumn.Name = "epostaDataGridViewTextBoxColumn";
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "Adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            // 
            // müsteriBindingSource
            // 
            this.müsteriBindingSource.DataMember = "Müsteri";
            this.müsteriBindingSource.DataSource = this.galeriDBDataSetBindingSource;
            // 
            // galeriDBDataSetBindingSource
            // 
            this.galeriDBDataSetBindingSource.DataSource = this.galeriDBDataSet;
            this.galeriDBDataSetBindingSource.Position = 0;
            // 
            // galeriDBDataSet
            // 
            this.galeriDBDataSet.DataSetName = "GaleriDBDataSet";
            this.galeriDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(303, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Müşteriler";
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Red;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCikis.ImageIndex = 0;
            this.btnCikis.Location = new System.Drawing.Point(12, 447);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(89, 39);
            this.btnCikis.TabIndex = 22;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // müsteriTableAdapter
            // 
            this.müsteriTableAdapter.ClearBeforeFill = true;
            // 
            // MüsteriListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 491);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MüsteriListeleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MüsteriListeleme";
            this.Load += new System.EventHandler(this.MüsteriListeleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.müsteriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galeriDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galeriDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.BindingSource galeriDBDataSetBindingSource;
        private GaleriDBDataSet galeriDBDataSet;
        private System.Windows.Forms.BindingSource müsteriBindingSource;
        private GaleriDBDataSetTableAdapters.MüsteriTableAdapter müsteriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn müsteriIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn epostaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
    }
}