using System;
using board;

namespace chess
{
    class ChessPosition
    {
        public char Column { get; set; }        //  The letter corresponding to the column position. e.g.: A1
        public int Line { get; set; }           //  The number corresponding to the line position. e.g.: A1

        public ChessPosition(char column, int line)     //  Constructor
        {
            this.Column = column;
            this.Line = line;
        }

        public Position ToPosition()        //  Converts the chess position to a matrix position (A8 -> (0,0))
        {
            return new Position(8 - Line, Column - 'a');    //  Returns a new position. 'a' because it's a int number internally, so 'b' - 'a' = 1.
        }

        public override string ToString()
        {
            return "" + Column + Line;      //  "" -> forces the convertion to string
        }
    }
}
