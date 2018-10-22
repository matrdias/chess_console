using board;


namespace chess
{
    class Rook: Piece
    {
        public Rook(Board brd, Color color) : base(brd, color)
        {

        }

        public override string ToString()
        {
            return "R";
        }
    }
}
