using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace TicTacToe
{
    class Armazenamento
    {
        private static List<string> ListaDeJogadas = new List<string>();
        private static List<string> Buffer = new List<string>();
        private static bool UsarBuffer = false;

        public static List<string> Carregar()
        {
            try
            {
                var ListaTXT = File.ReadAllLines(/*@"C:\Users\usuario\Desktop\*/"Jogadas.txt");
                ListaDeJogadas = new List<string>();
                ListaDeJogadas.AddRange(ListaTXT.ToList());

                if(UsarBuffer)
                    ListaDeJogadas.AddRange(Buffer);

                return ListaDeJogadas;
            }
            catch (Exception)
            {
                return new List<string>();
            }
        }

        public static void Salvar(List<Jogada> Lista)
        {
            string linha = null;

            foreach (var item in Lista)
                linha += item.L + ";" + item.C + ";" + item.Caractere + ";";

            UsarBuffer = false;

            List<string> ListaAuxiliar = Armazenamento.Carregar();

            UsarBuffer = true;
            
            if (ListaAuxiliar.Contains(linha))
            {
                int Indice = ListaAuxiliar.IndexOf(linha);

                int Numero = int.Parse(ListaAuxiliar[Indice - 1].ToString()) + 1;

                ListaAuxiliar[Indice - 1] = Numero.ToString();
            }
            else
            {
                ListaAuxiliar.Add("1");
                ListaAuxiliar.Add(linha);
            }

            try
            {
                File.WriteAllLines(/*@"C:\Users\usuario\Desktop\*/"Jogadas.txt", ListaAuxiliar);
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possivel criar/modificar o arquivo de jogadas");
            }
        }

        public static void AdicionarBuffer(List<Jogada> Lista)
        {
            string linha = null;

            foreach (var item in Lista)
                linha += item.L + ";" + item.C + ";" + item.Caractere + ";";

            if (Buffer.Contains(linha))
            {
                int Indice = Buffer.IndexOf(linha);

                int Numero = int.Parse(Buffer[Indice - 1].ToString()) + 1;

                Buffer[Indice - 1] = Numero.ToString();
            }
            else
            {
                Buffer.Add("9999");
                Buffer.Add(linha);
            }
        }

        public static void RemoverBuffer()
        {
            Buffer.Clear();
        }

    }
}