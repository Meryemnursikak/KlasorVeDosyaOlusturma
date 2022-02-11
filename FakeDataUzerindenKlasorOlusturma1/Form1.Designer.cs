
namespace FakeDataUzerindenKlasorOlusturma1
{
    partial class Form1
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
            this.btngetir = new System.Windows.Forms.Button();
            this.lstkisiler = new System.Windows.Forms.ListBox();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblulke = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblsoyisim = new System.Windows.Forms.Label();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtulke = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.lblisim = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btngetir
            // 
            this.btngetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngetir.Location = new System.Drawing.Point(61, 538);
            this.btngetir.Name = "btngetir";
            this.btngetir.Size = new System.Drawing.Size(208, 42);
            this.btngetir.TabIndex = 0;
            this.btngetir.Text = "Kişi Getir";
            this.btngetir.UseVisualStyleBackColor = true;
            this.btngetir.Click += new System.EventHandler(this.btngetir_Click);
            // 
            // lstkisiler
            // 
            this.lstkisiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstkisiler.FormattingEnabled = true;
            this.lstkisiler.ItemHeight = 20;
            this.lstkisiler.Location = new System.Drawing.Point(61, 31);
            this.lstkisiler.Name = "lstkisiler";
            this.lstkisiler.Size = new System.Drawing.Size(208, 484);
            this.lstkisiler.TabIndex = 1;
            this.lstkisiler.DoubleClick += new System.EventHandler(this.lstkisiler_DoubleClick);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkaydet.Location = new System.Drawing.Point(290, 538);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(208, 42);
            this.btnkaydet.TabIndex = 2;
            this.btnkaydet.Text = "Klasör Oluştur";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblulke);
            this.groupBox1.Controls.Add(this.lblemail);
            this.groupBox1.Controls.Add(this.lblsoyisim);
            this.groupBox1.Controls.Add(this.txtsoyad);
            this.groupBox1.Controls.Add(this.txtemail);
            this.groupBox1.Controls.Add(this.txtulke);
            this.groupBox1.Controls.Add(this.txtad);
            this.groupBox1.Controls.Add(this.lblisim);
            this.groupBox1.Location = new System.Drawing.Point(290, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 322);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişi Bilgileri";
            // 
            // lblulke
            // 
            this.lblulke.AutoSize = true;
            this.lblulke.Location = new System.Drawing.Point(19, 254);
            this.lblulke.Name = "lblulke";
            this.lblulke.Size = new System.Drawing.Size(36, 17);
            this.lblulke.TabIndex = 18;
            this.lblulke.Text = "Ülke";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(19, 185);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(42, 17);
            this.lblemail.TabIndex = 17;
            this.lblemail.Text = "Email";
            // 
            // lblsoyisim
            // 
            this.lblsoyisim.AutoSize = true;
            this.lblsoyisim.Location = new System.Drawing.Point(19, 117);
            this.lblsoyisim.Name = "lblsoyisim";
            this.lblsoyisim.Size = new System.Drawing.Size(48, 17);
            this.lblsoyisim.TabIndex = 16;
            this.lblsoyisim.Text = "Soyad";
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(91, 105);
            this.txtsoyad.Multiline = true;
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(172, 40);
            this.txtsoyad.TabIndex = 15;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(91, 172);
            this.txtemail.Multiline = true;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(172, 40);
            this.txtemail.TabIndex = 14;
            // 
            // txtulke
            // 
            this.txtulke.Location = new System.Drawing.Point(91, 238);
            this.txtulke.Multiline = true;
            this.txtulke.Name = "txtulke";
            this.txtulke.Size = new System.Drawing.Size(172, 40);
            this.txtulke.TabIndex = 13;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(91, 44);
            this.txtad.Multiline = true;
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(172, 40);
            this.txtad.TabIndex = 12;
            // 
            // lblisim
            // 
            this.lblisim.AutoSize = true;
            this.lblisim.Location = new System.Drawing.Point(19, 47);
            this.lblisim.Name = "lblisim";
            this.lblisim.Size = new System.Drawing.Size(25, 17);
            this.lblisim.TabIndex = 11;
            this.lblisim.Text = "Ad";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 608);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.lstkisiler);
            this.Controls.Add(this.btngetir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btngetir;
        private System.Windows.Forms.ListBox lstkisiler;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblulke;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblsoyisim;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtulke;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label lblisim;
    }
}

