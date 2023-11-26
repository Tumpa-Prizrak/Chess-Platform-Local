namespace ChessPlatform.API.dtypes;

/// <summary>
/// Represents a chess move with start/target squares and piece type 
/// </summary>
public class Move 
{
    /// <summary>
    /// The start square of the move
    /// </summary>
    public Square StartSquare;

    /// <summary>
    /// The target square of the move
    /// </summary>
    public Square TargetSquare;

    /// <summary>
    /// The type of piece making the move
    /// </summary>
    public PieceType PieceType;

    /// <summary>
    /// Constructs a default Move with empty squares and no piece
    /// </summary>
    public Move()
    {
        StartSquare = new Square();
        TargetSquare = new Square();
        PieceType = PieceType.None;
    }

    /// <summary>
    /// Constructs a Move with provided details
    /// </summary>
    /// <param name="startSquare">The start square</param>
    /// <param name="targetSquare">The target square</param>
    /// <param name="pieceType">The piece type</param>
    public Move(Square startSquare, Square targetSquare, PieceType pieceType)
    {
        StartSquare = startSquare;
        TargetSquare = targetSquare;
        PieceType = pieceType;
    }
}

