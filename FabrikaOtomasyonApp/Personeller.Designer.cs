namespace FabrikaOtomasyonApp
{
    partial class Personeller
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
            this.dgvKullanicilar = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullanicilarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbFabrikaDataSet3 = new FabrikaOtomasyonApp.dbFabrikaDataSet3();
            this.kullanicilarTableAdapter = new FabrikaOtomasyonApp.dbFabrikaDataSet3TableAdapters.kullanicilarTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.cbRol = new System.Windows.Forms.ComboBox();
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanicilar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbFabrikaDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKullanicilar
            // 
            this.dgvKullanicilar.AutoGenerateColumns = false;
            this.dgvKullanicilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKullanicilar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.kullaniciAdiDataGridViewTextBoxColumn,
            this.sifreDataGridViewTextBoxColumn,
            this.rolDataGridViewTextBoxColumn});
            this.dgvKullanicilar.DataSource = this.kullanicilarBindingSource;
            this.dgvKullanicilar.Location = new System.Drawing.Point(13, 13);
            this.dgvKullanicilar.Name = "dgvKullanicilar";
            this.dgvKullanicilar.Size = new System.Drawing.Size(443, 490);
            this.dgvKullanicilar.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kullaniciAdiDataGridViewTextBoxColumn
            // 
            this.kullaniciAdiDataGridViewTextBoxColumn.DataPropertyName = "kullaniciAdi";
            this.kullaniciAdiDataGridViewTextBoxColumn.HeaderText = "Kullanıcı Adı";
            this.kullaniciAdiDataGridViewTextBoxColumn.Name = "kullaniciAdiDataGridViewTextBoxColumn";
            // 
            // sifreDataGridViewTextBoxColumn
            // 
            this.sifreDataGridViewTextBoxColumn.DataPropertyName = "sifre";
            this.sifreDataGridViewTextBoxColumn.HeaderText = "Şifre";
            this.sifreDataGridViewTextBoxColumn.Name = "sifreDataGridViewTextBoxColumn";
            // 
            // rolDataGridViewTextBoxColumn
            // 
            this.rolDataGridViewTextBoxColumn.DataPropertyName = "rol";
            this.rolDataGridViewTextBoxColumn.HeaderText = "Rol";
            this.rolDataGridViewTextBoxColumn.Name = "rolDataGridViewTextBoxColumn";
            // 
            // kullanicilarBindingSource
            // 
            this.kullanicilarBindingSource.DataMember = "kullanicilar";
            this.kullanicilarBindingSource.DataSource = this.dbFabrikaDataSet3;
            // 
            // dbFabrikaDataSet3
            // 
            this.dbFabrikaDataSet3.DataSetName = "dbFabrikaDataSet3";
            this.dbFabrikaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kullanicilarTableAdapter
            // 
            this.kullanicilarTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(504, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(560, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(569, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Rol:";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(614, 107);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(138, 20);
            this.txtKullaniciAdi.TabIndex = 12;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(614, 141);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(138, 20);
            this.txtSifre.TabIndex = 13;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnKaydet.Location = new System.Drawing.Point(481, 281);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(296, 70);
            this.btnKaydet.TabIndex = 15;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnTemizle.Location = new System.Drawing.Point(481, 433);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(296, 70);
            this.btnTemizle.TabIndex = 16;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // cbRol
            // 
            this.cbRol.FormattingEnabled = true;
            this.cbRol.Items.AddRange(new object[] {
            "Yonetici",
            "Mudur",
            "Personel"});
            this.cbRol.Location = new System.Drawing.Point(614, 174);
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(138, 21);
            this.cbRol.TabIndex = 17;
            // 
            // btnSil
            // 
            this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSil.Location = new System.Drawing.Point(481, 357);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(296, 70);
            this.btnSil.TabIndex = 18;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // Personeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 515);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.cbRol);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvKullanicilar);
            this.Name = "Personeller";
            this.Text = "Personeller";
            this.Load += new System.EventHandler(this.Personeller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanicilar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbFabrikaDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKullanicilar;
        private dbFabrikaDataSet3 dbFabrikaDataSet3;
        private System.Windows.Forms.BindingSource kullanicilarBindingSource;
        private dbFabrikaDataSet3TableAdapters.kullanicilarTableAdapter kullanicilarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.ComboBox cbRol;
        private System.Windows.Forms.Button btnSil;
    }
}