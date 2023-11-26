using Raylib_cs;

namespace ChessPlatform.API.dtypes;

/// <summary>
/// Represents a chess piece with type, square, and color.
/// </summary>
public class Piece
{
    /// <summary>
    /// The type of piece (pawn, rook, etc.)
    /// </summary>
    public PieceType PieceType;
     
    /// <summary>
    /// The square the piece is on
    /// </summary>
    public Square Square;
    
    /// <summary>
    /// Whether the piece is white or black
    /// </summary>
    public bool IsWhite;

    /// <summary>
    /// Constructs a Piece
    /// </summary>
    /// <param name="pieceType">Optional piece type</param>
    /// <param name="square">Optional square</param>
    /// <param name="isWhite">Optional color</param>
    public Piece(PieceType pieceType = PieceType.None, Square? square = null, bool? isWhite = null)
    {
        PieceType = pieceType;
        Square = square ?? new Square(); // Set default square if null
        IsWhite = isWhite ?? false; // Set default color if null
    }

    /// <summary>
    /// Gets the image path for the piece texture
    /// </summary>
    /// <returns>The Texture2D image of the piece</returns>
    public Texture2D ImagePath()
    {
        // Determine color string
        var color = IsWhite ? "white" : "black";
        
        // Load image file path
        Image image = Raylib.LoadImage($"src/resources/{color}-{PieceType.ToString().ToLower()}.png");
        
        // Convert to Texture2D
        return Raylib.LoadTextureFromImage(image);
    }
}
 

/// <summary>
/// Enumerates the different types of chess pieces.
/// </summary>
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