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
        private IWin32Window _owner;

        public frmSobre(IWin32Window owner)
        {
            _owner = owner;
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Visible = false;
            this.Close();
        }

        private void frmSobre_Load(object sender, EventArgs e)
        {
            lblTexto.Text =
@"Bingo - Versão 2023 (Compilação 1.0.2.0)
Licenciado para:
Interkaikans Beneficente,
Oroku Tabaru Yuwa-Kai de Vila Carrão,
Seinenkai de Vila Carrão e
Seinen-bu Mogi";
        }

        private void btnOK_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyValue == 27) // Esc
            {
                this.Close();
            }
        }

        private void frmSobre_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_owner == null)
            {
                frmBingo bingo = new frmBingo();
                bingo.ShowDialog();
            }
        }
    }
}
