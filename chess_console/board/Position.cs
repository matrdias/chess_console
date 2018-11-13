namespace board
{
    class Position
    {
        public int Line { get; set; }
        public int Column { get; set;}

        public Position(int linha, int coluna)   // Constructor (Construtor)
        {
            this.Line = linha;
            this.Column = coluna;
        }

        public override string ToString()       //  Override (Sobreposição)
        {
            return Line
                + ","
                + Column;
        }
    }
}
