namespace board
{
    class Piece
    {
        public Position Position { get; set; }
        public Color Color { get; protected set; }
        public int QntMoves { get; protected set; }
        public Board Brd { get; protected set; }

        public Piece(Position position, Board brd, Color color)
        {
            this.Position = position;
            this.Brd = brd;
            this.Color = color;
            QntMoves = 0;
        }

    }
}
