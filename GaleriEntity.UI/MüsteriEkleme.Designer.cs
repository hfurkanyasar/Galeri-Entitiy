
namespace GaleriEntity.UI
{
    partial class MüsteriEkleme
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMüsAd = new System.Windows.Forms.TextBox();
            this.txtMüsSoyad = new System.Windows.Forms.TextBox();
            this.mskMüsTc = new System.Windows.Forms.MaskedTextBox();
            this.mskMüsTel = new System.Windows.Forms.MaskedTextBox();
            this.txtMüsEposta = new System.Windows.Forms.TextBox();
            this.txtMüsAdres = new System.Windows.Forms.TextBox();
            this.btnMüsEkle = new System.Windows.Forms.Button();
            this.btnMüsGüncelleme = new System.Windows.Forms.Button();
            this.BtnMüsSil = new System.Windows.Forms.Button();
            this.lstMüsteriler = new System.Windows.Forms.ListBox();
            this.grpBilgiİslem = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAranacakMüs = new System.Windows.Forms.TextBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.grpBilgiİslem.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "TC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Eposta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Telefon";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 21);
            this.label7.TabIndex = 4;
            this.label7.Text = "Adres";
            // 
            // txtMüsAd
            // 
            this.txtMüsAd.Location = new System.Drawing.Point(136, 37);
            this.txtMüsAd.Name = "txtMüsAd";
            this.txtMüsAd.Size = new System.Drawing.Size(171, 20);
            this.txtMüsAd.TabIndex = 7;
            // 
            // txtMüsSoyad
            // 
            this.txtMüsSoyad.Location = new System.Drawing.Point(136, 79);
            this.txtMüsSoyad.Name = "txtMüsSoyad";
            this.txtMüsSoyad.Size = new System.Drawing.Size(171, 20);
            this.txtMüsSoyad.TabIndex = 8;
            // 
            // mskMüsTc
            // 
            this.mskMüsTc.Location = new System.Drawing.Point(136, 127);
            this.mskMüsTc.Mask = "00000000000";
            this.mskMüsTc.Name = "mskMüsTc";
            this.mskMüsTc.Size = new System.Drawing.Size(171, 20);
            this.mskMüsTc.TabIndex = 9;
            this.mskMüsTc.ValidatingType = typeof(int);
            // 
            // mskMüsTel
            // 
            this.mskMüsTel.Location = new System.Drawing.Point(136, 168);
            this.mskMüsTel.Mask = "(999) 000-0000";
            this.mskMüsTel.Name = "mskMüsTel";
            this.mskMüsTel.Size = new System.Drawing.Size(171, 20);
            this.mskMüsTel.TabIndex = 10;
            // 
            // txtMüsEposta
            // 
            this.txtMüsEposta.Location = new System.Drawing.Point(136, 215);
            this.txtMüsEposta.Name = "txtMüsEposta";
            this.txtMüsEposta.Size = new System.Drawing.Size(171, 20);
            this.txtMüsEposta.TabIndex = 11;
            // 
            // txtMüsAdres
            // 
            this.txtMüsAdres.Location = new System.Drawing.Point(136, 263);
            this.txtMüsAdres.Name = "txtMüsAdres";
            this.txtMüsAdres.Size = new System.Drawing.Size(171, 20);
            this.txtMüsAdres.TabIndex = 12;
            // 
            // btnMüsEkle
            // 
            this.btnMüsEkle.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMüsEkle.Location = new System.Drawing.Point(365, 139);
            this.btnMüsEkle.Name = "btnMüsEkle";
            this.btnMüsEkle.Size = new System.Drawing.Size(75, 50);
            this.btnMüsEkle.TabIndex = 13;
            this.btnMüsEkle.Text = "Müşteri Ekle";
            this.btnMüsEkle.UseVisualStyleBackColor = true;
            this.btnMüsEkle.Click += new System.EventHandler(this.btnMüsEkle_Click);
            // 
            // btnMüsGüncelleme
            // 
            this.btnMüsGüncelleme.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMüsGüncelleme.Location = new System.Drawing.Point(365, 51);
            this.btnMüsGüncelleme.Name = "btnMüsGüncelleme";
            this.btnMüsGüncelleme.Size = new System.Drawing.Size(75, 48);
            this.btnMüsGüncelleme.TabIndex = 14;
            this.btnMüsGüncelleme.Text = "Bilgi Güncelleme";
            this.btnMüsGüncelleme.UseVisualStyleBackColor = true;
            this.btnMüsGüncelleme.Click += new System.EventHandler(this.btnMüsGüncelleme_Click);
            // 
            // BtnMüsSil
            // 
            this.BtnMüsSil.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnMüsSil.Location = new System.Drawing.Point(365, 232);
            this.BtnMüsSil.Name = "BtnMüsSil";
            this.BtnMüsSil.Size = new System.Drawing.Size(75, 51);
            this.BtnMüsSil.TabIndex = 15;
            this.BtnMüsSil.Text = "Müşteri Sil";
            this.BtnMüsSil.UseVisualStyleBackColor = true;
            this.BtnMüsSil.Click += new System.EventHandler(this.BtnMüsSil_Click);
            // 
            // lstMüsteriler
            // 
            this.lstMüsteriler.Dock = System.Windows.Forms.DockStyle.Right;
            this.lstMüsteriler.FormattingEnabled = true;
            this.lstMüsteriler.Location = new System.Drawing.Point(514, 0);
            this.lstMüsteriler.Name = "lstMüsteriler";
            this.lstMüsteriler.Size = new System.Drawing.Size(306, 576);
            this.lstMüsteriler.TabIndex = 16;
            this.lstMüsteriler.SelectedIndexChanged += new System.EventHandler(this.lstMüsteriler_SelectedIndexChanged);
            // 
            // grpBilgiİslem
            // 
            this.grpBilgiİslem.Controls.Add(this.label1);
            this.grpBilgiİslem.Controls.Add(this.label2);
            this.grpBilgiİslem.Controls.Add(this.BtnMüsSil);
            this.grpBilgiİslem.Controls.Add(this.label4);
            this.grpBilgiİslem.Controls.Add(this.btnMüsGüncelleme);
            this.grpBilgiİslem.Controls.Add(this.label7);
            this.grpBilgiİslem.Controls.Add(this.btnMüsEkle);
            this.grpBilgiİslem.Controls.Add(this.label6);
            this.grpBilgiİslem.Controls.Add(this.txtMüsAdres);
            this.grpBilgiİslem.Controls.Add(this.label5);
            this.grpBilgiİslem.Controls.Add(this.txtMüsEposta);
            this.grpBilgiİslem.Controls.Add(this.txtMüsAd);
            this.grpBilgiİslem.Controls.Add(this.mskMüsTel);
            this.grpBilgiİslem.Controls.Add(this.txtMüsSoyad);
            this.grpBilgiİslem.Controls.Add(this.mskMüsTc);
            this.grpBilgiİslem.Location = new System.Drawing.Point(12, 12);
            this.grpBilgiİslem.Name = "grpBilgiİslem";
            this.grpBilgiİslem.Size = new System.Drawing.Size(477, 314);
            this.grpBilgiİslem.TabIndex = 17;
            this.grpBilgiİslem.TabStop = false;
            this.grpBilgiİslem.Text = "Bilgi İşlem";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(99, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 37);
            this.label3.TabIndex = 18;
            this.label3.Text = "Aranacak Müşteri";
            // 
            // txtAranacakMüs
            // 
            this.txtAranacakMüs.Location = new System.Drawing.Point(106, 440);
            this.txtAranacakMüs.Name = "txtAranacakMüs";
            this.txtAranacakMüs.Size = new System.Drawing.Size(260, 20);
            this.txtAranacakMüs.TabIndex = 19;
            this.txtAranacakMüs.TextChanged += new System.EventHandler(this.txtAranacakMüs_TextChanged);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Red;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCikis.ImageIndex = 0;
            this.btnCikis.Location = new System.Drawing.Point(12, 516);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(89, 39);
            this.btnCikis.TabIndex = 20;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // MüsteriEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 576);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.txtAranacakMüs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grpBilgiİslem);
            this.Controls.Add(this.lstMüsteriler);
            this.Name = "MüsteriEkleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MüsteriEkleme";
            this.Load += new System.EventHandler(this.MüsteriEkleme_Load);
            this.grpBilgiİslem.ResumeLayout(false);
            this.grpBilgiİslem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMüsAd;
        private System.Windows.Forms.TextBox txtMüsSoyad;
        private System.Windows.Forms.MaskedTextBox mskMüsTc;
        private System.Windows.Forms.MaskedTextBox mskMüsTel;
        private System.Windows.Forms.TextBox txtMüsEposta;
        private System.Windows.Forms.TextBox txtMüsAdres;
        private System.Windows.Forms.Button btnMüsEkle;
        private System.Windows.Forms.Button btnMüsGüncelleme;
        private System.Windows.Forms.Button BtnMüsSil;
        private System.Windows.Forms.ListBox lstMüsteriler;
        private System.Windows.Forms.GroupBox grpBilgiİslem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAranacakMüs;
        private System.Windows.Forms.Button btnCikis;
    }
}