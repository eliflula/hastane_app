namespace Hastane.App.Forms
{
    partial class AnaMenu
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnServis = new System.Windows.Forms.Button();
            this.btnDoktorPoli = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(66, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 70);
            this.button1.TabIndex = 0;
            this.button1.Text = "Hasta Kayıt";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(66, 320);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(202, 70);
            this.button2.TabIndex = 0;
            this.button2.Text = "Depo/Eczane";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnServis
            // 
            this.btnServis.BackColor = System.Drawing.Color.White;
            this.btnServis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServis.Location = new System.Drawing.Point(66, 215);
            this.btnServis.Name = "btnServis";
            this.btnServis.Size = new System.Drawing.Size(202, 70);
            this.btnServis.TabIndex = 0;
            this.btnServis.Text = "Hasta Servisi";
            this.btnServis.UseVisualStyleBackColor = false;
            this.btnServis.Click += new System.EventHandler(this.btnServis_Click);
            // 
            // btnDoktorPoli
            // 
            this.btnDoktorPoli.BackColor = System.Drawing.Color.White;
            this.btnDoktorPoli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoktorPoli.Location = new System.Drawing.Point(66, 12);
            this.btnDoktorPoli.Name = "btnDoktorPoli";
            this.btnDoktorPoli.Size = new System.Drawing.Size(202, 70);
            this.btnDoktorPoli.TabIndex = 0;
            this.btnDoktorPoli.Text = "Poliklinik/Doktor";
            this.btnDoktorPoli.UseVisualStyleBackColor = false;
            this.btnDoktorPoli.Click += new System.EventHandler(this.btnDoktorPoli_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(291, 412);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(40, 23);
            this.btnInfo.TabIndex = 1;
            this.btnInfo.Text = "?";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(231, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tıkla --->";
            // 
            // AnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(343, 447);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnDoktorPoli);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnServis);
            this.Controls.Add(this.button1);
            this.Name = "AnaMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnServis;
        private System.Windows.Forms.Button btnDoktorPoli;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Label label1;
    }
}