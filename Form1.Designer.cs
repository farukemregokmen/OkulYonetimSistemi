namespace OkulYonetimSistemi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            OgrtmnLabel = new Label();
            OgrenciLabel = new Label();
            OgrtAdSoyad = new Label();
            OgrtSifre = new Label();
            OgrtAdSoyadText = new TextBox();
            OgrtSifreText = new TextBox();
            OgrnSifreText = new TextBox();
            OgrnAdSoyadText = new TextBox();
            OgrnSifre = new Label();
            OgrnAdSoyad = new Label();
            OgrtGiris = new Button();
            OgrnGiris = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(OgrtGiris);
            splitContainer1.Panel1.Controls.Add(OgrtSifreText);
            splitContainer1.Panel1.Controls.Add(OgrtAdSoyadText);
            splitContainer1.Panel1.Controls.Add(OgrtSifre);
            splitContainer1.Panel1.Controls.Add(OgrtAdSoyad);
            splitContainer1.Panel1.Controls.Add(OgrtmnLabel);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(OgrnGiris);
            splitContainer1.Panel2.Controls.Add(OgrnSifreText);
            splitContainer1.Panel2.Controls.Add(OgrenciLabel);
            splitContainer1.Panel2.Controls.Add(OgrnAdSoyadText);
            splitContainer1.Panel2.Controls.Add(OgrnAdSoyad);
            splitContainer1.Panel2.Controls.Add(OgrnSifre);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 379;
            splitContainer1.TabIndex = 0;
            splitContainer1.SplitterMoved += splitContainer1_SplitterMoved;
            // 
            // OgrtmnLabel
            // 
            OgrtmnLabel.AutoSize = true;
            OgrtmnLabel.Font = new Font("Segoe Print", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            OgrtmnLabel.Location = new Point(73, 9);
            OgrtmnLabel.Name = "OgrtmnLabel";
            OgrtmnLabel.Size = new Size(232, 47);
            OgrtmnLabel.TabIndex = 0;
            OgrtmnLabel.Text = "Öğretmen Giriş";
            // 
            // OgrenciLabel
            // 
            OgrenciLabel.AutoSize = true;
            OgrenciLabel.Font = new Font("Segoe Print", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            OgrenciLabel.Location = new Point(95, 9);
            OgrenciLabel.Name = "OgrenciLabel";
            OgrenciLabel.Size = new Size(199, 47);
            OgrenciLabel.TabIndex = 1;
            OgrenciLabel.Text = "Öğrenci Giriş";
            // 
            // OgrtAdSoyad
            // 
            OgrtAdSoyad.AutoSize = true;
            OgrtAdSoyad.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            OgrtAdSoyad.Location = new Point(22, 126);
            OgrtAdSoyad.Name = "OgrtAdSoyad";
            OgrtAdSoyad.Size = new Size(107, 25);
            OgrtAdSoyad.TabIndex = 1;
            OgrtAdSoyad.Text = "Ad Soyad :";
            // 
            // OgrtSifre
            // 
            OgrtSifre.AutoSize = true;
            OgrtSifre.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            OgrtSifre.Location = new Point(22, 238);
            OgrtSifre.Name = "OgrtSifre";
            OgrtSifre.Size = new Size(63, 25);
            OgrtSifre.TabIndex = 2;
            OgrtSifre.Text = "Şifre :";
            // 
            // OgrtAdSoyadText
            // 
            OgrtAdSoyadText.Location = new Point(29, 169);
            OgrtAdSoyadText.Multiline = true;
            OgrtAdSoyadText.Name = "OgrtAdSoyadText";
            OgrtAdSoyadText.Size = new Size(315, 37);
            OgrtAdSoyadText.TabIndex = 3;
            // 
            // OgrtSifreText
            // 
            OgrtSifreText.Location = new Point(29, 288);
            OgrtSifreText.Multiline = true;
            OgrtSifreText.Name = "OgrtSifreText";
            OgrtSifreText.Size = new Size(315, 37);
            OgrtSifreText.TabIndex = 4;
            // 
            // OgrnSifreText
            // 
            OgrnSifreText.Location = new Point(53, 288);
            OgrnSifreText.Multiline = true;
            OgrnSifreText.Name = "OgrnSifreText";
            OgrnSifreText.Size = new Size(315, 37);
            OgrnSifreText.TabIndex = 8;
            // 
            // OgrnAdSoyadText
            // 
            OgrnAdSoyadText.Location = new Point(53, 169);
            OgrnAdSoyadText.Multiline = true;
            OgrnAdSoyadText.Name = "OgrnAdSoyadText";
            OgrnAdSoyadText.Size = new Size(315, 37);
            OgrnAdSoyadText.TabIndex = 7;
            // 
            // OgrnSifre
            // 
            OgrnSifre.AutoSize = true;
            OgrnSifre.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            OgrnSifre.Location = new Point(46, 238);
            OgrnSifre.Name = "OgrnSifre";
            OgrnSifre.Size = new Size(63, 25);
            OgrnSifre.TabIndex = 6;
            OgrnSifre.Text = "Şifre :";
            // 
            // OgrnAdSoyad
            // 
            OgrnAdSoyad.AutoSize = true;
            OgrnAdSoyad.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            OgrnAdSoyad.Location = new Point(46, 126);
            OgrnAdSoyad.Name = "OgrnAdSoyad";
            OgrnAdSoyad.Size = new Size(107, 25);
            OgrnAdSoyad.TabIndex = 5;
            OgrnAdSoyad.Text = "Ad Soyad :";
            // 
            // OgrtGiris
            // 
            OgrtGiris.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            OgrtGiris.Location = new Point(116, 363);
            OgrtGiris.Name = "OgrtGiris";
            OgrtGiris.Size = new Size(134, 41);
            OgrtGiris.TabIndex = 5;
            OgrtGiris.Text = "Giriş";
            OgrtGiris.UseVisualStyleBackColor = true;
            OgrtGiris.Click += OgrtGiris_Click;
            // 
            // OgrnGiris
            // 
            OgrnGiris.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            OgrnGiris.Location = new Point(149, 363);
            OgrnGiris.Name = "OgrnGiris";
            OgrnGiris.Size = new Size(134, 41);
            OgrnGiris.TabIndex = 6;
            OgrnGiris.Text = "Giriş";
            OgrnGiris.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "YonetimGiris";
            Load += Form1_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label OgrtmnLabel;
        private Label OgrenciLabel;
        private TextBox OgrtSifreText;
        private TextBox OgrtAdSoyadText;
        private Label OgrtSifre;
        private Label OgrtAdSoyad;
        private TextBox OgrnSifreText;
        private TextBox OgrnAdSoyadText;
        private Label OgrnAdSoyad;
        private Label OgrnSifre;
        private Button OgrtGiris;
        private Button OgrnGiris;
    }
}
