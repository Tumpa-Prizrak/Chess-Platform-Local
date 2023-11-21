namespace ChessPlatform.API.dtypes;

public class Piece
{
    public PieceType PieceType;
    public Square Square;
    public bool IsWhite;

    public Piece(PieceType pieceType = PieceType.None, Square? square = null, bool isWhite = false)
    {
        PieceType = pieceType;
        Square = square ?? new Square();
        IsWhite = isWhite;
    }

    public string ImagePath()
    {
        string color;
        
        color = IsWhite ? "white" : "black";
        
        return $"src/resources/{color}-{PieceType.ToString().ToLower()}.png";
    }
}

public enum PieceType
{
    Pawn,
    Knight,
    Bishop,
    Rook,
    Queen,
    King,
    None
}