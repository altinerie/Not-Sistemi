namespace Not_Sistemi
{
    partial class FrmOgrenciDetay
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LBL_AdSoyad = new System.Windows.Forms.Label();
            this.LBL_SNV1 = new System.Windows.Forms.Label();
            this.LBL_SNV2 = new System.Windows.Forms.Label();
            this.LBL_ORT = new System.Windows.Forms.Label();
            this.LBL_DURUM = new System.Windows.Forms.Label();
            this.LblNumara = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.FOGOBOX = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı Soyadı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numarası:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "1. Sınav:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 64);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "2. Sınav:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(303, 133);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Durum:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(298, 95);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ortalama:";
            // 
            // LBL_AdSoyad
            // 
            this.LBL_AdSoyad.AutoSize = true;
            this.LBL_AdSoyad.Location = new System.Drawing.Point(110, 32);
            this.LBL_AdSoyad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_AdSoyad.Name = "LBL_AdSoyad";
            this.LBL_AdSoyad.Size = new System.Drawing.Size(52, 18);
            this.LBL_AdSoyad.TabIndex = 6;
            this.LBL_AdSoyad.Text = "NULL";
            // 
            // LBL_SNV1
            // 
            this.LBL_SNV1.AutoSize = true;
            this.LBL_SNV1.Location = new System.Drawing.Point(395, 32);
            this.LBL_SNV1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_SNV1.Name = "LBL_SNV1";
            this.LBL_SNV1.Size = new System.Drawing.Size(28, 18);
            this.LBL_SNV1.TabIndex = 7;
            this.LBL_SNV1.Text = "00";
            // 
            // LBL_SNV2
            // 
            this.LBL_SNV2.AutoSize = true;
            this.LBL_SNV2.Location = new System.Drawing.Point(395, 64);
            this.LBL_SNV2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_SNV2.Name = "LBL_SNV2";
            this.LBL_SNV2.Size = new System.Drawing.Size(28, 18);
            this.LBL_SNV2.TabIndex = 8;
            this.LBL_SNV2.Text = "00";
            // 
            // LBL_ORT
            // 
            this.LBL_ORT.AutoSize = true;
            this.LBL_ORT.Location = new System.Drawing.Point(395, 95);
            this.LBL_ORT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_ORT.Name = "LBL_ORT";
            this.LBL_ORT.Size = new System.Drawing.Size(28, 18);
            this.LBL_ORT.TabIndex = 9;
            this.LBL_ORT.Text = "00";
            // 
            // LBL_DURUM
            // 
            this.LBL_DURUM.AutoSize = true;
            this.LBL_DURUM.Location = new System.Drawing.Point(374, 133);
            this.LBL_DURUM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_DURUM.Name = "LBL_DURUM";
            this.LBL_DURUM.Size = new System.Drawing.Size(28, 18);
            this.LBL_DURUM.TabIndex = 10;
            this.LBL_DURUM.Text = "00";
            // 
            // LblNumara
            // 
            this.LblNumara.AutoSize = true;
            this.LblNumara.Location = new System.Drawing.Point(109, 50);
            this.LblNumara.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNumara.Name = "LblNumara";
            this.LblNumara.Size = new System.Drawing.Size(48, 18);
            this.LblNumara.TabIndex = 11;
            this.LblNumara.Text = "0000";
            this.LblNumara.Click += new System.EventHandler(this.LblNumara_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // FOGOBOX
            // 
            this.FOGOBOX.AutoSize = true;
            this.FOGOBOX.Location = new System.Drawing.Point(53, 133);
            this.FOGOBOX.Name = "FOGOBOX";
            this.FOGOBOX.Size = new System.Drawing.Size(61, 18);
            this.FOGOBOX.TabIndex = 12;
            this.FOGOBOX.Text = "fotobox";
            // 
            // FrmOgrenciDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 328);
            this.Controls.Add(this.FOGOBOX);
            this.Controls.Add(this.LblNumara);
            this.Controls.Add(this.LBL_DURUM);
            this.Controls.Add(this.LBL_ORT);
            this.Controls.Add(this.LBL_SNV2);
            this.Controls.Add(this.LBL_SNV1);
            this.Controls.Add(this.LBL_AdSoyad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmOgrenciDetay";
            this.Text = "FrmOgrenciDetay";
            this.Load += new System.EventHandler(this.FrmOgrenciDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LBL_AdSoyad;
        private System.Windows.Forms.Label LBL_SNV1;
        private System.Windows.Forms.Label LBL_SNV2;
        private System.Windows.Forms.Label LBL_ORT;
        private System.Windows.Forms.Label LBL_DURUM;
        private System.Windows.Forms.Label LblNumara;
        private System.Windows.Forms.ImageList ımageList1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label FOGOBOX;
    }
}