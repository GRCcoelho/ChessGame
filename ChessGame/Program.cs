﻿using ChessGame.tabuleiro;
using ChessGame.xadrez;
using System;

namespace ChessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('c', 7);

            Console.WriteLine(pos);
            Console.WriteLine(pos.toPosicao());
          

            Console.ReadLine();
        }
    }
}
