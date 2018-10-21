using System;
using board;

namespace chess_console
{
    class Program
    {
        static void Main(string[] args)
        {

            Position P = new Position(3, 4);

            Console.WriteLine("Posicao: " + P);

            Console.ReadLine();

        }
    }
}
