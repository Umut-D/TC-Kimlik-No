namespace TcKimlikNo
{
    partial class FrmTopluTest
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
            this.txtListe = new System.Windows.Forms.TextBox();
            this.BtnTopluAktar = new System.Windows.Forms.Button();
            this.lblBilgi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtListe
            // 
            this.txtListe.Location = new System.Drawing.Point(15, 63);
            this.txtListe.Margin = new System.Windows.Forms.Padding(4);
            this.txtListe.Multiline = true;
            this.txtListe.Name = "txtListe";
            this.txtListe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtListe.Size = new System.Drawing.Size(260, 134);
            this.txtListe.TabIndex = 0;
            // 
            // BtnTopluAktar
            // 
            this.BtnTopluAktar.Location = new System.Drawing.Point(15, 204);
            this.BtnTopluAktar.Name = "BtnTopluAktar";
            this.BtnTopluAktar.Size = new System.Drawing.Size(261, 23);
            this.BtnTopluAktar.TabIndex = 1;
            this.BtnTopluAktar.Text = "Toplu Aktar";
            this.BtnTopluAktar.UseVisualStyleBackColor = true;
            this.BtnTopluAktar.Click += new System.EventHandler(this.BtnTopluTest_Click);
            // 
            // lblBilgi
            // 
            this.lblBilgi.Location = new System.Drawing.Point(12, 2);
            this.lblBilgi.Name = "lblBilgi";
            this.lblBilgi.Size = new System.Drawing.Size(264, 57);
            this.lblBilgi.TabIndex = 2;
            this.lblBilgi.Text = "TC Kimlik Numaralarını alt alta gelecek şekilde ekleyin ve Toplu Aktar\'a basın. D" +
    "oğru olanlar listeye otomatik olarak eklenecektir.";
            this.lblBilgi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmTopluTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 237);
            this.Controls.Add(this.lblBilgi);
            this.Controls.Add(this.BtnTopluAktar);
            this.Controls.Add(this.txtListe);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTopluTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Aktar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtListe;
        private System.Windows.Forms.Button BtnTopluAktar;
        private System.Windows.Forms.Label lblBilgi;
    }
}