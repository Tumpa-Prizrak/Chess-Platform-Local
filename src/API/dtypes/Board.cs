namespace ChessPlatform.API.dtypes;

public class Board
{
    public readonly Square[] Squares = new Square[64];
    public readonly List<Piece> Pieces = new ();
    
    public Board()
    {
        for (int i = 0; i < 64; i++)
        {
            Squares[i] = new Square(i);
        }
    }

    public void AddPiece(Piece piece)
    {
        Pieces.Add(piece);
    }
}