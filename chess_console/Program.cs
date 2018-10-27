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
                Board B = new Board(8, 8);

                B.PutPiece(new Rook(B, Color.Black), new Position(0, 0));
                B.PutPiece(new Rook(B, Color.Black), new Position(1, 3));
                B.PutPiece(new King(B, Color.White), new Position(2, 4));

                Screen.PrintScreen(B);
            }
            catch (BoardException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();

        }
    }
}
