namespace board
{
    class Board
    {
        public int Lines { get; set; }          // Number of lines and columns from the game
        public int Columns { get; set; }        // for chess is 8x8
        private Piece[,] Pieces { get; set; }   //  A matrix of pieces. An association from class Piece with the class Board. Private = Only the class Board can edit it. 
        public Board(int lines, int columns)    //  Constructor
        {
            this.Lines = lines;
            this.Columns = columns;
            Pieces = new Piece[lines, columns];     //  Instance of matrix of pieces
        }

        public Piece Piece(int line, int column)    //  Gives acess to a specific piece
        {
            return Pieces[line, column];
        }

        public Piece Piece(Position pos)            // Overload for the Piece method
        {
            return Pieces[pos.Line, pos.Column];    // Matrix Piece
        }

        public bool ExistPiece(Position pos)        // Tests if there a piece in the specific position
        {
            ValidatePosition(pos);                  // Before returning the existance checking, it validates the position.
            return Piece(pos) != null;              // If it's not a valid position, it breaks the method and throw an exception
        }
        public void PlacePiece(Piece p, Position pos) //  Method to place a piece on the board     
        {
            if (ExistPiece(pos))        // Check if there is already a piece in the specific position. It also checks if it's a valid position(ExistPiece)
            {
                throw new BoardException("There is already a piece in this position.");
            }
            Pieces[pos.Line, pos.Column] = p;       //  Placing the piece P in the matrix of pieces at the specific position
            p.Position = pos;                       //  Setting the P position to pos
        }

        public Piece RemovePiece(Position pos)      // Remove piece from the board
        {
            if (Piece(pos) == null)     //  If there is no piece on the specific position, returns null
            {
                return null;
            }
            Piece aux = Piece(pos);                 // Gets the piece on the specific position
            aux.Position = null;                    // Change the piece position to null, meaning it was taken from the board
            Pieces[pos.Line, pos.Column] = null;    // Set the specific position on the board to null
            return aux;                             // returns the specific piece  
        }

        public bool ValidPosition(Position pos)     // Test if the position received is valid
        {
            if (pos.Line < 0 || pos.Line >= Lines || pos.Column < 0 || pos.Column >= Columns)
            {
                return false;
            }
            return true;
        }

        public void ValidatePosition(Position pos)  // If the position received if not valid, throw a personalized exception
        {
            if (!ValidPosition(pos))
            {
                throw new BoardException("Invalid position!");
            }
        }
    }
}
