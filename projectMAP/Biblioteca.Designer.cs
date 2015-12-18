namespace projectMAP
{
    partial class Biblioteca
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
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnAbonat = new System.Windows.Forms.Button();
            this.grBoxAbonat = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.grBoxAbonat.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(22, 46);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnAdmin.TabIndex = 0;
            this.btnAdmin.Text = "Administrator";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnAbonat
            // 
            this.btnAbonat.Location = new System.Drawing.Point(166, 19);
            this.btnAbonat.Name = "btnAbonat";
            this.btnAbonat.Size = new System.Drawing.Size(89, 23);
            this.btnAbonat.TabIndex = 1;
            this.btnAbonat.Text = "Abonează-mă";
            this.btnAbonat.UseVisualStyleBackColor = true;
            this.btnAbonat.Click += new System.EventHandler(this.btnAbonat_Click);
            // 
            // grBoxAbonat
            // 
            this.grBoxAbonat.Controls.Add(this.label1);
            this.grBoxAbonat.Controls.Add(this.txtNume);
            this.grBoxAbonat.Controls.Add(this.btnAbonat);
            this.grBoxAbonat.Location = new System.Drawing.Point(137, 27);
            this.grBoxAbonat.Name = "grBoxAbonat";
            this.grBoxAbonat.Size = new System.Drawing.Size(275, 57);
            this.grBoxAbonat.TabIndex = 2;
            this.grBoxAbonat.TabStop = false;
            this.grBoxAbonat.Text = "Inregistrare abonat nou";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nume";
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(53, 21);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(107, 20);
            this.txtNume.TabIndex = 2;
            // 
            // Biblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 124);
            this.Controls.Add(this.grBoxAbonat);
            this.Controls.Add(this.btnAdmin);
            this.Name = "Biblioteca";
            this.Text = "Biblioteca";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Selectie_FormClosing);
            this.grBoxAbonat.ResumeLayout(false);
            this.grBoxAbonat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnAbonat;
        private System.Windows.Forms.GroupBox grBoxAbonat;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Label label1;
    }
}

