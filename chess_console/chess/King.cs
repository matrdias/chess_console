using board;


namespace chess
{
    class King : Piece     // King is a subclass of Piece. It inherit methods and properties of Piece and can
    {                      // also modify the behavior of the methods if required.
        public King(Board brd, Color color) : base(brd, color)  // It passes the instruction(execution) to the class Piece
        {

        }

        public override string ToString()
        {
            return "K";
        }
    }
}
