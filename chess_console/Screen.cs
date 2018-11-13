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
        public static void PrintBoard(Board brd)    //  Static element: it's not about its own object, it can be used independet from the objects. 
        {
            for (int i = 0; i < brd.Lines; i++)         //  Go through...
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < brd.Columns; j++)   //  ... the board
                {
                    if (brd.Piece(i,j) == null)
                    {
                        Console.Write("- ");            // Print '-' if there is no piece in the position
                    }
                    else
                    {
                        PrintPiece(brd.Piece(i, j));    //  Print the specific chess piece
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.Write("  a b c d e f g h");
        }

        public static void PrintPiece(Piece piece)  //  A static method which prints the piece
        {
            if (piece.Color == Color.White)
            {
                Console.Write(piece);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;     //  ConsoleColor gets the system color. Saves the console color(gray)
                Console.ForegroundColor = ConsoleColor.Yellow;  //  Sets the color to yellow
                Console.Write(piece);                           //  Print the piece with the new color
                Console.ForegroundColor = aux;                  //  Change back to the original color(gray)
            }
        }
    }
}
