using System;

namespace board
{
    class BoardException : Exception    // It inherit from the C# Exception class
    {
        public BoardException(string msg) : base(msg)   // Receives a message and pass it to the C# Exception class
        {

        }
    }
}
