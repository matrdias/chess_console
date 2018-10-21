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
                for (int j = 0; j < brd.Columns; j++)
                {
                    if (brd.Piece(i,j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(brd.Piece(i, j) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
