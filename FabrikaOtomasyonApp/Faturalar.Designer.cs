namespace FabrikaOtomasyonApp
{
    partial class Faturalar
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
            this.dgvFaturalar = new System.Windows.Forms.DataGridView();
            this.faturanoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faturatarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faturatipiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmaadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odemedurumuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dosyayoluDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aciklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eklenmetarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faturalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbFabrikaDataSet4 = new FabrikaOtomasyonApp.dbFabrikaDataSet4();
            this.faturalarTableAdapter = new FabrikaOtomasyonApp.dbFabrikaDataSet4TableAdapters.faturalarTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFaturaNo = new System.Windows.Forms.TextBox();
            this.txtFaturaTipi = new System.Windows.Forms.TextBox();
            this.txtFirmaAdi = new System.Windows.Forms.TextBox();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.txtOdenmeDurumu = new System.Windows.Forms.TextBox();
            this.txtDosyaYolu = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.dtpFaturaTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnFaturaSil = new System.Windows.Forms.Button();
            this.btnExcelAktarma = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaturalar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faturalarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbFabrikaDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFaturalar
            // 
            this.dgvFaturalar.AutoGenerateColumns = false;
            this.dgvFaturalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFaturalar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.faturanoDataGridViewTextBoxColumn,
            this.faturatarihiDataGridViewTextBoxColumn,
            this.faturatipiDataGridViewTextBoxColumn,
            this.firmaadiDataGridViewTextBoxColumn,
            this.tutarDataGridViewTextBoxColumn,
            this.odemedurumuDataGridViewTextBoxColumn,
            this.dosyayoluDataGridViewTextBoxColumn,
            this.aciklamaDataGridViewTextBoxColumn,
            this.eklenmetarihiDataGridViewTextBoxColumn});
            this.dgvFaturalar.DataSource = this.faturalarBindingSource;
            this.dgvFaturalar.Location = new System.Drawing.Point(13, 13);
            this.dgvFaturalar.Name = "dgvFaturalar";
            this.dgvFaturalar.Size = new System.Drawing.Size(943, 668);
            this.dgvFaturalar.TabIndex = 0;
            this.dgvFaturalar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFaturalar_CellClick);
            // 
            // faturanoDataGridViewTextBoxColumn
            // 
            this.faturanoDataGridViewTextBoxColumn.DataPropertyName = "fatura_no";
            this.faturanoDataGridViewTextBoxColumn.HeaderText = "Fatura No";
            this.faturanoDataGridViewTextBoxColumn.Name = "faturanoDataGridViewTextBoxColumn";
            // 
            // faturatarihiDataGridViewTextBoxColumn
            // 
            this.faturatarihiDataGridViewTextBoxColumn.DataPropertyName = "fatura_tarihi";
            this.faturatarihiDataGridViewTextBoxColumn.HeaderText = "Fatura Tarihi";
            this.faturatarihiDataGridViewTextBoxColumn.Name = "faturatarihiDataGridViewTextBoxColumn";
            // 
            // faturatipiDataGridViewTextBoxColumn
            // 
            this.faturatipiDataGridViewTextBoxColumn.DataPropertyName = "fatura_tipi";
            this.faturatipiDataGridViewTextBoxColumn.HeaderText = "Fatura Tipi";
            this.faturatipiDataGridViewTextBoxColumn.Name = "faturatipiDataGridViewTextBoxColumn";
            // 
            // firmaadiDataGridViewTextBoxColumn
            // 
            this.firmaadiDataGridViewTextBoxColumn.DataPropertyName = "firma_adi";
            this.firmaadiDataGridViewTextBoxColumn.HeaderText = "Firma Adı";
            this.firmaadiDataGridViewTextBoxColumn.Name = "firmaadiDataGridViewTextBoxColumn";
            // 
            // tutarDataGridViewTextBoxColumn
            // 
            this.tutarDataGridViewTextBoxColumn.DataPropertyName = "tutar";
            this.tutarDataGridViewTextBoxColumn.HeaderText = "Tutar";
            this.tutarDataGridViewTextBoxColumn.Name = "tutarDataGridViewTextBoxColumn";
            // 
            // odemedurumuDataGridViewTextBoxColumn
            // 
            this.odemedurumuDataGridViewTextBoxColumn.DataPropertyName = "odeme_durumu";
            this.odemedurumuDataGridViewTextBoxColumn.HeaderText = "Ödenme Durumu";
            this.odemedurumuDataGridViewTextBoxColumn.Name = "odemedurumuDataGridViewTextBoxColumn";
            // 
            // dosyayoluDataGridViewTextBoxColumn
            // 
            this.dosyayoluDataGridViewTextBoxColumn.DataPropertyName = "dosya_yolu";
            this.dosyayoluDataGridViewTextBoxColumn.HeaderText = "Dosya Yolu";
            this.dosyayoluDataGridViewTextBoxColumn.Name = "dosyayoluDataGridViewTextBoxColumn";
            // 
            // aciklamaDataGridViewTextBoxColumn
            // 
            this.aciklamaDataGridViewTextBoxColumn.DataPropertyName = "aciklama";
            this.aciklamaDataGridViewTextBoxColumn.HeaderText = "Açıklama";
            this.aciklamaDataGridViewTextBoxColumn.Name = "aciklamaDataGridViewTextBoxColumn";
            // 
            // eklenmetarihiDataGridViewTextBoxColumn
            // 
            this.eklenmetarihiDataGridViewTextBoxColumn.DataPropertyName = "eklenme_tarihi";
            this.eklenmetarihiDataGridViewTextBoxColumn.HeaderText = "Eklenme Tarihi";
            this.eklenmetarihiDataGridViewTextBoxColumn.Name = "eklenmetarihiDataGridViewTextBoxColumn";
            // 
            // faturalarBindingSource
            // 
            this.faturalarBindingSource.DataMember = "faturalar";
            this.faturalarBindingSource.DataSource = this.dbFabrikaDataSet4;
            // 
            // dbFabrikaDataSet4
            // 
            this.dbFabrikaDataSet4.DataSetName = "dbFabrikaDataSet4";
            this.dbFabrikaDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // faturalarTableAdapter
            // 
            this.faturalarTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(1027, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Fatura Tipi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(1012, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Fatura Tarihi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(1032, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Fatura No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(980, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = "Ödenme Durumu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(1068, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Tutar:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(1036, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Firma Adı:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(1039, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 18);
            this.label8.TabIndex = 19;
            this.label8.Text = "Açıklama:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(1021, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 18);
            this.label9.TabIndex = 18;
            this.label9.Text = "Dosya Yolu:";
            // 
            // txtFaturaNo
            // 
            this.txtFaturaNo.Location = new System.Drawing.Point(1127, 51);
            this.txtFaturaNo.Name = "txtFaturaNo";
            this.txtFaturaNo.Size = new System.Drawing.Size(123, 20);
            this.txtFaturaNo.TabIndex = 20;
            // 
            // txtFaturaTipi
            // 
            this.txtFaturaTipi.Location = new System.Drawing.Point(1127, 118);
            this.txtFaturaTipi.Name = "txtFaturaTipi";
            this.txtFaturaTipi.Size = new System.Drawing.Size(123, 20);
            this.txtFaturaTipi.TabIndex = 21;
            // 
            // txtFirmaAdi
            // 
            this.txtFirmaAdi.Location = new System.Drawing.Point(1127, 151);
            this.txtFirmaAdi.Name = "txtFirmaAdi";
            this.txtFirmaAdi.Size = new System.Drawing.Size(123, 20);
            this.txtFirmaAdi.TabIndex = 22;
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(1127, 187);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(123, 20);
            this.txtTutar.TabIndex = 24;
            // 
            // txtOdenmeDurumu
            // 
            this.txtOdenmeDurumu.Location = new System.Drawing.Point(1127, 219);
            this.txtOdenmeDurumu.Name = "txtOdenmeDurumu";
            this.txtOdenmeDurumu.Size = new System.Drawing.Size(123, 20);
            this.txtOdenmeDurumu.TabIndex = 25;
            // 
            // txtDosyaYolu
            // 
            this.txtDosyaYolu.Location = new System.Drawing.Point(1126, 252);
            this.txtDosyaYolu.Multiline = true;
            this.txtDosyaYolu.Name = "txtDosyaYolu";
            this.txtDosyaYolu.Size = new System.Drawing.Size(123, 49);
            this.txtDosyaYolu.TabIndex = 26;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(1126, 320);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(123, 90);
            this.txtAciklama.TabIndex = 27;
            // 
            // dtpFaturaTarihi
            // 
            this.dtpFaturaTarihi.Location = new System.Drawing.Point(1126, 86);
            this.dtpFaturaTarihi.Name = "dtpFaturaTarihi";
            this.dtpFaturaTarihi.Size = new System.Drawing.Size(124, 20);
            this.dtpFaturaTarihi.TabIndex = 28;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(971, 433);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(314, 45);
            this.btnKaydet.TabIndex = 29;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Location = new System.Drawing.Point(971, 636);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(314, 45);
            this.btnTemizle.TabIndex = 30;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnGuncelle.Location = new System.Drawing.Point(971, 485);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(314, 45);
            this.btnGuncelle.TabIndex = 31;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnFaturaSil
            // 
            this.btnFaturaSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFaturaSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnFaturaSil.Location = new System.Drawing.Point(971, 586);
            this.btnFaturaSil.Name = "btnFaturaSil";
            this.btnFaturaSil.Size = new System.Drawing.Size(314, 44);
            this.btnFaturaSil.TabIndex = 32;
            this.btnFaturaSil.Text = "Faturayı Sil";
            this.btnFaturaSil.UseVisualStyleBackColor = true;
            this.btnFaturaSil.Click += new System.EventHandler(this.btnFaturaSil_Click);
            // 
            // btnExcelAktarma
            // 
            this.btnExcelAktarma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcelAktarma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnExcelAktarma.Location = new System.Drawing.Point(971, 536);
            this.btnExcelAktarma.Name = "btnExcelAktarma";
            this.btnExcelAktarma.Size = new System.Drawing.Size(314, 44);
            this.btnExcelAktarma.TabIndex = 33;
            this.btnExcelAktarma.Text = "Excel\'e Aktar";
            this.btnExcelAktarma.UseVisualStyleBackColor = true;
            this.btnExcelAktarma.Click += new System.EventHandler(this.btnExcelAktarma_Click);
            // 
            // Faturalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(1297, 698);
            this.Controls.Add(this.btnExcelAktarma);
            this.Controls.Add(this.btnFaturaSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dtpFaturaTarihi);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtDosyaYolu);
            this.Controls.Add(this.txtOdenmeDurumu);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.txtFirmaAdi);
            this.Controls.Add(this.txtFaturaTipi);
            this.Controls.Add(this.txtFaturaNo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvFaturalar);
            this.Name = "Faturalar";
            this.Text = "Faturalar";
            this.Load += new System.EventHandler(this.Faturalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaturalar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faturalarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbFabrikaDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFaturalar;
        private dbFabrikaDataSet4 dbFabrikaDataSet4;
        private System.Windows.Forms.BindingSource faturalarBindingSource;
        private dbFabrikaDataSet4TableAdapters.faturalarTableAdapter faturalarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn faturanoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faturatarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faturatipiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmaadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odemedurumuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dosyayoluDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aciklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eklenmetarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFaturaNo;
        private System.Windows.Forms.TextBox txtFaturaTipi;
        private System.Windows.Forms.TextBox txtFirmaAdi;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.TextBox txtOdenmeDurumu;
        private System.Windows.Forms.TextBox txtDosyaYolu;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.DateTimePicker dtpFaturaTarihi;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnFaturaSil;
        private System.Windows.Forms.Button btnExcelAktarma;
    }
}