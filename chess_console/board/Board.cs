﻿namespace board
{
    class Board
    {
        public int Lines { get; set; }
        public int Columns { get; set; }
        private Piece[,] Pieces { get; set; }
        public Board(int lines, int columns)
        {
            this.Lines = lines;
            this.Columns = columns;
            Pieces = new Piece[lines, columns];
        }

        public Piece Piece(int line, int column)
        {
            return Pieces[line, column];
        }

        public Piece Piece(Position pos)
        {
            return Pieces[pos.Line, pos.Column];
        }

        public bool ExistPiece(Position pos)
        {
            ValidatePosition(pos);
            return Piece(pos) != null;
        }
        public void PutPiece(Piece p, Position pos)
        {
            if (ExistPiece(pos))
            {
                throw new BoardException("There is already a piece in this position.");
            }
            Pieces[pos.Line, pos.Column] = p;
            p.Position = pos;
        }

        public bool ValidPosition(Position pos)
        {
            if (pos.Line < 0 || pos.Line >= Lines || pos.Column < 0 || pos.Column >= Columns)
            {
                return false;
            }
            return true;
        }

        public void ValidatePosition(Position pos)
        {
            if (!ValidPosition(pos))
            {
                throw new BoardException("Invalid position!");
            }
        }
    }
}
