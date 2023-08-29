namespace Bingo
{
    partial class UCBola
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCBola));
            this.lblBola = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBola
            // 
            this.lblBola.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBola.ForeColor = System.Drawing.Color.LightGray;
            this.lblBola.Location = new System.Drawing.Point(0, 0);
            this.lblBola.Name = "lblBola";
            this.lblBola.Size = new System.Drawing.Size(50, 50);
            this.lblBola.TabIndex = 0;
            this.lblBola.Text = "01";
            this.lblBola.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UCBola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lblBola);
            this.DoubleBuffered = true;
            this.Name = "UCBola";
            this.Size = new System.Drawing.Size(50, 50);
            this.Resize += new System.EventHandler(this.UCBola_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBola;
    }
}
