namespace board
{
    class Piece     // Generic Piece
    {
        public Position Position { get; set; }          //  Piece Position
        public Color Color { get; protected set; }      //  Acessable only for his subclasses
        public int QntMoves { get; protected set; }
        public Board Brd { get; protected set; }        // Association with the class Board

        public Piece(Board brd, Color color)        //  Constructor
        {
            this.Position = null;   // Initializes at the null position. The class PutPiece(Board) gives the position to Piece.
            this.Brd = brd;
            this.Color = color;
            QntMoves = 0;
        }

        public void MovesIncrement()    // Increments the number of piece moves
        {
            QntMoves++;
        }

    }
}
