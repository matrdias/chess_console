using System;
using board;

namespace chess
{
    class ChessGame
    {

        public Board Brd { get; private set; }  // Do not let the programmer access the board     
        private readonly int Turn;              //  The Turn is incremented at every play
        private readonly Color ActivePlayer;    //  Tells who turn it is

        public ChessGame()                  // Constructor for a chess game
        {
            Brd = new Board(8, 8);          // Set a new board
            Turn = 1;                       // Turn begins at the turn 1.
            ActivePlayer = Color.White;     // The player from the white pieces starts the game
            InsertPieces();
        }

        public void ExecuteMovmnt(Position origin, Position dest)       //  Does the moviment from the origin to dest position
        {
            Piece p = Brd.RemovePiece(origin);                  //  Removes the piece from where it is  
            p.MovesIncrement();                                 //  Increments its number of moves
            Piece CapturedPiece = Brd.RemovePiece(dest);        //  Remove the piece that is on the dest position
            Brd.PlacePiece(p, dest);                            //  Places the piece P on the dest position
        }

        private void InsertPieces()             // Insert the desirable pieces on the board at the beginning of the game
        {

            Brd.PlacePiece(new Rook(Brd, Color.White), new ChessPosition('c', 1).ToPosition()); //  Uses toPosition to convert the board position to matrix position
            Brd.PlacePiece(new Rook(Brd, Color.White), new ChessPosition('c', 2).ToPosition());
            Brd.PlacePiece(new King(Brd, Color.White), new ChessPosition('d', 1).ToPosition());
            Brd.PlacePiece(new Rook(Brd, Color.White), new ChessPosition('d', 2).ToPosition());
            Brd.PlacePiece(new Rook(Brd, Color.White), new ChessPosition('e', 1).ToPosition());
            Brd.PlacePiece(new Rook(Brd, Color.White), new ChessPosition('e', 2).ToPosition());

            Brd.PlacePiece(new Rook(Brd, Color.Black), new ChessPosition('c', 7).ToPosition());
            Brd.PlacePiece(new Rook(Brd, Color.Black), new ChessPosition('c', 8).ToPosition());
            Brd.PlacePiece(new King(Brd, Color.Black), new ChessPosition('d', 7).ToPosition());
            Brd.PlacePiece(new Rook(Brd, Color.Black), new ChessPosition('d', 8).ToPosition());
            Brd.PlacePiece(new Rook(Brd, Color.Black), new ChessPosition('e', 7).ToPosition());
            Brd.PlacePiece(new Rook(Brd, Color.Black  ), new ChessPosition('e', 8).ToPosition());
        }
    }
}
