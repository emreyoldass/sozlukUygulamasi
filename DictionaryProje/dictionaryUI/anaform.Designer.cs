
namespace dictionaryUI
{
    partial class anaform
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_en = new System.Windows.Forms.TextBox();
            this.txt_tr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_aciklama = new System.Windows.Forms.TextBox();
            this.txt_örnek = new System.Windows.Forms.TextBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_kutuphaneAc = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "EN Karşılık";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "TR Karşılık";
            // 
            // txt_en
            // 
            this.txt_en.Location = new System.Drawing.Point(97, 43);
            this.txt_en.Name = "txt_en";
            this.txt_en.Size = new System.Drawing.Size(250, 20);
            this.txt_en.TabIndex = 1;
            // 
            // txt_tr
            // 
            this.txt_tr.Location = new System.Drawing.Point(97, 79);
            this.txt_tr.Name = "txt_tr";
            this.txt_tr.Size = new System.Drawing.Size(250, 20);
            this.txt_tr.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kelimenin Açıklaması Giriniz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Örnek Kullanım";
            // 
            // txt_aciklama
            // 
            this.txt_aciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_aciklama.Location = new System.Drawing.Point(9, 82);
            this.txt_aciklama.Multiline = true;
            this.txt_aciklama.Name = "txt_aciklama";
            this.txt_aciklama.Size = new System.Drawing.Size(351, 187);
            this.txt_aciklama.TabIndex = 0;
            // 
            // txt_örnek
            // 
            this.txt_örnek.Location = new System.Drawing.Point(116, 139);
            this.txt_örnek.Multiline = true;
            this.txt_örnek.Name = "txt_örnek";
            this.txt_örnek.Size = new System.Drawing.Size(250, 87);
            this.txt_örnek.TabIndex = 3;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(645, 324);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(132, 31);
            this.btn_kaydet.TabIndex = 2;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_en);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_örnek);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_tr);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 275);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kayıt Etme İşlemleri";
            // 
            // btn_kutuphaneAc
            // 
            this.btn_kutuphaneAc.Location = new System.Drawing.Point(507, 324);
            this.btn_kutuphaneAc.Name = "btn_kutuphaneAc";
            this.btn_kutuphaneAc.Size = new System.Drawing.Size(132, 31);
            this.btn_kutuphaneAc.TabIndex = 3;
            this.btn_kutuphaneAc.Text = "Kütüphaneyi Aç";
            this.btn_kutuphaneAc.UseVisualStyleBackColor = true;
            this.btn_kutuphaneAc.Click += new System.EventHandler(this.btn_kutuphaneAc_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_aciklama);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(411, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(366, 275);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kelime Açıklaması";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 359);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_kutuphaneAc);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sözlük Defteri";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_en;
        private System.Windows.Forms.TextBox txt_tr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_aciklama;
        private System.Windows.Forms.TextBox txt_örnek;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_kutuphaneAc;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

