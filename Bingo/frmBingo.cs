using System;
using System.Collections.Generic;
using System.ComponentModel;
using cm = System.Configuration.ConfigurationManager;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Bingo
{
    public partial class frmBingo : Form
    {
        private static Color corBolaAtual = Color.Red;
        private static Color corBolaOculta = Color.LightGray;
        private static Color corBolaJaSelecionada = Color.Black;
        private System.Windows.Forms.Label _ultimaBolaSorteada;
        private List<Label> _bolasB = new List<Label>(15);
        private List<Label> _bolasI = new List<Label>(15);
        private List<Label> _bolasN = new List<Label>(15);
        private List<Label> _bolasG = new List<Label>(15);
        private List<Label> _bolasO = new List<Label>(15);
        private int _posicaoPatrocinio = 0;

        private List<Image> _lstPatrocinadores;

        public frmBingo()
        {
            InitializeComponent();
        }

        public frmBingo(string[] args)
            : this()
        {
            try
            {
                BackgroundImage = Image.FromFile(Path.Combine(Application.StartupPath, string.Format("img\\bg_{0}.png", cm.AppSettings["nome_cliente"])));
            }
            catch (Exception)
            {
                throw;
            }
        }

        #region Private Methods
        private void AnimarBola(Label bolaSelecionada_, Animacao animacao_)
        {
            switch (animacao_)
            {
                case Animacao.Desmarcar:
                    bolaSelecionada_.ForeColor = corBolaOculta;
                    break;
                case Animacao.Focar:
                    bolaSelecionada_.ForeColor = corBolaAtual;
                    break;
                case Animacao.Marcar:
                    bolaSelecionada_.ForeColor = corBolaJaSelecionada;
                    break;
                default:
                    throw new InvalidEnumArgumentException("Animação não suportada");
            }
        }

        private void MarcarBola(Label bolaSelecionada_)
        {
            if (_ultimaBolaSorteada != null)
            {
                AnimarBola(_ultimaBolaSorteada, Animacao.Marcar);
            }

            _ultimaBolaSorteada = bolaSelecionada_;
            AnimarBola(bolaSelecionada_, Animacao.Focar);

            lblUltimaBola.Text = bolaSelecionada_.Text;
            AnimarBola(lblUltimaBola, Animacao.Focar);
        }

        private void CentralizarBINGO()
        {
            int centroDoPanel = ((int)(pnlB.Size.Height / 2)) - (int)(lblB.Size.Height / 2);
            lblB.Location = new Point(25, centroDoPanel);
            lblI.Location = new Point(25, centroDoPanel);
            lblN.Location = new Point(25, centroDoPanel);
            lblG.Location = new Point(25, centroDoPanel);
            lblO.Location = new Point(25, centroDoPanel);
        }

        private void CentralizarBolas(Panel p_, List<Label> bolas_)
        {
            float porcentagemDistancia = 0.059375f;
            int centroDoPanel = ((int)(p_.Size.Height / 2)) - 25;

            bolas_[0].Location = new Point(82, centroDoPanel);
            for (int i = 1; i < bolas_.Count; i++)
            {
                bolas_[i].Location = new Point(82 + (int)(p_.Size.Width * porcentagemDistancia * i + 1), centroDoPanel);
            }
        }

        private void DesmarcarBola(Label bolaSelecionada_)
        {
            //Como a última bola selecionada será cancelada, então fica null
            if (bolaSelecionada_ == _ultimaBolaSorteada)
            {
                _ultimaBolaSorteada = null;
                lblUltimaBola.Text = "00";
                AnimarBola(lblUltimaBola, Animacao.Desmarcar);
            }
            AnimarBola(bolaSelecionada_, Animacao.Desmarcar);

        }

        private void FecharBingo(FormClosingEventArgs e)
        {
            Debug.Print(e.GetType().FullName);
            if (DialogResult.No == MessageBox.Show("Deseja realmente fechar o programa?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                e.Cancel = true;
            }
        }

        private void InicializarBolas()
        {
            _bolasB.Add(lblBola1);
            _bolasB.Add(lblBola2);
            _bolasB.Add(lblBola3);
            _bolasB.Add(lblBola4);
            _bolasB.Add(lblBola5);
            _bolasB.Add(lblBola6);
            _bolasB.Add(lblBola7);
            _bolasB.Add(lblBola8);
            _bolasB.Add(lblBola9);
            _bolasB.Add(lblBola10);
            _bolasB.Add(lblBola11);
            _bolasB.Add(lblBola12);
            _bolasB.Add(lblBola13);
            _bolasB.Add(lblBola14);
            _bolasB.Add(lblBola15);
            _bolasI.Add(lblBola16);
            _bolasI.Add(lblBola17);
            _bolasI.Add(lblBola18);
            _bolasI.Add(lblBola19);
            _bolasI.Add(lblBola20);
            _bolasI.Add(lblBola21);
            _bolasI.Add(lblBola22);
            _bolasI.Add(lblBola23);
            _bolasI.Add(lblBola24);
            _bolasI.Add(lblBola25);
            _bolasI.Add(lblBola26);
            _bolasI.Add(lblBola27);
            _bolasI.Add(lblBola28);
            _bolasI.Add(lblBola29);
            _bolasI.Add(lblBola30);
            _bolasN.Add(lblBola31);
            _bolasN.Add(lblBola32);
            _bolasN.Add(lblBola33);
            _bolasN.Add(lblBola34);
            _bolasN.Add(lblBola35);
            _bolasN.Add(lblBola36);
            _bolasN.Add(lblBola37);
            _bolasN.Add(lblBola38);
            _bolasN.Add(lblBola39);
            _bolasN.Add(lblBola40);
            _bolasN.Add(lblBola41);
            _bolasN.Add(lblBola42);
            _bolasN.Add(lblBola43);
            _bolasN.Add(lblBola44);
            _bolasN.Add(lblBola45);
            _bolasG.Add(lblBola46);
            _bolasG.Add(lblBola47);
            _bolasG.Add(lblBola48);
            _bolasG.Add(lblBola49);
            _bolasG.Add(lblBola50);
            _bolasG.Add(lblBola51);
            _bolasG.Add(lblBola52);
            _bolasG.Add(lblBola53);
            _bolasG.Add(lblBola54);
            _bolasG.Add(lblBola55);
            _bolasG.Add(lblBola56);
            _bolasG.Add(lblBola57);
            _bolasG.Add(lblBola58);
            _bolasG.Add(lblBola59);
            _bolasG.Add(lblBola60);
            _bolasO.Add(lblBola61);
            _bolasO.Add(lblBola62);
            _bolasO.Add(lblBola63);
            _bolasO.Add(lblBola64);
            _bolasO.Add(lblBola65);
            _bolasO.Add(lblBola66);
            _bolasO.Add(lblBola67);
            _bolasO.Add(lblBola68);
            _bolasO.Add(lblBola69);
            _bolasO.Add(lblBola70);
            _bolasO.Add(lblBola71);
            _bolasO.Add(lblBola72);
            _bolasO.Add(lblBola73);
            _bolasO.Add(lblBola74);
            _bolasO.Add(lblBola75);

        }

        /// <summary>
        /// Verifica se a bolaSelecionada_ já foi selecionada 
        /// </summary>
        /// <param name="bolaSelecionada_">A bola selecionada</param>
        /// <returns>False se a bolaSelecionada_ passada como parâmetro está oculta.</returns>
        private bool IsSelecionada(Label bolaSelecionada_)
        {
            if (bolaSelecionada_.ForeColor == corBolaOculta)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void NovaPartida()
        {
            lblUltimaBola.ForeColor = corBolaOculta;

            _ultimaBolaSorteada = null;
            foreach (Label bola in _bolasB)
            {
                bola.ForeColor = corBolaOculta;
            }
            foreach (Label bola in _bolasI)
            {
                bola.ForeColor = corBolaOculta;
            }
            foreach (Label bola in _bolasN)
            {
                bola.ForeColor = corBolaOculta;
            }
            foreach (Label bola in _bolasG)
            {
                bola.ForeColor = corBolaOculta;
            }
            foreach (Label bola in _bolasO)
            {
                bola.ForeColor = corBolaOculta;
            }
        }
        #endregion Private Methods

        private void frmBingo_Load(object sender, EventArgs e)
        {
            InicializarBolas();
            NovaPartida();
            mnuPrincipal.Visible = false;

            IniciarlizarPatrocinadore();
        }

        private void IniciarlizarPatrocinadore()
        {
            CarregarPatrocinadores();
            MudarPatrocinador();
        }

        private void MudarPatrocinador()
        {
            if (_lstPatrocinadores.Count == 0)
            {
                return;
            }

            if (_posicaoPatrocinio >= _lstPatrocinadores.Count)
            {
                _posicaoPatrocinio = 0;
            }
            picPatrocinador1.Image = _lstPatrocinadores[_posicaoPatrocinio++];


            if (_posicaoPatrocinio >= _lstPatrocinadores.Count)
            {
                _posicaoPatrocinio = 0;
            }
            picPatrocinador2.Image = _lstPatrocinadores[_posicaoPatrocinio++];
        }

        private void CarregarPatrocinadores()
        {
            try
            {
                string[] pathImagens = Directory.GetFiles(Path.Combine(Application.StartupPath, @"img\patrocinio\"));
                _lstPatrocinadores = new List<Image>(pathImagens.Length);

                foreach (string img in pathImagens)
                {
                    _lstPatrocinadores.Add(Image.FromFile(img));
                }
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("Os logos dos patrocinadores devem estar na pasta\r\nimg\\patrocinio");
            }
            catch (OutOfMemoryException)
            {
                MessageBox.Show("Um arquivo na pasta \"img\\patrocinio\" \r\nnão foi reconhecido como arquivo de imagem.");
            }
            catch (Exception)
            {
                MessageBox.Show("Erro desconhecido ao carregar os patrocinadores");
            }
        }

        private void frmBingo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && !mnuPrincipal.Visible)
            {
                mnuPrincipal.Visible = true;
            }
            //Se foi pressionado ESC && o menu está visível (se está com foco, então está visível também)
            else if (e.KeyValue == 27)
            {

                mnuPrincipal.Visible = false;
            }

        }

        private void frmBingo_FormClosing(object sender, FormClosingEventArgs e)
        {
            FecharBingo(e);
        }

        private void frmBingo_Click(object sender, EventArgs e)
        {
            mnuPrincipal.Visible = false;
        }

        private void mnuPrincipal_Leave(object sender, EventArgs e)
        {
            mnuPrincipal.Visible = false;
        }

        private void lblBola_DoubleClick(object sender, EventArgs e)
        {
            Label bolaSelecionada = (Label)sender;

            if (IsSelecionada(bolaSelecionada))
            {
                if (DialogResult.Yes == MessageBox.Show("Deseja realmente desmarcar o número " + bolaSelecionada.Text + "?", "Bola já sorteada", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {
                    DesmarcarBola(bolaSelecionada);
                }
            }
            else
            {
                MarcarBola(bolaSelecionada);
            }

            MudarPatrocinador();
        }

        private void mnuSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuNovaPartida_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Deseja realmente iniciar uma nova partida?", "Nova partida", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                NovaPartida();
            }
        }

        private void mnuSobre_Click(object sender, EventArgs e)
        {
            frmSobre telaSobre = new frmSobre();
            telaSobre.Show();
        }

        private void pnlB_SizeChanged(object sender, EventArgs e)
        {
            CentralizarBolas((Panel)sender, _bolasB);
            CentralizarBINGO();
        }

        private void pnlI_SizeChanged(object sender, EventArgs e)
        {
            CentralizarBolas((Panel)sender, _bolasI);
        }

        private void pnlN_SizeChanged(object sender, EventArgs e)
        {
            CentralizarBolas((Panel)sender, _bolasN);
        }

        private void pnlG_SizeChanged(object sender, EventArgs e)
        {
            CentralizarBolas((Panel)sender, _bolasG);
        }

        private void pnlO_SizeChanged(object sender, EventArgs e)
        {
            CentralizarBolas((Panel)sender, _bolasO);
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            #region Ajusta o tamanho dos Panel BINGO
            float porcentagemHeight = 0.09485095f;
            float porcentagemY = 0.03387534f;
            int width = splitContainer1.SplitterDistance - 50;
            int height = (int)(this.Size.Height * porcentagemHeight);
            Size novoTamanho = new Size(width, height);
            pnlB.Size = novoTamanho;
            pnlI.Size = novoTamanho;
            pnlN.Size = novoTamanho;
            pnlG.Size = novoTamanho;
            pnlO.Size = novoTamanho;
            #endregion Ajusta o tamanho dos Panel

            #region Ajusta o Location dos Panel BINGO
            int distanciaY = (int)(this.Size.Height * porcentagemY);
            int y = (int)(novoTamanho.Height + distanciaY);

            // pnlB.Location.Y = 66; <-- Sempre será o tamanho default configurado no form
            pnlI.Location = new Point(25, distanciaY + (y * 1));
            pnlN.Location = new Point(25, distanciaY + (y * 2));
            pnlG.Location = new Point(25, distanciaY + (y * 3));
            pnlO.Location = new Point(25, distanciaY + (y * 4));
            #endregion

            #region Tamanho das bolas
            float porcHeight = 0.57142857f;
            int bolaSize = (int)(pnlB.Size.Height * porcHeight);

            float porcHeightUB = 0.22189349f;
            int bolaSizeUB = (int)(splitContainer1.Size.Height * porcHeightUB);

            pnlUltimaBola.Size = new Size(bolaSizeUB, bolaSizeUB);

            pnlBola1.Size = new Size(bolaSize, bolaSize);
            pnlBola2.Size = new Size(bolaSize, bolaSize);
            pnlBola3.Size = new Size(bolaSize, bolaSize);
            pnlBola4.Size = new Size(bolaSize, bolaSize);
            pnlBola5.Size = new Size(bolaSize, bolaSize);
            pnlBola6.Size = new Size(bolaSize, bolaSize);
            pnlBola7.Size = new Size(bolaSize, bolaSize);
            pnlBola8.Size = new Size(bolaSize, bolaSize);
            pnlBola9.Size = new Size(bolaSize, bolaSize);
            pnlBola10.Size = new Size(bolaSize, bolaSize);
            pnlBola11.Size = new Size(bolaSize, bolaSize);
            pnlBola12.Size = new Size(bolaSize, bolaSize);
            pnlBola13.Size = new Size(bolaSize, bolaSize);
            pnlBola14.Size = new Size(bolaSize, bolaSize);
            pnlBola15.Size = new Size(bolaSize, bolaSize);
            pnlBola16.Size = new Size(bolaSize, bolaSize);
            pnlBola17.Size = new Size(bolaSize, bolaSize);
            pnlBola18.Size = new Size(bolaSize, bolaSize);
            pnlBola19.Size = new Size(bolaSize, bolaSize);
            pnlBola20.Size = new Size(bolaSize, bolaSize);
            pnlBola21.Size = new Size(bolaSize, bolaSize);
            pnlBola22.Size = new Size(bolaSize, bolaSize);
            pnlBola23.Size = new Size(bolaSize, bolaSize);
            pnlBola24.Size = new Size(bolaSize, bolaSize);
            pnlBola25.Size = new Size(bolaSize, bolaSize);
            pnlBola26.Size = new Size(bolaSize, bolaSize);
            pnlBola27.Size = new Size(bolaSize, bolaSize);
            pnlBola28.Size = new Size(bolaSize, bolaSize);
            pnlBola29.Size = new Size(bolaSize, bolaSize);
            pnlBola30.Size = new Size(bolaSize, bolaSize);
            pnlBola31.Size = new Size(bolaSize, bolaSize);
            pnlBola32.Size = new Size(bolaSize, bolaSize);
            pnlBola33.Size = new Size(bolaSize, bolaSize);
            pnlBola34.Size = new Size(bolaSize, bolaSize);
            pnlBola35.Size = new Size(bolaSize, bolaSize);
            pnlBola36.Size = new Size(bolaSize, bolaSize);
            pnlBola37.Size = new Size(bolaSize, bolaSize);
            pnlBola38.Size = new Size(bolaSize, bolaSize);
            pnlBola39.Size = new Size(bolaSize, bolaSize);
            pnlBola40.Size = new Size(bolaSize, bolaSize);
            pnlBola41.Size = new Size(bolaSize, bolaSize);
            pnlBola42.Size = new Size(bolaSize, bolaSize);
            pnlBola43.Size = new Size(bolaSize, bolaSize);
            pnlBola44.Size = new Size(bolaSize, bolaSize);
            pnlBola45.Size = new Size(bolaSize, bolaSize);
            pnlBola46.Size = new Size(bolaSize, bolaSize);
            pnlBola47.Size = new Size(bolaSize, bolaSize);
            pnlBola48.Size = new Size(bolaSize, bolaSize);
            pnlBola49.Size = new Size(bolaSize, bolaSize);
            pnlBola50.Size = new Size(bolaSize, bolaSize);
            pnlBola51.Size = new Size(bolaSize, bolaSize);
            pnlBola52.Size = new Size(bolaSize, bolaSize);
            pnlBola53.Size = new Size(bolaSize, bolaSize);
            pnlBola54.Size = new Size(bolaSize, bolaSize);
            pnlBola55.Size = new Size(bolaSize, bolaSize);
            pnlBola56.Size = new Size(bolaSize, bolaSize);
            pnlBola57.Size = new Size(bolaSize, bolaSize);
            pnlBola58.Size = new Size(bolaSize, bolaSize);
            pnlBola59.Size = new Size(bolaSize, bolaSize);
            pnlBola60.Size = new Size(bolaSize, bolaSize);
            pnlBola61.Size = new Size(bolaSize, bolaSize);
            pnlBola62.Size = new Size(bolaSize, bolaSize);
            pnlBola63.Size = new Size(bolaSize, bolaSize);
            pnlBola64.Size = new Size(bolaSize, bolaSize);
            pnlBola65.Size = new Size(bolaSize, bolaSize);
            pnlBola66.Size = new Size(bolaSize, bolaSize);
            pnlBola67.Size = new Size(bolaSize, bolaSize);
            pnlBola68.Size = new Size(bolaSize, bolaSize);
            pnlBola69.Size = new Size(bolaSize, bolaSize);
            pnlBola70.Size = new Size(bolaSize, bolaSize);
            pnlBola71.Size = new Size(bolaSize, bolaSize);
            pnlBola72.Size = new Size(bolaSize, bolaSize);
            pnlBola73.Size = new Size(bolaSize, bolaSize);
            pnlBola74.Size = new Size(bolaSize, bolaSize);
            pnlBola75.Size = new Size(bolaSize, bolaSize);
            #endregion Tamanho das bolas

            #region Tamanho da Fonte
            float porcFonte = 0.4f;
            float fontSize = (float)(lblBola1.Size.Height * porcFonte);

            lblUltimaBola.Font = new Font(lblUltimaBola.Font.FontFamily, (float)(lblUltimaBola.Size.Height * porcFonte));

            lblBola1.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola2.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola3.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola4.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola5.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola6.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola7.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola8.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola9.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola10.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola11.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola12.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola13.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola14.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola15.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola16.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola17.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola18.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola19.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola20.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola21.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola22.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola23.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola24.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola25.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola26.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola27.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola28.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola29.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola30.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola31.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola32.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola33.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola34.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola35.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola36.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola37.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola38.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola39.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola40.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola41.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola42.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola43.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola44.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola45.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola46.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola47.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola48.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola49.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola50.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola51.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola52.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola53.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola54.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola55.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola56.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola57.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola58.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola59.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola60.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola61.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola62.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola63.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola64.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola65.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola66.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola67.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola68.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola69.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola70.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola71.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola72.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola73.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola74.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            lblBola75.Font = new Font(lblBola1.Font.FontFamily, fontSize);
            #endregion Tamanho da Fonte

            #region Distancia entre as bolas
            int tamanhoBola = pnlBola1.Size.Width;
            float distancia = (float)(tamanhoBola * 0.125f);

            float xDistanciaUB = (float)(splitContainer1.SplitterDistance * 0.41065089f);
            float yDistanciaUB = (float)(splitContainer1.Size.Height * 0.73964497f);

            pnlUltimaBola.Location = new Point((int)xDistanciaUB, (int)yDistanciaUB);

            int i = 1;
            // Localizacao Inicial das bolas + (tamanho e distância). O primeiro de cada letra BINGO não entra no cálculo
            pnlBola2.Location = new Point(pnlBola1.Location.X + (int)(i++ * (tamanhoBola + distancia)), pnlBola2.Location.Y);
            pnlBola3.Location = new Point(pnlBola1.Location.X + (int)(i++ * (tamanhoBola + distancia)), pnlBola3.Location.Y);
            pnlBola4.Location = new Point(pnlBola1.Location.X + (int)(i++ * (tamanhoBola + distancia)), pnlBola4.Location.Y);
            pnlBola5.Location = new Point(pnlBola1.Location.X + (int)(i++ * (tamanhoBola + distancia)), pnlBola5.Location.Y);
            pnlBola6.Location = new Point(pnlBola1.Location.X + (int)(i++ * (tamanhoBola + distancia)), pnlBola6.Location.Y);
            pnlBola7.Location = new Point(pnlBola1.Location.X + (int)(i++ * (tamanhoBola + distancia)), pnlBola7.Location.Y);
            pnlBola8.Location = new Point(pnlBola1.Location.X + (int)(i++ * (tamanhoBola + distancia)), pnlBola8.Location.Y);
            pnlBola9.Location = new Point(pnlBola1.Location.X + (int)(i++ * (tamanhoBola + distancia)), pnlBola9.Location.Y);
            pnlBola10.Location = new Point(pnlBola1.Location.X + (int)(i++ * (tamanhoBola + distancia)), pnlBola10.Location.Y);
            pnlBola11.Location = new Point(pnlBola1.Location.X + (int)(i++ * (tamanhoBola + distancia)), pnlBola11.Location.Y);
            pnlBola12.Location = new Point(pnlBola1.Location.X + (int)(i++ * (tamanhoBola + distancia)), pnlBola12.Location.Y);
            pnlBola13.Location = new Point(pnlBola1.Location.X + (int)(i++ * (tamanhoBola + distancia)), pnlBola13.Location.Y);
            pnlBola14.Location = new Point(pnlBola1.Location.X + (int)(i++ * (tamanhoBola + distancia)), pnlBola14.Location.Y);
            pnlBola15.Location = new Point(pnlBola1.Location.X + (int)(i++ * (tamanhoBola + distancia)), pnlBola15.Location.Y);

            i = 1;
            pnlBola17.Location = new Point(pnlBola1.Location.X + (int)(i++ * (tamanhoBola + distancia)), pnlBola17.Location.Y);
            pnlBola18.Location = new Point(pnlBola1.Location.X + (int)(i++ * (tamanhoBola + distancia)), pnlBola18.Location.Y);
            pnlBola19.Location = new Point(pnlBola1.Location.X + (int)(i++ * (tamanhoBola + distancia)), pnlBola19.Location.Y);
            pnlBola20.Location = new Point(pnlBola1.Location.X + (int)(i++ * (tamanhoBola + distancia)), pnlBola20.Location.Y);
            pnlBola21.Location = new Point(pnlBola1.Location.X + (int)(i++ * (tamanhoBola + distancia)), pnlBola21.Location.Y);
            pnlBola22.Location = new Point(pnlBola1.Location.X + (int)(i++ * (tamanhoBola + distancia)), pnlBola22.Location.Y);
            pnlBola23.Location = new Point(pnlBola1.Location.X + (int)(i++ * (tamanhoBola + distancia)), pnlBola23.Location.Y);
            pnlBola24.Location = new Point(pnlBola1.Location.X + (int)(i++ * (tamanhoBola + distancia)), pnlBola24.Location.Y);
            pnlBola25.Location = new Point(pnlBola1.Location.X + (int)(i++ * (tamanhoBola + distancia)), pnlBola25.Location.Y);
            pnlBola26.Location = new Point(pnlBola1.Location.X + (int)(i++ * (tamanhoBola + distancia)), pnlBola26.Location.Y);
            pnlBola27.Location = new Point(pnlBola1.Location.X + (int)(i++ * (tamanhoBola + distancia)), pnlBola27.Location.Y);
            pnlBola28.Location = new Point(pnlBola1.Location.X + (int)(i++ * (tamanhoBola + distancia)), pnlBola28.Location.Y);
            pnlBola29.Location = new Point(pnlBola1.Location.X + (int)(i++ * (tamanhoBola + distancia)), pnlBola29.Location.Y);
            pnlBola30.Location = new Point(pnlBola1.Location.X + (int)(i++ * (tamanhoBola + distancia)), pnlBola30.Location.Y);
            i = 1;
            pnlBola32.Location = new Point(pnlBola1.Location.X + (int)(i++ * (tamanhoBola + distancia)), pnlBola32.Location.Y);
            pnlBola33.Location = new Point(pnlBola1.Location.X + (int)(i++ * (tamanhoBola + distancia)), pnlBola33.Location.Y);
            pnlBola34.Location = new Point(pnlBola1.Location.X + (int)(i++ * (tamanhoBola + distancia)), pnlBola34.Location.Y);
            pnlBola35.Location = new Point(pnlBola1.Location.X + (int)(i++ * (tamanhoBola + distancia)), pnlBola35.Location.Y);
            pnlBola36.Location = new Point(pnlBola1.Location.X + (int)(i++ * (tamanhoBola + distancia)), pnlBola36.Location.Y);
            pnlBola37.Location = new Point(pnlBola1.Location.X + (int)(i++ * (tamanhoBola + distancia)), pnlBola37.Location.Y);
            pnlBola38.Location = new Point(pnlBola1.Location.X + (int)(i++ * (tamanhoBola + distancia)), pnlBola38.Location.Y);
            pnlBola39.Location = new Point(pnlBola1.Location.X + (int)(i++ * (tamanhoBola + distancia)), pnlBola39.Location.Y);
            pnlBola40.Location = new Point(pnlBola1.Location.X + (int)(i++ * (tamanhoBola + distancia)), pnlBola40.Location.Y);
            pnlBola41.Location = new Point(pnlBola1.Location.X + (int)(i++ * (tamanhoBola + distancia)), pnlBola41.Location.Y);
            pnlBola42.Location = new Point(pnlBola1.Location.X + (int)(i++ * (tamanhoBola + distancia)), pnlBola42.Location.Y);
            pnlBola43.Location = new Point(pnlBola1.Location.X + (int)(i++ * (tamanhoBola + distancia)), pnlBola43.Location.Y);
            pnlBola44.Location = new Point(pnlBola1.Location.X + (int)(i++ * (tamanhoBola + distancia)), pnlBola44.Location.Y);
            pnlBola45.Location = new Point(pnlBola1.Location.X + (int)(i++ * (tamanhoBola + distancia)), pnlBola45.Location.Y);
            i = 1;
            pnlBola47.Location = new Point(pnlBola1.Location.X + (int)(i++ * (tamanhoBola + distancia)), pnlBola47.Location.Y);
            pnlBola48.Location = new Point(pnlBola1.Location.X + (int)(i++ * (tamanhoBola + distancia)), pnlBola48.Location.Y);
            pnlBola49.Location = new Point(pnlBola1.Location.X + (int)(i++ * (tamanhoBola + distancia)), pnlBola49.Location.Y);
            pnlBola50.Location = new Point(pnlBola1.Location.X + (int)(i++ * (tamanhoBola + distancia)), pnlBola50.Location.Y);
            pnlBola51.Location = new Point(pnlBola1.Location.X + (int)(i++ * (tamanhoBola + distancia)), pnlBola51.Location.Y);
            pnlBola52.Location = new Point(pnlBola1.Location.X + (int)(i++ * (tamanhoBola + distancia)), pnlBola52.Location.Y);
            pnlBola53.Location = new Point(pnlBola1.Location.X + (int)(i++ * (tamanhoBola + distancia)), pnlBola53.Location.Y);
            pnlBola54.Location = new Point(pnlBola1.Location.X + (int)(i++ * (tamanhoBola + distancia)), pnlBola54.Location.Y);
            pnlBola55.Location = new Point(pnlBola1.Location.X + (int)(i++ * (tamanhoBola + distancia)), pnlBola55.Location.Y);
            pnlBola56.Location = new Point(pnlBola1.Location.X + (int)(i++ * (tamanhoBola + distancia)), pnlBola56.Location.Y);
            pnlBola57.Location = new Point(pnlBola1.Location.X + (int)(i++ * (tamanhoBola + distancia)), pnlBola57.Location.Y);
            pnlBola58.Location = new Point(pnlBola1.Location.X + (int)(i++ * (tamanhoBola + distancia)), pnlBola58.Location.Y);
            pnlBola59.Location = new Point(pnlBola1.Location.X + (int)(i++ * (tamanhoBola + distancia)), pnlBola59.Location.Y);
            pnlBola60.Location = new Point(pnlBola1.Location.X + (int)(i++ * (tamanhoBola + distancia)), pnlBola60.Location.Y);
            i = 1;
            pnlBola62.Location = new Point(pnlBola1.Location.X + (int)(i++ * (tamanhoBola + distancia)), pnlBola62.Location.Y);
            pnlBola63.Location = new Point(pnlBola1.Location.X + (int)(i++ * (tamanhoBola + distancia)), pnlBola63.Location.Y);
            pnlBola64.Location = new Point(pnlBola1.Location.X + (int)(i++ * (tamanhoBola + distancia)), pnlBola64.Location.Y);
            pnlBola65.Location = new Point(pnlBola1.Location.X + (int)(i++ * (tamanhoBola + distancia)), pnlBola65.Location.Y);
            pnlBola66.Location = new Point(pnlBola1.Location.X + (int)(i++ * (tamanhoBola + distancia)), pnlBola66.Location.Y);
            pnlBola67.Location = new Point(pnlBola1.Location.X + (int)(i++ * (tamanhoBola + distancia)), pnlBola67.Location.Y);
            pnlBola68.Location = new Point(pnlBola1.Location.X + (int)(i++ * (tamanhoBola + distancia)), pnlBola68.Location.Y);
            pnlBola69.Location = new Point(pnlBola1.Location.X + (int)(i++ * (tamanhoBola + distancia)), pnlBola69.Location.Y);
            pnlBola70.Location = new Point(pnlBola1.Location.X + (int)(i++ * (tamanhoBola + distancia)), pnlBola70.Location.Y);
            pnlBola71.Location = new Point(pnlBola1.Location.X + (int)(i++ * (tamanhoBola + distancia)), pnlBola71.Location.Y);
            pnlBola72.Location = new Point(pnlBola1.Location.X + (int)(i++ * (tamanhoBola + distancia)), pnlBola72.Location.Y);
            pnlBola73.Location = new Point(pnlBola1.Location.X + (int)(i++ * (tamanhoBola + distancia)), pnlBola73.Location.Y);
            pnlBola74.Location = new Point(pnlBola1.Location.X + (int)(i++ * (tamanhoBola + distancia)), pnlBola74.Location.Y);
            pnlBola75.Location = new Point(pnlBola1.Location.X + (int)(i++ * (tamanhoBola + distancia)), pnlBola75.Location.Y);
            #endregion

            #region Ajusta o tamanho dos Patrocinadores
            int widthSplit2 = splitContainer1.Size.Width - splitContainer1.SplitterDistance;
            int borda = 40;
            float porcXY = 0.75f;
            int widthPicPatrocinador = widthSplit2 - (borda * 2);
            int heightPicPatrocinador = (int)(widthPicPatrocinador * porcXY);

            if (heightPicPatrocinador > (splitContainer1.Size.Height * 0.44082840f))
            {
                heightPicPatrocinador = (int)(splitContainer1.Size.Height * 0.44082840f);
                widthPicPatrocinador = (int)(heightPicPatrocinador / 0.75);
            }

            //int xPatrocinador = (picPatrocinador2.Size.Width > 565 ? 565 : picPatrocinador2.Size.Width);
            //int yPatrocinador = (int)(xPatrocinador * porcXY);
            Size novoTamanhoPatrocinador = new Size(widthPicPatrocinador, heightPicPatrocinador);

            picPatrocinador1.Size = novoTamanhoPatrocinador;
            picPatrocinador2.Size = novoTamanhoPatrocinador;
            #endregion Ajusta o tamanho dos Patrocinadores

            #region Ajusta o Location dos Patrocinadores
            //float porcDistancia
            //float distanciaYPatrocinador2 = 0.46597633f;
            //int distanciaY = (int)(this.splitContainer1.Height * porcentagemY);
            //int y = (int)(novoTamanho.Height + distanciaY);
            int locationPicPatrocinador2 = (int)(splitContainer1.Size.Height / 2) + 40;
            picPatrocinador2.Location = new Point(picPatrocinador2.Location.X, locationPicPatrocinador2);
            #endregion Ajusta o Location dos Patrocinadores
        }
    }
}
