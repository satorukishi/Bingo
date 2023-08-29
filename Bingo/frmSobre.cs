using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bingo
{
    public partial class frmSobre : Form
    {
        private string[] args;
        public frmSobre()
        {
            InitializeComponent();
        }
        public frmSobre(string[] args):this()
        {
            this.args = args;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Visible = false;
            frmBingo bingo = new frmBingo(args);
            bingo.ShowDialog();
            this.Close();
        }

        private void frmSobre_Load(object sender, EventArgs e)
        {
            lblTexto.Text =
@"Bingo - Versão 2014 (Compilação 1.0.1.2)
Licenciado para:

Interkaikans Beneficente,

Oroku Tabaru Yuwa-Kai de Vila Carrão e

Seinenkai de Vila Carrão.";
        }

        private void btnOK_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
            {

                this.Close();
            }
        }
    }
}
