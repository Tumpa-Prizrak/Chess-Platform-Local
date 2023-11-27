namespace API.dtypes;

public class Piece
{
    public PieceType PieceType;
    public Square Square;
    public bool IsWhite;

    public Piece(PieceType pieceType = PieceType.None, Square? square = null, bool? isWhite = null)
    {
        PieceType = pieceType;
        Square = square ?? new Square();
        IsWhite = isWhite ?? false;
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