namespace Hastane.App.Forms
{
    partial class IlacDepo
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
            this.txtIlacAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nmbAdet = new System.Windows.Forms.NumericUpDown();
            this.txtSeriNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKayit = new System.Windows.Forms.Button();
            this.dataIlac = new System.Windows.Forms.DataGridView();
            this.txtSorguAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSorgula = new System.Windows.Forms.Button();
            this.btnGridRefresh = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataIlac)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKayit);
            this.groupBox1.Controls.Add(this.txtSeriNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nmbAdet);
            this.groupBox1.Controls.Add(this.txtIlacAdi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 215);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İLAÇ KAYIT";
            // 
            // txtIlacAdi
            // 
            this.txtIlacAdi.Location = new System.Drawing.Point(128, 34);
            this.txtIlacAdi.Name = "txtIlacAdi";
            this.txtIlacAdi.Size = new System.Drawing.Size(135, 20);
            this.txtIlacAdi.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(44, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "İlaç Adı: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(44, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Adet:";
            // 
            // nmbAdet
            // 
            this.nmbAdet.Location = new System.Drawing.Point(128, 70);
            this.nmbAdet.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.nmbAdet.Name = "nmbAdet";
            this.nmbAdet.Size = new System.Drawing.Size(135, 20);
            this.nmbAdet.TabIndex = 9;
            // 
            // txtSeriNo
            // 
            this.txtSeriNo.Location = new System.Drawing.Point(128, 110);
            this.txtSeriNo.Name = "txtSeriNo";
            this.txtSeriNo.Size = new System.Drawing.Size(135, 20);
            this.txtSeriNo.TabIndex = 10;
            this.txtSeriNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSeriNo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(44, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Seri No :";
            // 
            // btnKayit
            // 
            this.btnKayit.Location = new System.Drawing.Point(139, 146);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(176, 47);
            this.btnKayit.TabIndex = 12;
            this.btnKayit.Text = "Kayıt";
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // dataIlac
            // 
            this.dataIlac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataIlac.Location = new System.Drawing.Point(406, 12);
            this.dataIlac.Name = "dataIlac";
            this.dataIlac.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataIlac.Size = new System.Drawing.Size(525, 469);
            this.dataIlac.TabIndex = 1;
            this.dataIlac.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataIlac_CellClick);
            // 
            // txtSorguAdi
            // 
            this.txtSorguAdi.Location = new System.Drawing.Point(128, 40);
            this.txtSorguAdi.Name = "txtSorguAdi";
            this.txtSorguAdi.Size = new System.Drawing.Size(135, 20);
            this.txtSorguAdi.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(44, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "İlaç Adı: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSorgula);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtSorguAdi);
            this.groupBox2.Location = new System.Drawing.Point(12, 243);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 159);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İlaç Sorgula";
            // 
            // btnSorgula
            // 
            this.btnSorgula.Location = new System.Drawing.Point(139, 77);
            this.btnSorgula.Name = "btnSorgula";
            this.btnSorgula.Size = new System.Drawing.Size(190, 36);
            this.btnSorgula.TabIndex = 13;
            this.btnSorgula.Text = "Sorgula";
            this.btnSorgula.UseVisualStyleBackColor = true;
            this.btnSorgula.Click += new System.EventHandler(this.btnSorgula_Click);
            // 
            // btnGridRefresh
            // 
            this.btnGridRefresh.Location = new System.Drawing.Point(702, 510);
            this.btnGridRefresh.Name = "btnGridRefresh";
            this.btnGridRefresh.Size = new System.Drawing.Size(229, 50);
            this.btnGridRefresh.TabIndex = 12;
            this.btnGridRefresh.Text = "Tabloyu Yenile";
            this.btnGridRefresh.UseVisualStyleBackColor = true;
            this.btnGridRefresh.Click += new System.EventHandler(this.btnGridRefresh_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(12, 430);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(335, 130);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İlaç Sil";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 36);
            this.button1.TabIndex = 13;
            this.button1.Text = "Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(38, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(277, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Silmek istediğiniz ilacı tablodan seçiniz";
            // 
            // IlacDepo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 572);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnGridRefresh);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataIlac);
            this.Controls.Add(this.groupBox1);
            this.Name = "IlacDepo";
            this.Text = "IlacDepo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IlacDepo_FormClosing);
            this.Load += new System.EventHandler(this.IlacDepo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataIlac)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtIlacAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSeriNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmbAdet;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.DataGridView dataIlac;
        private System.Windows.Forms.TextBox txtSorguAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSorgula;
        private System.Windows.Forms.Button btnGridRefresh;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}