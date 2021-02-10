using System;
using GameTOP.Lib;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
            JogoFODA jogo = new JogoFODA(new Jogador1("Iniesta"), new Jogador3());
            jogo.IniciarJogo();
        }
    }
}
