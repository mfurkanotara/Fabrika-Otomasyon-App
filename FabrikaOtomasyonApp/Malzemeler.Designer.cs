namespace FabrikaOtomasyonApp
{
    partial class Malzemeler
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
            this.dgvMalzemeler = new System.Windows.Forms.DataGridView();
            this.malzemeKoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malzemeAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malzemeTipiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tedarikciAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tedarikTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bulunduguRafDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aciklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malzemelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbFabrikaDataSet = new FabrikaOtomasyonApp.dbFabrikaDataSet();
            this.malzemelerTableAdapter = new FabrikaOtomasyonApp.dbFabrikaDataSetTableAdapters.malzemelerTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMalzemeKodu = new System.Windows.Forms.TextBox();
            this.txtMalzemeAdi = new System.Windows.Forms.TextBox();
            this.txtMalzemeTipi = new System.Windows.Forms.TextBox();
            this.txtBirim = new System.Windows.Forms.TextBox();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.txtTedarikciAdi = new System.Windows.Forms.TextBox();
            this.txtBulunduguRaf = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.dtpTedarikTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMalzemeler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.malzemelerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbFabrikaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMalzemeler
            // 
            this.dgvMalzemeler.AutoGenerateColumns = false;
            this.dgvMalzemeler.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvMalzemeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMalzemeler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.malzemeKoduDataGridViewTextBoxColumn,
            this.malzemeAdiDataGridViewTextBoxColumn,
            this.malzemeTipiDataGridViewTextBoxColumn,
            this.birimDataGridViewTextBoxColumn,
            this.adetDataGridViewTextBoxColumn,
            this.tedarikciAdiDataGridViewTextBoxColumn,
            this.tedarikTarihiDataGridViewTextBoxColumn,
            this.bulunduguRafDataGridViewTextBoxColumn,
            this.aciklamaDataGridViewTextBoxColumn});
            this.dgvMalzemeler.DataSource = this.malzemelerBindingSource;
            this.dgvMalzemeler.Location = new System.Drawing.Point(13, 13);
            this.dgvMalzemeler.Name = "dgvMalzemeler";
            this.dgvMalzemeler.Size = new System.Drawing.Size(943, 630);
            this.dgvMalzemeler.TabIndex = 0;
            this.dgvMalzemeler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMalzemeler_CellClick);
            // 
            // malzemeKoduDataGridViewTextBoxColumn
            // 
            this.malzemeKoduDataGridViewTextBoxColumn.DataPropertyName = "malzemeKodu";
            this.malzemeKoduDataGridViewTextBoxColumn.HeaderText = "Malzeme Kodu";
            this.malzemeKoduDataGridViewTextBoxColumn.Name = "malzemeKoduDataGridViewTextBoxColumn";
            // 
            // malzemeAdiDataGridViewTextBoxColumn
            // 
            this.malzemeAdiDataGridViewTextBoxColumn.DataPropertyName = "malzemeAdi";
            this.malzemeAdiDataGridViewTextBoxColumn.HeaderText = "Malzeme Adı";
            this.malzemeAdiDataGridViewTextBoxColumn.Name = "malzemeAdiDataGridViewTextBoxColumn";
            // 
            // malzemeTipiDataGridViewTextBoxColumn
            // 
            this.malzemeTipiDataGridViewTextBoxColumn.DataPropertyName = "malzemeTipi";
            this.malzemeTipiDataGridViewTextBoxColumn.HeaderText = "Malzeme Tipi";
            this.malzemeTipiDataGridViewTextBoxColumn.Name = "malzemeTipiDataGridViewTextBoxColumn";
            // 
            // birimDataGridViewTextBoxColumn
            // 
            this.birimDataGridViewTextBoxColumn.DataPropertyName = "birim";
            this.birimDataGridViewTextBoxColumn.HeaderText = "Birim";
            this.birimDataGridViewTextBoxColumn.Name = "birimDataGridViewTextBoxColumn";
            // 
            // adetDataGridViewTextBoxColumn
            // 
            this.adetDataGridViewTextBoxColumn.DataPropertyName = "adet";
            this.adetDataGridViewTextBoxColumn.HeaderText = "Adet";
            this.adetDataGridViewTextBoxColumn.Name = "adetDataGridViewTextBoxColumn";
            // 
            // tedarikciAdiDataGridViewTextBoxColumn
            // 
            this.tedarikciAdiDataGridViewTextBoxColumn.DataPropertyName = "tedarikciAdi";
            this.tedarikciAdiDataGridViewTextBoxColumn.HeaderText = "Tedarikçi Adı";
            this.tedarikciAdiDataGridViewTextBoxColumn.Name = "tedarikciAdiDataGridViewTextBoxColumn";
            // 
            // tedarikTarihiDataGridViewTextBoxColumn
            // 
            this.tedarikTarihiDataGridViewTextBoxColumn.DataPropertyName = "tedarikTarihi";
            this.tedarikTarihiDataGridViewTextBoxColumn.HeaderText = "Tedarik Tarihi";
            this.tedarikTarihiDataGridViewTextBoxColumn.Name = "tedarikTarihiDataGridViewTextBoxColumn";
            // 
            // bulunduguRafDataGridViewTextBoxColumn
            // 
            this.bulunduguRafDataGridViewTextBoxColumn.DataPropertyName = "bulunduguRaf";
            this.bulunduguRafDataGridViewTextBoxColumn.HeaderText = "Bulunduğu Raf";
            this.bulunduguRafDataGridViewTextBoxColumn.Name = "bulunduguRafDataGridViewTextBoxColumn";
            // 
            // aciklamaDataGridViewTextBoxColumn
            // 
            this.aciklamaDataGridViewTextBoxColumn.DataPropertyName = "aciklama";
            this.aciklamaDataGridViewTextBoxColumn.HeaderText = "Açıklama";
            this.aciklamaDataGridViewTextBoxColumn.Name = "aciklamaDataGridViewTextBoxColumn";
            // 
            // malzemelerBindingSource
            // 
            this.malzemelerBindingSource.DataMember = "malzemeler";
            this.malzemelerBindingSource.DataSource = this.dbFabrikaDataSet;
            // 
            // dbFabrikaDataSet
            // 
            this.dbFabrikaDataSet.DataSetName = "dbFabrikaDataSet";
            this.dbFabrikaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // malzemelerTableAdapter
            // 
            this.malzemelerTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(979, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Malzeme Kodu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(979, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Birim:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(979, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Malzeme Tipi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(979, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Bulunduğu Raf:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(979, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tedarik Tarihi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(979, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tedarikçi Adı:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(979, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 21);
            this.label8.TabIndex = 5;
            this.label8.Text = "Adet:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(979, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Malzeme Adı:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(979, 348);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 21);
            this.label9.TabIndex = 9;
            this.label9.Text = "Açıklama:";
            // 
            // txtMalzemeKodu
            // 
            this.txtMalzemeKodu.Location = new System.Drawing.Point(1114, 66);
            this.txtMalzemeKodu.Name = "txtMalzemeKodu";
            this.txtMalzemeKodu.Size = new System.Drawing.Size(175, 20);
            this.txtMalzemeKodu.TabIndex = 10;
            // 
            // txtMalzemeAdi
            // 
            this.txtMalzemeAdi.Location = new System.Drawing.Point(1114, 102);
            this.txtMalzemeAdi.MaxLength = 70;
            this.txtMalzemeAdi.Name = "txtMalzemeAdi";
            this.txtMalzemeAdi.Size = new System.Drawing.Size(175, 20);
            this.txtMalzemeAdi.TabIndex = 11;
            // 
            // txtMalzemeTipi
            // 
            this.txtMalzemeTipi.Location = new System.Drawing.Point(1114, 137);
            this.txtMalzemeTipi.MaxLength = 50;
            this.txtMalzemeTipi.Name = "txtMalzemeTipi";
            this.txtMalzemeTipi.Size = new System.Drawing.Size(175, 20);
            this.txtMalzemeTipi.TabIndex = 12;
            // 
            // txtBirim
            // 
            this.txtBirim.Location = new System.Drawing.Point(1114, 172);
            this.txtBirim.MaxLength = 30;
            this.txtBirim.Name = "txtBirim";
            this.txtBirim.Size = new System.Drawing.Size(175, 20);
            this.txtBirim.TabIndex = 13;
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(1114, 208);
            this.txtAdet.MaxLength = 70;
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(175, 20);
            this.txtAdet.TabIndex = 14;
            // 
            // txtTedarikciAdi
            // 
            this.txtTedarikciAdi.Location = new System.Drawing.Point(1114, 244);
            this.txtTedarikciAdi.MaxLength = 120;
            this.txtTedarikciAdi.Name = "txtTedarikciAdi";
            this.txtTedarikciAdi.Size = new System.Drawing.Size(175, 20);
            this.txtTedarikciAdi.TabIndex = 15;
            // 
            // txtBulunduguRaf
            // 
            this.txtBulunduguRaf.Location = new System.Drawing.Point(1114, 314);
            this.txtBulunduguRaf.MaxLength = 20;
            this.txtBulunduguRaf.Name = "txtBulunduguRaf";
            this.txtBulunduguRaf.Size = new System.Drawing.Size(175, 20);
            this.txtBulunduguRaf.TabIndex = 17;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(1114, 348);
            this.txtAciklama.MaxLength = 500;
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(175, 90);
            this.txtAciklama.TabIndex = 18;
            // 
            // dtpTedarikTarihi
            // 
            this.dtpTedarikTarihi.Location = new System.Drawing.Point(1114, 279);
            this.dtpTedarikTarihi.Name = "dtpTedarikTarihi";
            this.dtpTedarikTarihi.Size = new System.Drawing.Size(175, 20);
            this.dtpTedarikTarihi.TabIndex = 19;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.Location = new System.Drawing.Point(983, 462);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(306, 41);
            this.btnKaydet.TabIndex = 20;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnTemizle.Location = new System.Drawing.Point(983, 602);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(306, 41);
            this.btnTemizle.TabIndex = 21;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSil.Location = new System.Drawing.Point(983, 509);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(306, 41);
            this.btnSil.TabIndex = 22;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnGuncelle.Location = new System.Drawing.Point(983, 556);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(306, 40);
            this.btnGuncelle.TabIndex = 23;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // Malzemeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1301, 660);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dtpTedarikTarihi);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtBulunduguRaf);
            this.Controls.Add(this.txtTedarikciAdi);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.txtBirim);
            this.Controls.Add(this.txtMalzemeTipi);
            this.Controls.Add(this.txtMalzemeAdi);
            this.Controls.Add(this.txtMalzemeKodu);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMalzemeler);
            this.MaximizeBox = false;
            this.Name = "Malzemeler";
            this.Text = "Malzemeler";
            this.Load += new System.EventHandler(this.Malzemeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMalzemeler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.malzemelerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbFabrikaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMalzemeler;
        private dbFabrikaDataSet dbFabrikaDataSet;
        private System.Windows.Forms.BindingSource malzemelerBindingSource;
        private dbFabrikaDataSetTableAdapters.malzemelerTableAdapter malzemelerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn malzemeKoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn malzemeAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn malzemeTipiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tedarikciAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tedarikTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bulunduguRafDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aciklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMalzemeKodu;
        private System.Windows.Forms.TextBox txtMalzemeAdi;
        private System.Windows.Forms.TextBox txtMalzemeTipi;
        private System.Windows.Forms.TextBox txtBirim;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.TextBox txtTedarikciAdi;
        private System.Windows.Forms.TextBox txtBulunduguRaf;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.DateTimePicker dtpTedarikTarihi;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
    }
}