
namespace GaleriEntity.UI
{
    partial class Satışlar
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
            this.btnCikis = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSatilanFiyat = new System.Windows.Forms.TextBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblEposta = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblAD = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblVitesTip = new System.Windows.Forms.Label();
            this.lblRenk = new System.Windows.Forms.Label();
            this.lblYıl = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.lblKM = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblMarka = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSatisYap = new System.Windows.Forms.Button();
            this.müsteriTableAdapter = new GaleriEntity.UI.GaleriDBDataSetTableAdapters.MüsteriTableAdapter();
            this.galeriDBDataSet = new GaleriEntity.UI.GaleriDBDataSet();
            this.satisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.satisTableAdapter = new GaleriEntity.UI.GaleriDBDataSetTableAdapters.SatisTableAdapter();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.galeriDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(483, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Satışlar";
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Red;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCikis.ImageIndex = 0;
            this.btnCikis.Location = new System.Drawing.Point(12, 538);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(89, 39);
            this.btnCikis.TabIndex = 21;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSatilanFiyat);
            this.groupBox1.Controls.Add(this.lblAdres);
            this.groupBox1.Controls.Add(this.lblEposta);
            this.groupBox1.Controls.Add(this.lblTelefon);
            this.groupBox1.Controls.Add(this.lblTC);
            this.groupBox1.Controls.Add(this.lblSoyad);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.lblAD);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Location = new System.Drawing.Point(411, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 444);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri";
            // 
            // txtSatilanFiyat
            // 
            this.txtSatilanFiyat.Location = new System.Drawing.Point(143, 399);
            this.txtSatilanFiyat.Name = "txtSatilanFiyat";
            this.txtSatilanFiyat.Size = new System.Drawing.Size(132, 20);
            this.txtSatilanFiyat.TabIndex = 54;
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(205, 360);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(10, 13);
            this.lblAdres.TabIndex = 53;
            this.lblAdres.Text = "-";
            // 
            // lblEposta
            // 
            this.lblEposta.AutoSize = true;
            this.lblEposta.Location = new System.Drawing.Point(205, 311);
            this.lblEposta.Name = "lblEposta";
            this.lblEposta.Size = new System.Drawing.Size(10, 13);
            this.lblEposta.TabIndex = 52;
            this.lblEposta.Text = "-";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(205, 267);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(10, 13);
            this.lblTelefon.TabIndex = 51;
            this.lblTelefon.Text = "-";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(205, 226);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(10, 13);
            this.lblTC.TabIndex = 50;
            this.lblTC.Text = "-";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(205, 182);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(10, 13);
            this.lblSoyad.TabIndex = 49;
            this.lblSoyad.Text = "-";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(128, 92);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(115, 16);
            this.label17.TabIndex = 42;
            this.label17.Text = "Müşteri Bilgileri";
            // 
            // lblAD
            // 
            this.lblAD.AutoSize = true;
            this.lblAD.Location = new System.Drawing.Point(205, 137);
            this.lblAD.Name = "lblAD";
            this.lblAD.Size = new System.Drawing.Size(10, 13);
            this.lblAD.TabIndex = 48;
            this.lblAD.Text = "-";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(143, 30);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 16);
            this.label16.TabIndex = 41;
            this.label16.Text = "Müşteri";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(70, 58);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(205, 21);
            this.comboBox2.TabIndex = 40;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(15, 403);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(94, 16);
            this.label20.TabIndex = 44;
            this.label20.Text = "Satılan Fiyat";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(82, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "Ad";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(57, 180);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 16);
            this.label11.TabIndex = 14;
            this.label11.Text = "Soyad";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(82, 224);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 16);
            this.label12.TabIndex = 15;
            this.label12.Text = "TC";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(61, 358);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 16);
            this.label13.TabIndex = 16;
            this.label13.Text = "Adres";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(49, 265);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 16);
            this.label14.TabIndex = 17;
            this.label14.Text = "Telefon";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(53, 309);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 16);
            this.label15.TabIndex = 18;
            this.label15.Text = "Eposta";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblVitesTip);
            this.groupBox2.Controls.Add(this.lblRenk);
            this.groupBox2.Controls.Add(this.lblYıl);
            this.groupBox2.Controls.Add(this.lblFiyat);
            this.groupBox2.Controls.Add(this.lblKM);
            this.groupBox2.Controls.Add(this.lblModel);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.lblMarka);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(12, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(311, 444);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Araç Bilgileri";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lblVitesTip
            // 
            this.lblVitesTip.AutoSize = true;
            this.lblVitesTip.Location = new System.Drawing.Point(184, 404);
            this.lblVitesTip.Name = "lblVitesTip";
            this.lblVitesTip.Size = new System.Drawing.Size(10, 13);
            this.lblVitesTip.TabIndex = 47;
            this.lblVitesTip.Text = "-";
            // 
            // lblRenk
            // 
            this.lblRenk.AutoSize = true;
            this.lblRenk.Location = new System.Drawing.Point(184, 365);
            this.lblRenk.Name = "lblRenk";
            this.lblRenk.Size = new System.Drawing.Size(10, 13);
            this.lblRenk.TabIndex = 46;
            this.lblRenk.Text = "-";
            // 
            // lblYıl
            // 
            this.lblYıl.AutoSize = true;
            this.lblYıl.Location = new System.Drawing.Point(184, 319);
            this.lblYıl.Name = "lblYıl";
            this.lblYıl.Size = new System.Drawing.Size(10, 13);
            this.lblYıl.TabIndex = 45;
            this.lblYıl.Text = "-";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(184, 275);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(10, 13);
            this.lblFiyat.TabIndex = 44;
            this.lblFiyat.Text = "-";
            // 
            // lblKM
            // 
            this.lblKM.AutoSize = true;
            this.lblKM.Location = new System.Drawing.Point(184, 226);
            this.lblKM.Name = "lblKM";
            this.lblKM.Size = new System.Drawing.Size(10, 13);
            this.lblKM.TabIndex = 43;
            this.lblKM.Text = "-";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(184, 178);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(10, 13);
            this.lblModel.TabIndex = 42;
            this.lblModel.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(103, 18);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 16);
            this.label9.TabIndex = 39;
            this.label9.Text = "Alınacak Araç";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(110, 80);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(97, 16);
            this.label18.TabIndex = 40;
            this.label18.Text = "Araç Bilgileri";
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Location = new System.Drawing.Point(184, 126);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(10, 13);
            this.lblMarka.TabIndex = 41;
            this.lblMarka.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(57, 124);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "Marka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(57, 176);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Model";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(37, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(235, 21);
            this.comboBox1.TabIndex = 38;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(79, 224);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Km";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(66, 273);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Fiyat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(82, 317);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Yıl";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(64, 363);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "Renk";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(34, 402);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 30;
            this.label7.Text = "Vites Tipi";
            // 
            // btnSatisYap
            // 
            this.btnSatisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatisYap.Location = new System.Drawing.Point(526, 537);
            this.btnSatisYap.Name = "btnSatisYap";
            this.btnSatisYap.Size = new System.Drawing.Size(117, 34);
            this.btnSatisYap.TabIndex = 25;
            this.btnSatisYap.Text = "Satış Yap";
            this.btnSatisYap.UseVisualStyleBackColor = true;
            this.btnSatisYap.Click += new System.EventHandler(this.btnSatisYap_Click);
            // 
            // müsteriTableAdapter
            // 
            this.müsteriTableAdapter.ClearBeforeFill = true;
            // 
            // galeriDBDataSet
            // 
            this.galeriDBDataSet.DataSetName = "GaleriDBDataSet";
            this.galeriDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // satisBindingSource
            // 
            this.satisBindingSource.DataMember = "Satis";
            this.satisBindingSource.DataSource = this.galeriDBDataSet;
            // 
            // satisTableAdapter
            // 
            this.satisTableAdapter.ClearBeforeFill = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(823, 77);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(372, 444);
            this.listView1.TabIndex = 27;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Araç";
            this.columnHeader1.Width = 105;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Müşteri";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Satılan Fiyat";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 130;
            // 
            // Satışlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 583);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnSatisYap);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.label1);
            this.Name = "Satışlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satışlar";
            this.Load += new System.EventHandler(this.Satışlar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.galeriDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satisBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnSatisYap;
        private System.Windows.Forms.Label lblVitesTip;
        private System.Windows.Forms.Label lblRenk;
        private System.Windows.Forms.Label lblYıl;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label lblKM;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblEposta;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAD;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtSatilanFiyat;
        private GaleriDBDataSetTableAdapters.MüsteriTableAdapter müsteriTableAdapter;
        private GaleriDBDataSet galeriDBDataSet;
        private System.Windows.Forms.BindingSource satisBindingSource;
        private GaleriDBDataSetTableAdapters.SatisTableAdapter satisTableAdapter;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}