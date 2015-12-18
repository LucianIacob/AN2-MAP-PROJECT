namespace projectMAP
{
    partial class Abonat
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
            this.lstPublicatiiAbonati = new System.Windows.Forms.ListBox();
            this.btnRezerva = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstPublicatiiAbonati
            // 
            this.lstPublicatiiAbonati.FormattingEnabled = true;
            this.lstPublicatiiAbonati.Location = new System.Drawing.Point(12, 12);
            this.lstPublicatiiAbonati.Name = "lstPublicatiiAbonati";
            this.lstPublicatiiAbonati.Size = new System.Drawing.Size(330, 264);
            this.lstPublicatiiAbonati.TabIndex = 0;
            // 
            // btnRezerva
            // 
            this.btnRezerva.Location = new System.Drawing.Point(12, 282);
            this.btnRezerva.Name = "btnRezerva";
            this.btnRezerva.Size = new System.Drawing.Size(330, 34);
            this.btnRezerva.TabIndex = 1;
            this.btnRezerva.Text = "Rezerva";
            this.btnRezerva.UseVisualStyleBackColor = true;
            this.btnRezerva.Click += new System.EventHandler(this.btnRezerva_Click);
            // 
            // Abonat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 331);
            this.Controls.Add(this.btnRezerva);
            this.Controls.Add(this.lstPublicatiiAbonati);
            this.Name = "Abonat";
            this.Text = "Abonat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Abonat_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstPublicatiiAbonati;
        private System.Windows.Forms.Button btnRezerva;
    }
}