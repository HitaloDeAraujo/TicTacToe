using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Jogada
    {
        public int L, C;
        public char Caractere;

        public Jogada(int L, int C, char Caractere)
        {
            this.L = L;
            this.C = C;
            this.Caractere = Caractere;
        }
    }
}
