using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bingo
{
    public partial class UCBola : UserControl
    {
        public override String Text
        {
            get
            {
                return lblBola.Text;
            }
            set
            {
                lblBola.Text = value;
            }
        }

        public override Color ForeColor
        {
            get
            {
                return lblBola.ForeColor;
            }
            set
            {
                lblBola.ForeColor = value;
            }
        }

        public ContentAlignment TextAlign
        {
            get
            {
                return lblBola.TextAlign;
            }
            set
            {
                lblBola.TextAlign = value;
            }
        }

        public UCBola()
        {
            InitializeComponent();
        }

        private void UCBola_Resize(object sender, EventArgs e)
        {
            lblBola.Font = new Font(lblBola.Font.FontFamily, (float)(Size.Width * 0.45));
        }
    }
}
