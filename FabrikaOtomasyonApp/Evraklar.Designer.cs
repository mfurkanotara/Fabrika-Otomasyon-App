namespace FabrikaOtomasyonApp
{
    partial class Evraklar
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
            this.dgvEvraklar = new System.Windows.Forms.DataGridView();
            this.evrakIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evrakAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evrakTuruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dosyaYoluDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aciklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evraklarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbFabrikaDataSet2 = new FabrikaOtomasyonApp.dbFabrikaDataSet2();
            this.evraklarTableAdapter = new FabrikaOtomasyonApp.dbFabrikaDataSet2TableAdapters.evraklarTableAdapter();
            this.txtEvrakAdi = new System.Windows.Forms.TextBox();
            this.txtEvrakTuru = new System.Windows.Forms.TextBox();
            this.txtBirim = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtDosyaYolu = new System.Windows.Forms.TextBox();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvraklar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evraklarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbFabrikaDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEvraklar
            // 
            this.dgvEvraklar.AutoGenerateColumns = false;
            this.dgvEvraklar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvraklar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.evrakIdDataGridViewTextBoxColumn,
            this.evrakAdiDataGridViewTextBoxColumn,
            this.evrakTuruDataGridViewTextBoxColumn,
            this.birimDataGridViewTextBoxColumn,
            this.tarihDataGridViewTextBoxColumn,
            this.dosyaYoluDataGridViewTextBoxColumn,
            this.aciklamaDataGridViewTextBoxColumn});
            this.dgvEvraklar.DataSource = this.evraklarBindingSource;
            this.dgvEvraklar.Location = new System.Drawing.Point(13, 13);
            this.dgvEvraklar.Name = "dgvEvraklar";
            this.dgvEvraklar.Size = new System.Drawing.Size(743, 578);
            this.dgvEvraklar.TabIndex = 0;
            // 
            // evrakIdDataGridViewTextBoxColumn
            // 
            this.evrakIdDataGridViewTextBoxColumn.DataPropertyName = "evrakId";
            this.evrakIdDataGridViewTextBoxColumn.HeaderText = "Evrak ID";
            this.evrakIdDataGridViewTextBoxColumn.Name = "evrakIdDataGridViewTextBoxColumn";
            this.evrakIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // evrakAdiDataGridViewTextBoxColumn
            // 
            this.evrakAdiDataGridViewTextBoxColumn.DataPropertyName = "evrakAdi";
            this.evrakAdiDataGridViewTextBoxColumn.HeaderText = "Evrak Adı";
            this.evrakAdiDataGridViewTextBoxColumn.Name = "evrakAdiDataGridViewTextBoxColumn";
            // 
            // evrakTuruDataGridViewTextBoxColumn
            // 
            this.evrakTuruDataGridViewTextBoxColumn.DataPropertyName = "evrakTuru";
            this.evrakTuruDataGridViewTextBoxColumn.HeaderText = "Evrak Türü";
            this.evrakTuruDataGridViewTextBoxColumn.Name = "evrakTuruDataGridViewTextBoxColumn";
            // 
            // birimDataGridViewTextBoxColumn
            // 
            this.birimDataGridViewTextBoxColumn.DataPropertyName = "birim";
            this.birimDataGridViewTextBoxColumn.HeaderText = "Birim";
            this.birimDataGridViewTextBoxColumn.Name = "birimDataGridViewTextBoxColumn";
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "Tarih";
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            // 
            // dosyaYoluDataGridViewTextBoxColumn
            // 
            this.dosyaYoluDataGridViewTextBoxColumn.DataPropertyName = "dosyaYolu";
            this.dosyaYoluDataGridViewTextBoxColumn.HeaderText = "Dosya Yolu";
            this.dosyaYoluDataGridViewTextBoxColumn.Name = "dosyaYoluDataGridViewTextBoxColumn";
            // 
            // aciklamaDataGridViewTextBoxColumn
            // 
            this.aciklamaDataGridViewTextBoxColumn.DataPropertyName = "aciklama";
            this.aciklamaDataGridViewTextBoxColumn.HeaderText = "Açıklama";
            this.aciklamaDataGridViewTextBoxColumn.Name = "aciklamaDataGridViewTextBoxColumn";
            // 
            // evraklarBindingSource
            // 
            this.evraklarBindingSource.DataMember = "evraklar";
            this.evraklarBindingSource.DataSource = this.dbFabrikaDataSet2;
            // 
            // dbFabrikaDataSet2
            // 
            this.dbFabrikaDataSet2.DataSetName = "dbFabrikaDataSet2";
            this.dbFabrikaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // evraklarTableAdapter
            // 
            this.evraklarTableAdapter.ClearBeforeFill = true;
            // 
            // txtEvrakAdi
            // 
            this.txtEvrakAdi.Location = new System.Drawing.Point(880, 85);
            this.txtEvrakAdi.Name = "txtEvrakAdi";
            this.txtEvrakAdi.Size = new System.Drawing.Size(153, 20);
            this.txtEvrakAdi.TabIndex = 1;
            // 
            // txtEvrakTuru
            // 
            this.txtEvrakTuru.Location = new System.Drawing.Point(880, 129);
            this.txtEvrakTuru.Name = "txtEvrakTuru";
            this.txtEvrakTuru.Size = new System.Drawing.Size(153, 20);
            this.txtEvrakTuru.TabIndex = 2;
            // 
            // txtBirim
            // 
            this.txtBirim.Location = new System.Drawing.Point(880, 175);
            this.txtBirim.Name = "txtBirim";
            this.txtBirim.Size = new System.Drawing.Size(153, 20);
            this.txtBirim.TabIndex = 3;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(880, 312);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(153, 116);
            this.txtAciklama.TabIndex = 6;
            // 
            // txtDosyaYolu
            // 
            this.txtDosyaYolu.Location = new System.Drawing.Point(880, 266);
            this.txtDosyaYolu.Name = "txtDosyaYolu";
            this.txtDosyaYolu.Size = new System.Drawing.Size(153, 20);
            this.txtDosyaYolu.TabIndex = 5;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(880, 224);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(153, 20);
            this.dtpTarih.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(790, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Evrak Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(779, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Evrak Türü:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(823, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tarih:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(822, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Birim:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(790, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Açıklama:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(775, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Dosya Yolu:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnKaydet.Location = new System.Drawing.Point(778, 484);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(269, 42);
            this.btnKaydet.TabIndex = 14;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnTemizle.Location = new System.Drawing.Point(778, 532);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(269, 42);
            this.btnTemizle.TabIndex = 15;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // Evraklar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1059, 603);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtDosyaYolu);
            this.Controls.Add(this.txtBirim);
            this.Controls.Add(this.txtEvrakTuru);
            this.Controls.Add(this.txtEvrakAdi);
            this.Controls.Add(this.dgvEvraklar);
            this.MaximizeBox = false;
            this.Name = "Evraklar";
            this.Text = "Evraklar";
            this.Load += new System.EventHandler(this.Evraklar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvraklar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evraklarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbFabrikaDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEvraklar;
        private dbFabrikaDataSet2 dbFabrikaDataSet2;
        private System.Windows.Forms.BindingSource evraklarBindingSource;
        private dbFabrikaDataSet2TableAdapters.evraklarTableAdapter evraklarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn evrakIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn evrakAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn evrakTuruDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dosyaYoluDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aciklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtEvrakAdi;
        private System.Windows.Forms.TextBox txtEvrakTuru;
        private System.Windows.Forms.TextBox txtBirim;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtDosyaYolu;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnTemizle;
    }
}