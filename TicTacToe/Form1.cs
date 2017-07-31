using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private char[,] matriz = new char[3, 3];
        private List<Jogada> ListaAtual = new List<Jogada>();
        private char caracteremaquina = 'x', caracterejogador = 'c';

        public Form1()
        {
            InitializeComponent();
            
            AdicionaEvento(pb00);
            AdicionaEvento(pb01);
            AdicionaEvento(pb02);
            AdicionaEvento(pb10);
            AdicionaEvento(pb11);
            AdicionaEvento(pb12);
            AdicionaEvento(pb20);
            AdicionaEvento(pb21);
            AdicionaEvento(pb22);
            
            NovoJogo();
        }

        private void NovoJogo()
        {
            LimparJogo();

            panel2.Visible = true;

            DialogResult dr = MessageBox.Show("Jogador inicia a partida?", "Novo Jogo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                lblJogador.Text = "jogador 1";
            }
            else
            {
                MotorTTC.JogadaMaquina(ListaAtual, matriz);

                caracteremaquina = MotorTTC.CaractereMaquina();

                if (caracteremaquina == 'c')
                    caracterejogador = 'x';

                LimparJogo();

                JogMaquina();
            }
        }

        private void LimparJogo()
        {
            ListaAtual.Clear();

            int indice = 0;

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    matriz[i, j] = char.Parse(indice.ToString());
                    indice++;
                }

            foreach (Control ctl in panel2.Controls)
            {
                if (ctl is PictureBox)
                {
                    ((PictureBox)ctl).SizeMode = PictureBoxSizeMode.StretchImage;

                    ((PictureBox)ctl).Image = null;

                    ((PictureBox)ctl).Enabled = true;
                }
            }
        }

        private void JogMaquina()
        {            
            lblJogador.Text = "jogador 1";

            MotorTTC.JogadaMaquina(ListaAtual, matriz);

            Jogada NovaJogada = MotorTTC.Maquina(matriz);

            foreach (Control ctl in panel2.Controls)
            {
                if (ctl is PictureBox)
                {
                    if (ctl.Name == "pb" + NovaJogada.L + NovaJogada.C)
                    {
                        ((PictureBox)ctl).SizeMode = PictureBoxSizeMode.StretchImage;

                        ((PictureBox)ctl).ImageLocation = /*@"C:\Users\usuario\Desktop\" + */caracteremaquina + ".png";

                        Jogada(int.Parse(((PictureBox)ctl).Name[2].ToString()), int.Parse(((PictureBox)ctl).Name[3].ToString()), caracteremaquina);

                        ((PictureBox)ctl).Enabled = false;
                    }
                }
            }
        }

        private void Jogada(int L, int C, char Caractere)
        {
            matriz[L, C] = Caractere;

            ListaAtual.Add(new Jogada(L, C, Caractere));

            if (MotorTTC.JogoGanho(matriz))
            {
                if (caracteremaquina == ListaAtual.Last().Caractere)
                {
                    MessageBox.Show("O computador ganhou");
                }
                else
                {
                    Armazenamento.AdicionarBuffer(ListaAtual);

                    MessageBox.Show("Você ganhou");
                }

                panel2.Visible = false;

                Armazenamento.Salvar(ListaAtual);
            }
            else if (MotorTTC.Empate(matriz))
                MessageBox.Show("Empate");
            else if (lblJogador.Text == "jogador 2")
                JogMaquina();
        }

        private void AdicionaEvento(PictureBox b)
        {
            b.MouseClick += new MouseEventHandler(EventoClick);  //Adiciona evento de mouse
        }

        private void EventoClick(object sender, EventArgs e) //Evento de clique com o mouse
        {
            PictureBox PB = sender as PictureBox;

            PB.SizeMode = PictureBoxSizeMode.StretchImage;

            PB.ImageLocation = /*@"C:\Users\usuario\Desktop\" + */caracterejogador + ".png";
            lblJogador.Text = "jogador 2";

            Jogada(int.Parse(PB.Name[2].ToString()), int.Parse(PB.Name[3].ToString()), caracterejogador);

            PB.Enabled = false;
        }

        private void botaoNovoJogo_Click(object sender, EventArgs e)
        {
            NovoJogo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NovoJogo();
        }
    }
}
