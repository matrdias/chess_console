namespace board
{
    class Piece
    {
        public Position Position { get; set; }
        public Color Color { get; protected set; }
        public int QntMoves { get; protected set; }
        public Board Brd { get; protected set; }

        public Piece(Board brd, Color color)
        {
            this.Position = null;
            this.Brd = brd;
            this.Color = color;
            QntMoves = 0;
        }

    }
}
