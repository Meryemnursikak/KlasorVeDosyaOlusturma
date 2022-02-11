
namespace KlasorVeDosyaOlusturma
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
            this.btnklasor = new System.Windows.Forms.Button();
            this.btndosya = new System.Windows.Forms.Button();
            this.btnklasortasi = new System.Windows.Forms.Button();
            this.btnkopyala = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnoku = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnklasor
            // 
            this.btnklasor.Location = new System.Drawing.Point(83, 43);
            this.btnklasor.Name = "btnklasor";
            this.btnklasor.Size = new System.Drawing.Size(144, 31);
            this.btnklasor.TabIndex = 0;
            this.btnklasor.Text = "Klasör Oluştur";
            this.btnklasor.UseVisualStyleBackColor = true;
            this.btnklasor.Click += new System.EventHandler(this.btnklasor_Click);
            // 
            // btndosya
            // 
            this.btndosya.Location = new System.Drawing.Point(83, 91);
            this.btndosya.Name = "btndosya";
            this.btndosya.Size = new System.Drawing.Size(144, 36);
            this.btndosya.TabIndex = 1;
            this.btndosya.Text = "Dosya Oluştur";
            this.btndosya.UseVisualStyleBackColor = true;
            this.btndosya.Click += new System.EventHandler(this.btndosya_Click);
            // 
            // btnklasortasi
            // 
            this.btnklasortasi.Location = new System.Drawing.Point(83, 145);
            this.btnklasortasi.Name = "btnklasortasi";
            this.btnklasortasi.Size = new System.Drawing.Size(144, 37);
            this.btnklasortasi.TabIndex = 2;
            this.btnklasortasi.Text = "Klasör Taşı";
            this.btnklasortasi.UseVisualStyleBackColor = true;
            this.btnklasortasi.Click += new System.EventHandler(this.btnklasortasi_Click);
            // 
            // btnkopyala
            // 
            this.btnkopyala.Location = new System.Drawing.Point(83, 201);
            this.btnkopyala.Name = "btnkopyala";
            this.btnkopyala.Size = new System.Drawing.Size(144, 34);
            this.btnkopyala.TabIndex = 3;
            this.btnkopyala.Text = "Dosya Kopyala";
            this.btnkopyala.UseVisualStyleBackColor = true;
            this.btnkopyala.Click += new System.EventHandler(this.btnkopyala_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(83, 257);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(144, 35);
            this.btnsil.TabIndex = 4;
            this.btnsil.Text = "Dosya Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnoku
            // 
            this.btnoku.Location = new System.Drawing.Point(83, 312);
            this.btnoku.Name = "btnoku";
            this.btnoku.Size = new System.Drawing.Size(144, 34);
            this.btnoku.TabIndex = 5;
            this.btnoku.Text = "Dosya Oku";
            this.btnoku.UseVisualStyleBackColor = true;
            this.btnoku.Click += new System.EventHandler(this.btnoku_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnoku);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnkopyala);
            this.Controls.Add(this.btnklasortasi);
            this.Controls.Add(this.btndosya);
            this.Controls.Add(this.btnklasor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnklasor;
        private System.Windows.Forms.Button btndosya;
        private System.Windows.Forms.Button btnklasortasi;
        private System.Windows.Forms.Button btnkopyala;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnoku;
    }
}

