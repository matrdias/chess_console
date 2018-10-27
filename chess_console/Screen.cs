using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using board;

namespace chess_console
{
    class Screen
    {
        public static void PrintScreen(Board brd)
        {
            for (int i = 0; i < brd.Lines; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < brd.Columns; j++)
                {
                    if (brd.Piece(i,j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        PrintPiece(brd.Piece(i, j));
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.Write("  a b c d e f g h");
        }

        public static void PrintPiece(Piece piece)
        {
            if (piece.Color == Color.Black)
            {
                Console.Write(piece);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(piece);
                Console.ForegroundColor = aux;
            }
        }
    }
}
