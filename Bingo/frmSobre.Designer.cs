namespace Bingo
{
    partial class frmSobre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSobre));
            this.btnOK = new System.Windows.Forms.Button();
            this.picSatoru = new System.Windows.Forms.PictureBox();
            this.lblTexto = new System.Windows.Forms.Label();
            this.lblSatoru = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picSatoru)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(438, 303);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(111, 38);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            this.btnOK.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnOK_KeyDown);
            // 
            // picSatoru
            // 
            this.picSatoru.BackColor = System.Drawing.Color.Transparent;
            this.picSatoru.Image = global::Bingo.Properties.Resources.fotoSobre;
            this.picSatoru.Location = new System.Drawing.Point(24, 23);
            this.picSatoru.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picSatoru.Name = "picSatoru";
            this.picSatoru.Size = new System.Drawing.Size(60, 60);
            this.picSatoru.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picSatoru.TabIndex = 1;
            this.picSatoru.TabStop = false;
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblTexto.Location = new System.Drawing.Point(24, 129);
            this.lblTexto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(56, 22);
            this.lblTexto.TabIndex = 2;
            this.lblTexto.Text = "Bingo";
            // 
            // lblSatoru
            // 
            this.lblSatoru.AutoSize = true;
            this.lblSatoru.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblSatoru.Location = new System.Drawing.Point(136, 23);
            this.lblSatoru.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSatoru.Name = "lblSatoru";
            this.lblSatoru.Size = new System.Drawing.Size(121, 24);
            this.lblSatoru.TabIndex = 3;
            this.lblSatoru.Text = "Satoru Kishi";
            // 
            // frmSobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(570, 355);
            this.Controls.Add(this.lblSatoru);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.picSatoru);
            this.Controls.Add(this.btnOK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSobre";
            this.Text = "Sobre o Bingo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSobre_FormClosing);
            this.Load += new System.EventHandler(this.frmSobre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSatoru)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.PictureBox picSatoru;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Label lblSatoru;
    }
}