namespace Klijent
{
    partial class Klijent
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
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtImeIPrezime = new System.Windows.Forms.TextBox();
            this.txtBrojIndeksa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPronadjenImeIPrezime = new System.Windows.Forms.TextBox();
            this.txtPronadjenBrojIndeksa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPronadji = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPronadji = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnOsvezi = new System.Windows.Forms.Button();
            this.dgvSpisakStudenata = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpisakStudenata)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDodaj);
            this.groupBox1.Controls.Add(this.txtImeIPrezime);
            this.groupBox1.Controls.Add(this.txtBrojIndeksa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 261);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodaj studenta";
            // 
            // btnDodaj
            // 
            this.btnDodaj.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDodaj.Location = new System.Drawing.Point(65, 157);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 4;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtImeIPrezime
            // 
            this.txtImeIPrezime.Location = new System.Drawing.Point(121, 89);
            this.txtImeIPrezime.Name = "txtImeIPrezime";
            this.txtImeIPrezime.Size = new System.Drawing.Size(100, 20);
            this.txtImeIPrezime.TabIndex = 3;
            // 
            // txtBrojIndeksa
            // 
            this.txtBrojIndeksa.Location = new System.Drawing.Point(121, 42);
            this.txtBrojIndeksa.Name = "txtBrojIndeksa";
            this.txtBrojIndeksa.Size = new System.Drawing.Size(100, 20);
            this.txtBrojIndeksa.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ime i prezime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Broj Indeksa";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPronadjenImeIPrezime);
            this.groupBox2.Controls.Add(this.txtPronadjenBrojIndeksa);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtPronadji);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnPronadji);
            this.groupBox2.Location = new System.Drawing.Point(298, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 261);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pronadji studenta";
            // 
            // txtPronadjenImeIPrezime
            // 
            this.txtPronadjenImeIPrezime.Location = new System.Drawing.Point(40, 197);
            this.txtPronadjenImeIPrezime.Name = "txtPronadjenImeIPrezime";
            this.txtPronadjenImeIPrezime.ReadOnly = true;
            this.txtPronadjenImeIPrezime.Size = new System.Drawing.Size(100, 20);
            this.txtPronadjenImeIPrezime.TabIndex = 5;
            // 
            // txtPronadjenBrojIndeksa
            // 
            this.txtPronadjenBrojIndeksa.Location = new System.Drawing.Point(40, 160);
            this.txtPronadjenBrojIndeksa.Name = "txtPronadjenBrojIndeksa";
            this.txtPronadjenBrojIndeksa.ReadOnly = true;
            this.txtPronadjenBrojIndeksa.Size = new System.Drawing.Size(100, 20);
            this.txtPronadjenBrojIndeksa.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pronadjen student";
            // 
            // txtPronadji
            // 
            this.txtPronadji.Location = new System.Drawing.Point(94, 32);
            this.txtPronadji.Name = "txtPronadji";
            this.txtPronadji.Size = new System.Drawing.Size(100, 20);
            this.txtPronadji.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Broj indeksa";
            // 
            // btnPronadji
            // 
            this.btnPronadji.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPronadji.Location = new System.Drawing.Point(55, 77);
            this.btnPronadji.Name = "btnPronadji";
            this.btnPronadji.Size = new System.Drawing.Size(75, 23);
            this.btnPronadji.TabIndex = 0;
            this.btnPronadji.Text = "Pronadji";
            this.btnPronadji.UseVisualStyleBackColor = true;
            this.btnPronadji.Click += new System.EventHandler(this.btnPronadji_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnOsvezi);
            this.groupBox3.Controls.Add(this.dgvSpisakStudenata);
            this.groupBox3.Location = new System.Drawing.Point(524, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(408, 261);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Spisak studenata";
            // 
            // btnOsvezi
            // 
            this.btnOsvezi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOsvezi.Location = new System.Drawing.Point(174, 230);
            this.btnOsvezi.Name = "btnOsvezi";
            this.btnOsvezi.Size = new System.Drawing.Size(75, 23);
            this.btnOsvezi.TabIndex = 1;
            this.btnOsvezi.Text = "Osvezi";
            this.btnOsvezi.UseVisualStyleBackColor = true;
            this.btnOsvezi.Click += new System.EventHandler(this.btnOsvezi_Click);
            // 
            // dgvSpisakStudenata
            // 
            this.dgvSpisakStudenata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpisakStudenata.Location = new System.Drawing.Point(6, 19);
            this.dgvSpisakStudenata.Name = "dgvSpisakStudenata";
            this.dgvSpisakStudenata.Size = new System.Drawing.Size(387, 198);
            this.dgvSpisakStudenata.TabIndex = 0;
            // 
            // Klijent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 298);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Klijent";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Klijent_FormClosing);
            this.Load += new System.EventHandler(this.Klijent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpisakStudenata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtImeIPrezime;
        private System.Windows.Forms.TextBox txtBrojIndeksa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPronadjenImeIPrezime;
        private System.Windows.Forms.TextBox txtPronadjenBrojIndeksa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPronadji;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPronadji;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnOsvezi;
        private System.Windows.Forms.DataGridView dgvSpisakStudenata;
    }
}



