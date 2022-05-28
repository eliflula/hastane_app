namespace Hastane.App.Forms
{
    partial class DoktorPoli
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtPolAdres = new System.Windows.Forms.TextBox();
            this.txtPolAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDocSoyad = new System.Windows.Forms.TextBox();
            this.txtDocAdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPol = new System.Windows.Forms.ComboBox();
            this.btnDoktorEkle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.txtPolAdres);
            this.groupBox1.Controls.Add(this.txtPolAdi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 255);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Poliklinik Ekle";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(128, 173);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(167, 38);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtPolAdres
            // 
            this.txtPolAdres.Location = new System.Drawing.Point(104, 102);
            this.txtPolAdres.Name = "txtPolAdres";
            this.txtPolAdres.Size = new System.Drawing.Size(132, 20);
            this.txtPolAdres.TabIndex = 1;
            // 
            // txtPolAdi
            // 
            this.txtPolAdi.Location = new System.Drawing.Point(104, 59);
            this.txtPolAdi.Name = "txtPolAdi";
            this.txtPolAdi.Size = new System.Drawing.Size(132, 20);
            this.txtPolAdi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(23, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Adres :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(23, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDoktorEkle);
            this.groupBox2.Controls.Add(this.txtDocSoyad);
            this.groupBox2.Controls.Add(this.txtDocAdi);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cmbPol);
            this.groupBox2.Location = new System.Drawing.Point(379, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(311, 255);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Doktor Ekle";
            // 
            // txtDocSoyad
            // 
            this.txtDocSoyad.Location = new System.Drawing.Point(109, 133);
            this.txtDocSoyad.Name = "txtDocSoyad";
            this.txtDocSoyad.Size = new System.Drawing.Size(121, 20);
            this.txtDocSoyad.TabIndex = 2;
            // 
            // txtDocAdi
            // 
            this.txtDocAdi.Location = new System.Drawing.Point(109, 86);
            this.txtDocAdi.Name = "txtDocAdi";
            this.txtDocAdi.Size = new System.Drawing.Size(121, 20);
            this.txtDocAdi.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(27, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Soyadı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(27, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(27, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Poliklinik :";
            // 
            // cmbPol
            // 
            this.cmbPol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPol.FormattingEnabled = true;
            this.cmbPol.Location = new System.Drawing.Point(109, 35);
            this.cmbPol.Name = "cmbPol";
            this.cmbPol.Size = new System.Drawing.Size(121, 21);
            this.cmbPol.TabIndex = 0;
            // 
            // btnDoktorEkle
            // 
            this.btnDoktorEkle.Location = new System.Drawing.Point(109, 185);
            this.btnDoktorEkle.Name = "btnDoktorEkle";
            this.btnDoktorEkle.Size = new System.Drawing.Size(167, 38);
            this.btnDoktorEkle.TabIndex = 2;
            this.btnDoktorEkle.Text = "Ekle";
            this.btnDoktorEkle.UseVisualStyleBackColor = true;
            this.btnDoktorEkle.Click += new System.EventHandler(this.btnDoktorEkle_Click);
            // 
            // DoktorPoli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 340);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DoktorPoli";
            this.Text = "DoktorPoli";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DoktorPoli_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPolAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPolAdres;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtDocSoyad;
        private System.Windows.Forms.TextBox txtDocAdi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPol;
        private System.Windows.Forms.Button btnDoktorEkle;
    }
}