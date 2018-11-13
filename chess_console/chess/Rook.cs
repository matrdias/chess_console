using board;


namespace chess
{
    class Rook: Piece      // Rook is a subclass of Piece. It inherit methods and properties of Piece and can
    {                      // also modify the behavior of the methods if required.
    {
        public Rook(Board brd, Color color) : base(brd, color)  // It passes the instruction(execution) to the class Piece
        {

        }

        public override string ToString()
        {
            return "R";
        }
    }
}
