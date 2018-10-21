namespace board
{
    class Position
    {
        public int Line { get; set; }
        public int Column { get; set;}

        public Position(int linha, int coluna)
        {
            this.Line = linha;
            this.Column = coluna;
        }

        public override string ToString()
        {
            return Line
                + ","
                + Column;
        }
    }
}
