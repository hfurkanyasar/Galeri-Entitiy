
namespace GaleriEntity.UI
{
    partial class AraçListeleme
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.galeriDBDataSet1 = new GaleriEntity.UI.GaleriDBDataSet1();
            this.aracsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aracsTableAdapter = new GaleriEntity.UI.GaleriDBDataSet1TableAdapters.AracsTableAdapter();
            this.aracIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yılDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.renkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vitesTipiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stoktamiDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fillBy1ToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillBy1ToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galeriDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracsBindingSource)).BeginInit();
            this.fillBy1ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(498, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Araçlar";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.ImageIndex = 0;
            this.button1.Location = new System.Drawing.Point(12, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 39);
            this.button1.TabIndex = 21;
            this.button1.Text = "Çıkış";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aracIDDataGridViewTextBoxColumn,
            this.markaDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.kMDataGridViewTextBoxColumn,
            this.fiyatDataGridViewTextBoxColumn,
            this.yılDataGridViewTextBoxColumn,
            this.renkDataGridViewTextBoxColumn,
            this.vitesTipiDataGridViewTextBoxColumn,
            this.stoktamiDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.aracsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(146, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(845, 193);
            this.dataGridView1.TabIndex = 22;
            // 
            // galeriDBDataSet1
            // 
            this.galeriDBDataSet1.DataSetName = "GaleriDBDataSet1";
            this.galeriDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aracsBindingSource
            // 
            this.aracsBindingSource.DataMember = "Aracs";
            this.aracsBindingSource.DataSource = this.galeriDBDataSet1;
            // 
            // aracsTableAdapter
            // 
            this.aracsTableAdapter.ClearBeforeFill = true;
            // 
            // aracIDDataGridViewTextBoxColumn
            // 
            this.aracIDDataGridViewTextBoxColumn.DataPropertyName = "AracID";
            this.aracIDDataGridViewTextBoxColumn.HeaderText = "AracID";
            this.aracIDDataGridViewTextBoxColumn.Name = "aracIDDataGridViewTextBoxColumn";
            this.aracIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // markaDataGridViewTextBoxColumn
            // 
            this.markaDataGridViewTextBoxColumn.DataPropertyName = "Marka";
            this.markaDataGridViewTextBoxColumn.HeaderText = "Marka";
            this.markaDataGridViewTextBoxColumn.Name = "markaDataGridViewTextBoxColumn";
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            // 
            // kMDataGridViewTextBoxColumn
            // 
            this.kMDataGridViewTextBoxColumn.DataPropertyName = "KM";
            this.kMDataGridViewTextBoxColumn.HeaderText = "KM";
            this.kMDataGridViewTextBoxColumn.Name = "kMDataGridViewTextBoxColumn";
            // 
            // fiyatDataGridViewTextBoxColumn
            // 
            this.fiyatDataGridViewTextBoxColumn.DataPropertyName = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.HeaderText = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.Name = "fiyatDataGridViewTextBoxColumn";
            // 
            // yılDataGridViewTextBoxColumn
            // 
            this.yılDataGridViewTextBoxColumn.DataPropertyName = "Yıl";
            this.yılDataGridViewTextBoxColumn.HeaderText = "Yıl";
            this.yılDataGridViewTextBoxColumn.Name = "yılDataGridViewTextBoxColumn";
            // 
            // renkDataGridViewTextBoxColumn
            // 
            this.renkDataGridViewTextBoxColumn.DataPropertyName = "Renk";
            this.renkDataGridViewTextBoxColumn.HeaderText = "Renk";
            this.renkDataGridViewTextBoxColumn.Name = "renkDataGridViewTextBoxColumn";
            // 
            // vitesTipiDataGridViewTextBoxColumn
            // 
            this.vitesTipiDataGridViewTextBoxColumn.DataPropertyName = "VitesTipi";
            this.vitesTipiDataGridViewTextBoxColumn.HeaderText = "VitesTipi";
            this.vitesTipiDataGridViewTextBoxColumn.Name = "vitesTipiDataGridViewTextBoxColumn";
            // 
            // stoktamiDataGridViewCheckBoxColumn
            // 
            this.stoktamiDataGridViewCheckBoxColumn.DataPropertyName = "Stoktami";
            this.stoktamiDataGridViewCheckBoxColumn.HeaderText = "Stoktami";
            this.stoktamiDataGridViewCheckBoxColumn.IndeterminateValue = "1";
            this.stoktamiDataGridViewCheckBoxColumn.Name = "stoktamiDataGridViewCheckBoxColumn";
            this.stoktamiDataGridViewCheckBoxColumn.Width = 5;
            // 
            // fillBy1ToolStrip
            // 
            this.fillBy1ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillBy1ToolStripButton});
            this.fillBy1ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillBy1ToolStrip.Name = "fillBy1ToolStrip";
            this.fillBy1ToolStrip.Size = new System.Drawing.Size(1160, 25);
            this.fillBy1ToolStrip.TabIndex = 24;
            this.fillBy1ToolStrip.Text = "fillBy1ToolStrip";
            // 
            // fillBy1ToolStripButton
            // 
            this.fillBy1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy1ToolStripButton.Name = "fillBy1ToolStripButton";
            this.fillBy1ToolStripButton.Size = new System.Drawing.Size(88, 22);
            this.fillBy1ToolStripButton.Text = "Araçlarım Stok";
            this.fillBy1ToolStripButton.Click += new System.EventHandler(this.fillBy1ToolStripButton_Click);
            // 
            // AraçListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 471);
            this.Controls.Add(this.fillBy1ToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "AraçListeleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AraçListeleme";
            this.Load += new System.EventHandler(this.AraçListeleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galeriDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracsBindingSource)).EndInit();
            this.fillBy1ToolStrip.ResumeLayout(false);
            this.fillBy1ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private GaleriDBDataSet1 galeriDBDataSet1;
        private System.Windows.Forms.BindingSource aracsBindingSource;
        private GaleriDBDataSet1TableAdapters.AracsTableAdapter aracsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn aracIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yılDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn renkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vitesTipiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn stoktamiDataGridViewCheckBoxColumn;
        private System.Windows.Forms.ToolStrip fillBy1ToolStrip;
        private System.Windows.Forms.ToolStripButton fillBy1ToolStripButton;
    }
}