namespace FabrikaOtomasyonApp
{
    partial class PersonelPanel
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
            this.btnMalzemeler = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnEvraklar = new System.Windows.Forms.Button();
            this.btnStoklar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHosgeldin
            // 
            this.lblHosgeldin.AutoSize = true;
            this.lblHosgeldin.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHosgeldin.Location = new System.Drawing.Point(12, 38);
            this.lblHosgeldin.Name = "lblHosgeldin";
            this.lblHosgeldin.Size = new System.Drawing.Size(159, 19);
            this.lblHosgeldin.TabIndex = 0;
            this.lblHosgeldin.Text = "\"Hoş geldiniz yazısı...\"";
            // 
            // btnMalzemeler
            // 
            this.btnMalzemeler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnMalzemeler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMalzemeler.Font = new System.Drawing.Font("Nirmala Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMalzemeler.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMalzemeler.Location = new System.Drawing.Point(12, 100);
            this.btnMalzemeler.Name = "btnMalzemeler";
            this.btnMalzemeler.Size = new System.Drawing.Size(395, 87);
            this.btnMalzemeler.TabIndex = 1;
            this.btnMalzemeler.Text = "MALZEMELER";
            this.btnMalzemeler.UseVisualStyleBackColor = false;
            this.btnMalzemeler.Click += new System.EventHandler(this.btnMalzemeler_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(12, 483);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 45);
            this.button2.TabIndex = 2;
            this.button2.Text = "Çıkış Yap";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnEvraklar
            // 
            this.btnEvraklar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEvraklar.Font = new System.Drawing.Font("Nirmala Text", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnEvraklar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEvraklar.Location = new System.Drawing.Point(12, 286);
            this.btnEvraklar.Name = "btnEvraklar";
            this.btnEvraklar.Size = new System.Drawing.Size(395, 87);
            this.btnEvraklar.TabIndex = 3;
            this.btnEvraklar.Text = "EVRAKLAR";
            this.btnEvraklar.UseVisualStyleBackColor = false;
            // 
            // btnStoklar
            // 
            this.btnStoklar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnStoklar.Font = new System.Drawing.Font("Nirmala Text", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnStoklar.Location = new System.Drawing.Point(12, 193);
            this.btnStoklar.Name = "btnStoklar";
            this.btnStoklar.Size = new System.Drawing.Size(395, 87);
            this.btnStoklar.TabIndex = 4;
            this.btnStoklar.Text = "STOKLAR";
            this.btnStoklar.UseVisualStyleBackColor = false;
            this.btnStoklar.Click += new System.EventHandler(this.btnStoklar_Click);
            // 
            // PersonelPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ClientSize = new System.Drawing.Size(421, 540);
            this.Controls.Add(this.btnStoklar);
            this.Controls.Add(this.btnEvraklar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnMalzemeler);
            this.Controls.Add(this.lblHosgeldin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PersonelPanel";
            this.Text = "PersonelPanel";
            this.Load += new System.EventHandler(this.PersonelPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHosgeldin;
        private System.Windows.Forms.Button btnMalzemeler;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnEvraklar;
        private System.Windows.Forms.Button btnStoklar;
    }
}