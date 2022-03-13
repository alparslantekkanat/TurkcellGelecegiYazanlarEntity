namespace GyEntity2
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
            this.UrunEkle = new System.Windows.Forms.Button();
            this.KisiEkle = new System.Windows.Forms.Button();
            this.alisveris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UrunEkle
            // 
            this.UrunEkle.Location = new System.Drawing.Point(207, 37);
            this.UrunEkle.Name = "UrunEkle";
            this.UrunEkle.Size = new System.Drawing.Size(438, 75);
            this.UrunEkle.TabIndex = 0;
            this.UrunEkle.Text = "Ürün Ekle";
            this.UrunEkle.UseVisualStyleBackColor = true;
            this.UrunEkle.Click += new System.EventHandler(this.UrunEkle_Click);
            // 
            // KisiEkle
            // 
            this.KisiEkle.Location = new System.Drawing.Point(207, 172);
            this.KisiEkle.Name = "KisiEkle";
            this.KisiEkle.Size = new System.Drawing.Size(438, 75);
            this.KisiEkle.TabIndex = 1;
            this.KisiEkle.Text = "Kişi Ekle";
            this.KisiEkle.UseVisualStyleBackColor = true;
            this.KisiEkle.Click += new System.EventHandler(this.KisiEkle_Click);
            // 
            // alisveris
            // 
            this.alisveris.Location = new System.Drawing.Point(207, 312);
            this.alisveris.Name = "alisveris";
            this.alisveris.Size = new System.Drawing.Size(438, 75);
            this.alisveris.TabIndex = 2;
            this.alisveris.Text = "Alışveriş";
            this.alisveris.UseVisualStyleBackColor = true;
            this.alisveris.Click += new System.EventHandler(this.alisveris_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.alisveris);
            this.Controls.Add(this.KisiEkle);
            this.Controls.Add(this.UrunEkle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UrunEkle;
        private System.Windows.Forms.Button KisiEkle;
        private System.Windows.Forms.Button alisveris;
    }
}

