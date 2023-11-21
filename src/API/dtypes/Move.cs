namespace ChessPlatform.API.dtypes;

public class Move
{
    public Square StartSquare;
    public Square TargetSquare;
    public PieceType PieceType;

    public Move()
    {
        StartSquare = new Square();
        TargetSquare = new Square();
        PieceType = PieceType.None;
    }

    public Move(Square startSquare, Square targetSquare, PieceType pieceType)
    {
        StartSquare = startSquare;
        TargetSquare = targetSquare;
        PieceType = pieceType;
    }
}
