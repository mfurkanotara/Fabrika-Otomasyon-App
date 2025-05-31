namespace FabrikaOtomasyonApp
{
    partial class GirisPanel
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
            this.btnPersonel = new System.Windows.Forms.Button();
            this.btnYonetici = new System.Windows.Forms.Button();
            this.btnMudur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(41, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lütfen Giriş Yapınız";
            // 
            // btnPersonel
            // 
            this.btnPersonel.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnPersonel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPersonel.Font = new System.Drawing.Font("Ebrima", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPersonel.Location = new System.Drawing.Point(47, 109);
            this.btnPersonel.Name = "btnPersonel";
            this.btnPersonel.Size = new System.Drawing.Size(237, 85);
            this.btnPersonel.TabIndex = 1;
            this.btnPersonel.Text = "PERSONEL";
            this.btnPersonel.UseVisualStyleBackColor = false;
            this.btnPersonel.Click += new System.EventHandler(this.btnPersonel_Click);
            // 
            // btnYonetici
            // 
            this.btnYonetici.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnYonetici.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYonetici.Font = new System.Drawing.Font("Ebrima", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYonetici.Location = new System.Drawing.Point(47, 200);
            this.btnYonetici.Name = "btnYonetici";
            this.btnYonetici.Size = new System.Drawing.Size(237, 85);
            this.btnYonetici.TabIndex = 2;
            this.btnYonetici.Text = "YÖNETİCİ";
            this.btnYonetici.UseVisualStyleBackColor = false;
            this.btnYonetici.Click += new System.EventHandler(this.btnYonetici_Click);
            // 
            // btnMudur
            // 
            this.btnMudur.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnMudur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMudur.Font = new System.Drawing.Font("Ebrima", 26.25F, System.Drawing.FontStyle.Bold);
            this.btnMudur.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMudur.Location = new System.Drawing.Point(47, 291);
            this.btnMudur.Name = "btnMudur";
            this.btnMudur.Size = new System.Drawing.Size(237, 85);
            this.btnMudur.TabIndex = 3;
            this.btnMudur.Text = "MÜDÜR";
            this.btnMudur.UseVisualStyleBackColor = false;
            this.btnMudur.Click += new System.EventHandler(this.btnMudur_Click);
            // 
            // GirisPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(332, 423);
            this.Controls.Add(this.btnMudur);
            this.Controls.Add(this.btnYonetici);
            this.Controls.Add(this.btnPersonel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GirisPanel";
            this.Text = "Giriş Paneli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPersonel;
        private System.Windows.Forms.Button btnYonetici;
        private System.Windows.Forms.Button btnMudur;
    }
}

