using System;
using board;
using chess;

namespace chess_console
{
    class Program
    {
        static void Main(string[] args)
        {

            //ChessPosition pos = new ChessPosition('c', 3);

            //Console.WriteLine(pos);

            //Console.WriteLine(pos.ToPosition());
            try
            {
                ChessGame game = new ChessGame();

                Screen.PrintBoard(game.Brd);
            }
            catch (BoardException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();

        }
    }
}
