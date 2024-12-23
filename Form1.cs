using System.Media;

namespace JogoDaVelha
{
    public partial class Form1 : Form
    {
        private SoundPlayer Player = new SoundPlayer();
        string turno = "j1";
        string jogador1 = string.Empty;
        string jogador2 = string.Empty;
        int contadorCliques = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LimparTabuleiro(false);
        }
        private void LimparTabuleiro(bool habilita)
        {
            btn1.Text = string.Empty;
            btn2.Text = string.Empty;
            btn3.Text = string.Empty;
            btn4.Text = string.Empty;
            btn5.Text = string.Empty;
            btn6.Text = string.Empty;
            btn7.Text = string.Empty;
            btn8.Text = string.Empty;
            btn9.Text = string.Empty;
            btn1.Enabled = habilita;
            btn2.Enabled = habilita;
            btn3.Enabled = habilita;
            btn4.Enabled = habilita;
            btn5.Enabled = habilita;
            btn6.Enabled = habilita;
            btn7.Enabled = habilita;
            btn8.Enabled = habilita;
            btn9.Enabled = habilita;
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            if (jogador1 == string.Empty)
            {
                jogador1 = "X";
                jogador2 = "O";
                btnIniciar.Enabled = true;
                lblJogadorX.Text = "Jogador 1";
                lblJogadorO.Text = "Jogador 2";
            }
        }
        private void btnO_Click(object sender, EventArgs e)
        {
            if (jogador1 == string.Empty)
            {
                jogador1 = "O";
                jogador2 = "X";
                btnIniciar.Enabled = true;
                lblJogadorO.Text = "Jogador 1";
                lblJogadorX.Text = "Jogador 2";
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            this.Player.SoundLocation = @"C:\Windows\Media\chimes.wav";
            this.Player.PlayLooping();
            turno = "j1";
            btnIniciar.Enabled = false;
            LimparTabuleiro(true);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(btn1.Text))
                return;

            if (turno == "j1")
            {
                btn1.Text = jogador1;
                turno = "j2";
            }
            else
            {
                btn1.Text = jogador2;
                turno = "j1";
            }
            VerificarVencedorEempate();
        }

        private void VerificarVencedorEempate()
        {
            if (
                // horizontal
                (btn1.Text == btn2.Text && btn2.Text == btn3.Text && btn3.Text != "")
                 ||
                (btn4.Text == btn5.Text && btn5.Text == btn6.Text && btn6.Text != "")
                  ||
                (btn7.Text == btn8.Text && btn8.Text == btn9.Text && btn9.Text != "")
                ||
                // vertical
                (btn1.Text == btn4.Text && btn4.Text == btn7.Text && btn7.Text != "")
                ||
                (btn2.Text == btn5.Text && btn5.Text == btn8.Text && btn8.Text != "")
                ||
                (btn3.Text == btn6.Text && btn6.Text == btn9.Text && btn9.Text != "")
                ||
                // diagonal
                (btn1.Text == btn5.Text && btn5.Text == btn9.Text && btn9.Text != "")
                ||
                (btn3.Text == btn5.Text && btn5.Text == btn7.Text && btn7.Text != "")
               )
            {
                // IF TERN�RIO
                var vencedor = turno == "j2" ? jogador1 : jogador2;
                var acao = "vitoria";
                ResetarPartida(vencedor, acao);
            }
            contadorCliques++;

            if (contadorCliques == 9)
            {
                var acao = "empate";
                ResetarPartida("", acao);
            }
        }

        private void ResetarPartida(string jogadorVitorioso, string acao)
        {
            turno = "j1";
            btnIniciar.Enabled = false;
            lblJogadorX.Text = "<<<";
            lblJogadorO.Text = ">>>";
            if (acao == "vitoria")
                MessageBox.Show("Vitoria do jogador " + jogadorVitorioso);
            else if (acao == "empate")
                MessageBox.Show("Empate");
            jogador1 = "";
            jogador2 = "";
            contadorCliques = 0;
            LimparTabuleiro(false);
            this.Player.Stop();
        }

        private void btn2_Click(object sender, EventArgs e)
        {   // se o texto do btn n�o est� vazio
            if (!string.IsNullOrEmpty(btn2.Text))
                return;

            if (turno == "j1")
            {
                btn2.Text = jogador1;
                turno = "j2";
            }
            else
            {
                btn2.Text = jogador2;
                turno = "j1";
            }
            VerificarVencedorEempate();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(btn3.Text))
                return;
            if (turno == "j1")
            {
                btn3.Text = jogador1;
                turno = "j2";
            }
            else
            {
                btn3.Text = jogador2;
                turno = "j1";
            }
            VerificarVencedorEempate();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(btn4.Text))
                return;
            if (turno == "j1")
            {
                btn4.Text = jogador1;
                turno = "j2";
            }
            else
            {
                btn4.Text = jogador2;
                turno = "j1";
            }
            VerificarVencedorEempate();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(btn5.Text))
                return;
            if (turno == "j1")
            {
                btn5.Text = jogador1;
                turno = "j2";
            }
            else
            {
                btn5.Text = jogador2;
                turno = "j1";
            }
            VerificarVencedorEempate();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(btn6.Text))
                return;
            if (turno == "j1")
            {
                btn6.Text = jogador1;
                turno = "j2";
            }
            else
            {
                btn6.Text = jogador2;
                turno = "j1";
            }
            VerificarVencedorEempate();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(btn7.Text))
                return;
            if (turno == "j1")
            {
                btn7.Text = jogador1;
                turno = "j2";
            }
            else
            {
                btn7.Text = jogador2;
                turno = "j1";
            }
            VerificarVencedorEempate();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(btn8.Text))
                return;
            if (turno == "j1")
            {
                btn8.Text = jogador1;
                turno = "j2";
            }
            else
            {
                btn8.Text = jogador2;
                turno = "j1";
            }
            VerificarVencedorEempate();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(btn9.Text))
                return;
            if (turno == "j1")
            {
                btn9.Text = jogador1;
                turno = "j2";
            }
            else
            {
                btn9.Text = jogador2;
                turno = "j1";
            }
            VerificarVencedorEempate();
        }
    }
}
