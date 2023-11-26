using Raylib_cs;

namespace ChessPlatform.API.dtypes;

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

    public Texture2D ImagePath()
    {
        var color = IsWhite ? "white" : "black";
        Image image = Raylib.LoadImage($"src/resources/{color}-{PieceType.ToString().ToLower()}.png");
        return Raylib.LoadTextureFromImage(image);
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