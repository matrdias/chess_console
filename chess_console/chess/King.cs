﻿using board;


namespace chess
{
    class King : Piece
    {
        public King(Board brd, Color color) : base(brd, color)
        {

        }

        public override string ToString()
        {
            return "K";
        }
    }
}
