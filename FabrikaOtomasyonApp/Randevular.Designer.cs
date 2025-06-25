namespace FabrikaOtomasyonApp
{
    partial class Randevular
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
            this.dgvRandevular = new System.Windows.Forms.DataGridView();
            this.randevuKoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randevuKonuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gorusulecekKisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randevuTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randevularBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbFabrikaDataSet6 = new FabrikaOtomasyonApp.dbFabrikaDataSet6();
            this.dbFabrikaDataSet5 = new FabrikaOtomasyonApp.dbFabrikaDataSet5();
            this.randevularBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.randevularTableAdapter = new FabrikaOtomasyonApp.dbFabrikaDataSet5TableAdapters.randevularTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRandevuKonusu = new System.Windows.Forms.TextBox();
            this.txtGorusulecekKisi = new System.Windows.Forms.TextBox();
            this.dtpRandevuTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnRandevuSil = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.randevularTableAdapter1 = new FabrikaOtomasyonApp.dbFabrikaDataSet6TableAdapters.randevularTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRandevular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevularBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbFabrikaDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbFabrikaDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevularBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRandevular
            // 
            this.dgvRandevular.AutoGenerateColumns = false;
            this.dgvRandevular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRandevular.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.randevuKoduDataGridViewTextBoxColumn,
            this.randevuKonuDataGridViewTextBoxColumn,
            this.gorusulecekKisiDataGridViewTextBoxColumn,
            this.randevuTarihiDataGridViewTextBoxColumn});
            this.dgvRandevular.DataSource = this.randevularBindingSource1;
            this.dgvRandevular.Location = new System.Drawing.Point(13, 12);
            this.dgvRandevular.Name = "dgvRandevular";
            this.dgvRandevular.Size = new System.Drawing.Size(443, 424);
            this.dgvRandevular.TabIndex = 0;
            this.dgvRandevular.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRandevular_CellClick);
            // 
            // randevuKoduDataGridViewTextBoxColumn
            // 
            this.randevuKoduDataGridViewTextBoxColumn.DataPropertyName = "randevuKodu";
            this.randevuKoduDataGridViewTextBoxColumn.HeaderText = "Randevu Kodu";
            this.randevuKoduDataGridViewTextBoxColumn.Name = "randevuKoduDataGridViewTextBoxColumn";
            this.randevuKoduDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // randevuKonuDataGridViewTextBoxColumn
            // 
            this.randevuKonuDataGridViewTextBoxColumn.DataPropertyName = "randevuKonu";
            this.randevuKonuDataGridViewTextBoxColumn.HeaderText = "Randevu Konu";
            this.randevuKonuDataGridViewTextBoxColumn.Name = "randevuKonuDataGridViewTextBoxColumn";
            // 
            // gorusulecekKisiDataGridViewTextBoxColumn
            // 
            this.gorusulecekKisiDataGridViewTextBoxColumn.DataPropertyName = "gorusulecekKisi";
            this.gorusulecekKisiDataGridViewTextBoxColumn.HeaderText = "Görüşülecek Kişi";
            this.gorusulecekKisiDataGridViewTextBoxColumn.Name = "gorusulecekKisiDataGridViewTextBoxColumn";
            // 
            // randevuTarihiDataGridViewTextBoxColumn
            // 
            this.randevuTarihiDataGridViewTextBoxColumn.DataPropertyName = "randevuTarihi";
            this.randevuTarihiDataGridViewTextBoxColumn.HeaderText = "Randevu Tarihi";
            this.randevuTarihiDataGridViewTextBoxColumn.Name = "randevuTarihiDataGridViewTextBoxColumn";
            // 
            // randevularBindingSource1
            // 
            this.randevularBindingSource1.DataMember = "randevular";
            this.randevularBindingSource1.DataSource = this.dbFabrikaDataSet6;
            // 
            // dbFabrikaDataSet6
            // 
            this.dbFabrikaDataSet6.DataSetName = "dbFabrikaDataSet6";
            this.dbFabrikaDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbFabrikaDataSet5
            // 
            this.dbFabrikaDataSet5.DataSetName = "dbFabrikaDataSet5";
            this.dbFabrikaDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // randevularBindingSource
            // 
            this.randevularBindingSource.DataMember = "randevular";
            this.randevularBindingSource.DataSource = this.dbFabrikaDataSet5;
            // 
            // randevularTableAdapter
            // 
            this.randevularTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(509, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 18);
            this.label6.TabIndex = 23;
            this.label6.Text = "Randevu Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(492, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "Görüşülecek Kişi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(494, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Randevu Konusu:";
            // 
            // txtRandevuKonusu
            // 
            this.txtRandevuKonusu.Location = new System.Drawing.Point(640, 88);
            this.txtRandevuKonusu.Name = "txtRandevuKonusu";
            this.txtRandevuKonusu.Size = new System.Drawing.Size(158, 20);
            this.txtRandevuKonusu.TabIndex = 25;
            // 
            // txtGorusulecekKisi
            // 
            this.txtGorusulecekKisi.Location = new System.Drawing.Point(640, 121);
            this.txtGorusulecekKisi.Name = "txtGorusulecekKisi";
            this.txtGorusulecekKisi.Size = new System.Drawing.Size(158, 20);
            this.txtGorusulecekKisi.TabIndex = 26;
            // 
            // dtpRandevuTarihi
            // 
            this.dtpRandevuTarihi.Location = new System.Drawing.Point(640, 154);
            this.dtpRandevuTarihi.Name = "dtpRandevuTarihi";
            this.dtpRandevuTarihi.Size = new System.Drawing.Size(158, 20);
            this.dtpRandevuTarihi.TabIndex = 28;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(462, 242);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(374, 45);
            this.btnKaydet.TabIndex = 30;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnRandevuSil
            // 
            this.btnRandevuSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRandevuSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnRandevuSil.Location = new System.Drawing.Point(462, 293);
            this.btnRandevuSil.Name = "btnRandevuSil";
            this.btnRandevuSil.Size = new System.Drawing.Size(374, 45);
            this.btnRandevuSil.TabIndex = 31;
            this.btnRandevuSil.Text = "Randevuyu Sil";
            this.btnRandevuSil.UseVisualStyleBackColor = true;
            this.btnRandevuSil.Click += new System.EventHandler(this.btnRandevuSil_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnTemizle.Location = new System.Drawing.Point(462, 392);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(374, 44);
            this.btnTemizle.TabIndex = 32;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnGuncelle.Location = new System.Drawing.Point(462, 344);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(374, 44);
            this.btnGuncelle.TabIndex = 33;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // randevularTableAdapter1
            // 
            this.randevularTableAdapter1.ClearBeforeFill = true;
            // 
            // Randevular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(844, 453);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnRandevuSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dtpRandevuTarihi);
            this.Controls.Add(this.txtGorusulecekKisi);
            this.Controls.Add(this.txtRandevuKonusu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvRandevular);
            this.Name = "Randevular";
            this.Text = "Randevular";
            this.Load += new System.EventHandler(this.Randevular_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRandevular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevularBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbFabrikaDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbFabrikaDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevularBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRandevular;
        private dbFabrikaDataSet5 dbFabrikaDataSet5;
        private System.Windows.Forms.BindingSource randevularBindingSource;
        private dbFabrikaDataSet5TableAdapters.randevularTableAdapter randevularTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevuKoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevuKonuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gorusulecekKisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevuTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRandevuKonusu;
        private System.Windows.Forms.TextBox txtGorusulecekKisi;
        private System.Windows.Forms.DateTimePicker dtpRandevuTarihi;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnRandevuSil;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnGuncelle;
        private dbFabrikaDataSet6 dbFabrikaDataSet6;
        private System.Windows.Forms.BindingSource randevularBindingSource1;
        private dbFabrikaDataSet6TableAdapters.randevularTableAdapter randevularTableAdapter1;
    }
}