using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace TicTacToe
{
    class MotorTTC
    {
        private static Jogada J;
        private static List<Jogada> ListaJogadas = new List<Jogada>();
        private static List<int> ListaNumeros = new List<int>();
        private static char caracteremaquina = 'x';

        private static bool ValidaJogada(char[,] matriz, int l, int c)
        {
            if (matriz[l, c] != 'c' && matriz[l, c] != 'x')
                return true;

            return false;
        }

        private static bool SequenciaDetectada(char[,] matriz, char caractere)
        {
            for (int i = 0; i < 3; i++)                     //Verificacao horizontal
            {
                if (matriz[i, 0] == caractere && matriz[i, 0] == matriz[i, 1] && ValidaJogada(matriz, i, 2))
                {
                    J = new Jogada(i, 2, caractere);
                    return true;
                }
                else if (matriz[i, 1] == caractere && matriz[i, 1] == matriz[i, 2] && ValidaJogada(matriz, i, 0))
                {
                    J = new Jogada(i, 0, caractere);
                    return true;
                }
                else if (matriz[0, i] == caractere && matriz[0, i] == matriz[1, i] && ValidaJogada(matriz, 2, i))        //Verificacao vertical
                {
                    J = new Jogada(2, i, caractere);
                    return true;
                }
                else if (matriz[1, i] == caractere && matriz[1, i] == matriz[2, i] && ValidaJogada(matriz, 0, i))
                {
                    J = new Jogada(0, i, caractere);
                    return true;
                }
                else if (matriz[i, 0] == caractere && matriz[i, 0] == matriz[i, 2] && ValidaJogada(matriz, i, 1))
                {
                    J = new Jogada(i, 1, caractere);
                    return true;
                }
                else if (matriz[0, i] == caractere && matriz[0, i] == matriz[2, i] && ValidaJogada(matriz, 1, i))
                {
                    J = new Jogada(1, i, caractere);
                    return true;
                }
            }

            if (matriz[0, 0] == matriz[2, 2] && ValidaJogada(matriz, 1, 1))
            {
                J = new Jogada(1, 1, caractere);
                return true;
            }
            else if (matriz[0, 2] == matriz[2, 0] && ValidaJogada(matriz, 1, 1))    //Diagonais
            {
                J = new Jogada(1, 1, caractere);
                return true;
            }
            else if (matriz[0, 0] == matriz[1, 1] && ValidaJogada(matriz, 2, 2))
            {
                J = new Jogada(2, 2, caractere);
                return true;
            }
            else if (matriz[2, 2] == matriz[1, 1] && ValidaJogada(matriz, 0, 0))
            {
                J = new Jogada(0, 0, caractere);
                return true;
            }
            else if (matriz[0, 2] == matriz[1, 1] && ValidaJogada(matriz, 2, 0))
            {
                J = new Jogada(2, 0, caractere);
                return true;
            }
            else if (matriz[2, 0] == matriz[1, 1] && ValidaJogada(matriz, 0, 2))
            {
                J = new Jogada(0, 2, caractere);
                return true;
            }

            return false;
        }

        public static char CaractereMaquina()
        {
            return caracteremaquina;
        }

        public static void CaractereMaquina(char caractere)
        {
            caracteremaquina = caractere;
        }

        public static void JogadaMaquina(List<Jogada> ListaAtual, char[,] Matriz)
        {
            string Linha = "";
            List<string> Lista = Armazenamento.Carregar();

            if (ListaAtual.Count == 0 && Lista.Count != 0)
            {
                for (int i = 0; i < Lista.Count; i += 2)
                {
                    ListaNumeros.Add(int.Parse(Lista[i]));
                    int.Parse(Lista[i + 1][0].ToString());

                    if (Lista[i + 1][Lista[i + 1].Length - 1] == 'x')
                        caracteremaquina = 'x';
                    else
                        caracteremaquina = 'c';

                    ListaJogadas.Add(new Jogada((int.Parse(Lista[i + 1][0].ToString())), int.Parse(Lista[i + 1][2].ToString()), caracteremaquina));
                }

                int Maior = 0;

                for (int i = 0; i < ListaNumeros.Count; i++)
                {
                    if (ListaNumeros[i] > Maior)
                    {
                        Maior = ListaNumeros[i];
                        J = ListaJogadas[i];
                    }
                }

                return;
            }

            if (SequenciaDetectada(Matriz, caracteremaquina))
                return;

            if (caracteremaquina == 'x')
            {
                if (SequenciaDetectada(Matriz, 'c'))
                    return;
            }
            else if (SequenciaDetectada(Matriz, 'x'))
                return;

            ListaJogadas.Clear();
            ListaNumeros.Clear();

            foreach (var item in ListaAtual)
                Linha += item.L + ";" + item.C + ";" + item.Caractere + ";";

            Lista = Armazenamento.Carregar();

            Regex rg = new Regex(Linha, RegexOptions.None);

            for (int i = 1; i < Lista.Count; i += 2)
            {
                if (rg.IsMatch(Lista[i]) && Lista[i].Length > Linha.Length)
                {
                    string Auxiliar = Linha;
                    Linha = Lista[i].Replace(Linha, "");

                    if (Linha[Linha.Length - 2] == caracteremaquina)
                        J = new Jogada(int.Parse(Linha[0].ToString()), int.Parse(Linha[2].ToString()), Linha[4]);
                    else
                        J = new Jogada(int.Parse(Linha[6].ToString()), int.Parse(Linha[8].ToString()), Linha[10]);

                    if (ValidaJogada(Matriz, J.L, J.C))
                    {
                        ListaJogadas.Add(J);
                        ListaNumeros.Add(int.Parse(Lista[i - 1]));
                    }

                    Linha = Auxiliar;
                }
            }

            if (ListaJogadas.Count != 0)
                return;



            List<Jogada> Jogadas = new List<Jogada>();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (Matriz[i, j] != 'c' && Matriz[i, j] != 'x')
                        Jogadas.Add(new Jogada(i, j, caracteremaquina));
                }
            }

            Random r = new Random();

            if (Jogadas.Count() > 0)
                J = Jogadas[r.Next(0, Jogadas.Count() - 1)];
            else
                J = Jogadas[0];
        }

        public static Jogada Maquina(char[,] Matriz)
        {
            if (ListaJogadas.Count == 0)
                return J;

            int Maior = 0;

            for (int i = 0; i < ListaJogadas.Count; i++)
            {
                if (ListaNumeros[i] > Maior)
                {
                    Maior = ListaNumeros[i];
                    J = ListaJogadas[i];
                }
            }

            ListaJogadas.Clear();
            ListaNumeros.Clear();

            return J;
        }

        public static bool JogoGanho(char[,] matriz)
        {
            if (matriz[0, 0] == matriz[0, 1] && matriz[0, 0] == matriz[0, 2])   //Linha 0
                return true;
            else if (matriz[0, 0] == matriz[1, 1] && matriz[0, 0] == matriz[2, 2])
                return true;
            else if (matriz[0, 0] == matriz[1, 0] && matriz[0, 0] == matriz[2, 0])
                return true;
            else if (matriz[0, 1] == matriz[1, 1] && matriz[0, 1] == matriz[2, 1])
                return true;
            else if (matriz[0, 2] == matriz[1, 2] && matriz[0, 2] == matriz[2, 2])
                return true;
            else if (matriz[0, 2] == matriz[1, 1] && matriz[0, 2] == matriz[2, 0])
                return true;
            else if (matriz[1, 0] == matriz[1, 1] && matriz[1, 0] == matriz[1, 2])  //Linha 1
                return true;
            else if (matriz[2, 0] == matriz[2, 1] && matriz[2, 0] == matriz[2, 2])
                return true;
            else
                return false;
        }

        public static bool Empate(char[,] matriz)
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (matriz[i, j] != 'c' && matriz[i, j] != 'x')
                        return false;

            return true;
        }
    }
}
