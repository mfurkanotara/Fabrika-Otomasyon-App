namespace FabrikaOtomasyonApp
{
    partial class YoneticiPanel
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
            this.lblHosgeldin = new System.Windows.Forms.Label();
            this.btnPersoneller = new System.Windows.Forms.Button();
            this.btnFaturalar = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnRandevular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHosgeldin
            // 
            this.lblHosgeldin.AutoSize = true;
            this.lblHosgeldin.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            this.lblHosgeldin.Location = new System.Drawing.Point(25, 28);
            this.lblHosgeldin.Name = "lblHosgeldin";
            this.lblHosgeldin.Size = new System.Drawing.Size(159, 19);
            this.lblHosgeldin.TabIndex = 0;
            this.lblHosgeldin.Text = "\"Hoş geldiniz yazısı...\"";
            // 
            // btnPersoneller
            // 
            this.btnPersoneller.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnPersoneller.Font = new System.Drawing.Font("Nirmala Text", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnPersoneller.Location = new System.Drawing.Point(29, 100);
            this.btnPersoneller.Name = "btnPersoneller";
            this.btnPersoneller.Size = new System.Drawing.Size(343, 69);
            this.btnPersoneller.TabIndex = 1;
            this.btnPersoneller.Text = "PERSONELLER";
            this.btnPersoneller.UseVisualStyleBackColor = false;
            this.btnPersoneller.Click += new System.EventHandler(this.btnPersoneller_Click);
            // 
            // btnFaturalar
            // 
            this.btnFaturalar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnFaturalar.Font = new System.Drawing.Font("Nirmala Text", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnFaturalar.Location = new System.Drawing.Point(29, 175);
            this.btnFaturalar.Name = "btnFaturalar";
            this.btnFaturalar.Size = new System.Drawing.Size(343, 69);
            this.btnFaturalar.TabIndex = 2;
            this.btnFaturalar.Text = "FATURALAR";
            this.btnFaturalar.UseVisualStyleBackColor = false;
            this.btnFaturalar.Click += new System.EventHandler(this.btnFaturalar_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Red;
            this.btnCikis.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCikis.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCikis.Location = new System.Drawing.Point(29, 380);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(126, 42);
            this.btnCikis.TabIndex = 5;
            this.btnCikis.Text = "Çıkış Yap";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnRandevular
            // 
            this.btnRandevular.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRandevular.Font = new System.Drawing.Font("Nirmala Text", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnRandevular.Location = new System.Drawing.Point(29, 250);
            this.btnRandevular.Name = "btnRandevular";
            this.btnRandevular.Size = new System.Drawing.Size(343, 69);
            this.btnRandevular.TabIndex = 6;
            this.btnRandevular.Text = "RANDEVULAR";
            this.btnRandevular.UseVisualStyleBackColor = false;
            this.btnRandevular.Click += new System.EventHandler(this.btnRandevular_Click);
            // 
            // YoneticiPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(404, 448);
            this.Controls.Add(this.btnRandevular);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnFaturalar);
            this.Controls.Add(this.btnPersoneller);
            this.Controls.Add(this.lblHosgeldin);
            this.Name = "YoneticiPanel";
            this.Text = "Yönetici Paneli";
            this.Load += new System.EventHandler(this.YoneticiPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHosgeldin;
        private System.Windows.Forms.Button btnPersoneller;
        private System.Windows.Forms.Button btnFaturalar;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnRandevular;
    }
}