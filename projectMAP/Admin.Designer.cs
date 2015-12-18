namespace projectMAP
{
    partial class Admin
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
            this.lstPublicatiiAdmin = new System.Windows.Forms.ListBox();
            this.txtNumePublicatie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddPublicatie = new System.Windows.Forms.Button();
            this.lstUseriActivi = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstPublicatiiAdmin
            // 
            this.lstPublicatiiAdmin.FormattingEnabled = true;
            this.lstPublicatiiAdmin.Location = new System.Drawing.Point(12, 12);
            this.lstPublicatiiAdmin.Name = "lstPublicatiiAdmin";
            this.lstPublicatiiAdmin.Size = new System.Drawing.Size(265, 251);
            this.lstPublicatiiAdmin.TabIndex = 0;
            // 
            // txtNumePublicatie
            // 
            this.txtNumePublicatie.Location = new System.Drawing.Point(12, 282);
            this.txtNumePublicatie.Name = "txtNumePublicatie";
            this.txtNumePublicatie.Size = new System.Drawing.Size(374, 20);
            this.txtNumePublicatie.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nume publicatie";
            // 
            // btnAddPublicatie
            // 
            this.btnAddPublicatie.Location = new System.Drawing.Point(236, 308);
            this.btnAddPublicatie.Name = "btnAddPublicatie";
            this.btnAddPublicatie.Size = new System.Drawing.Size(150, 20);
            this.btnAddPublicatie.TabIndex = 3;
            this.btnAddPublicatie.Text = "Adaugă publicaţie";
            this.btnAddPublicatie.UseVisualStyleBackColor = true;
            this.btnAddPublicatie.Click += new System.EventHandler(this.btnAddPublicatie_Click);
            // 
            // lstUseriActivi
            // 
            this.lstUseriActivi.FormattingEnabled = true;
            this.lstUseriActivi.Location = new System.Drawing.Point(291, 25);
            this.lstUseriActivi.Name = "lstUseriActivi";
            this.lstUseriActivi.Size = new System.Drawing.Size(95, 238);
            this.lstUseriActivi.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Useri activi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Autor";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(50, 308);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(180, 20);
            this.txtAutor.TabIndex = 7;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 345);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstUseriActivi);
            this.Controls.Add(this.btnAddPublicatie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumePublicatie);
            this.Controls.Add(this.lstPublicatiiAdmin);
            this.Name = "Admin";
            this.Text = "Administrator";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPublicatiiAdmin;
        private System.Windows.Forms.TextBox txtNumePublicatie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddPublicatie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAutor;
        public System.Windows.Forms.ListBox lstUseriActivi;
    }
}