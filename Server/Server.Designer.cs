namespace Server
{
    partial class Server
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
            this.lbUlogovaniKorisnici = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDisconnectClient = new System.Windows.Forms.Button();
            this.btnRefreshClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbUlogovaniKorisnici
            // 
            this.lbUlogovaniKorisnici.FormattingEnabled = true;
            this.lbUlogovaniKorisnici.Location = new System.Drawing.Point(15, 48);
            this.lbUlogovaniKorisnici.Name = "lbUlogovaniKorisnici";
            this.lbUlogovaniKorisnici.Size = new System.Drawing.Size(246, 134);
            this.lbUlogovaniKorisnici.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista ulogovanih korisnika";
            // 
            // btnDisconnectClient
            // 
            this.btnDisconnectClient.Location = new System.Drawing.Point(267, 48);
            this.btnDisconnectClient.Name = "btnDisconnectClient";
            this.btnDisconnectClient.Size = new System.Drawing.Size(95, 23);
            this.btnDisconnectClient.TabIndex = 2;
            this.btnDisconnectClient.Text = "disconnect client";
            this.btnDisconnectClient.UseVisualStyleBackColor = true;
            this.btnDisconnectClient.Click += new System.EventHandler(this.btnDisconnectClient_Click);
            // 
            // btnRefreshClient
            // 
            this.btnRefreshClient.Location = new System.Drawing.Point(267, 91);
            this.btnRefreshClient.Name = "btnRefreshClient";
            this.btnRefreshClient.Size = new System.Drawing.Size(95, 23);
            this.btnRefreshClient.TabIndex = 3;
            this.btnRefreshClient.Text = "Refresh clients";
            this.btnRefreshClient.UseVisualStyleBackColor = true;
            this.btnRefreshClient.Click += new System.EventHandler(this.btnRefreshClient_Click);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 262);
            this.Controls.Add(this.btnRefreshClient);
            this.Controls.Add(this.btnDisconnectClient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbUlogovaniKorisnici);
            this.Name = "Server";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbUlogovaniKorisnici;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDisconnectClient;
        private System.Windows.Forms.Button btnRefreshClient;
    }
}



