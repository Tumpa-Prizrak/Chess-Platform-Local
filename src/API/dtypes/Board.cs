namespace ChessPlatform.API.dtypes;

/// <summary>
/// Represents a chess board with squares and pieces
/// </summary>
public class Board
{
    /// <summary>
    /// Array of 64 squares on the board
    /// </summary>
    public readonly Square[] Squares = new Square[64];

    /// <summary>
    /// List of pieces currently on the board
    /// </summary>
    public readonly List<Piece> Pieces = new();

    /// <summary>
    /// Constructs an empty board with 64 squares
    /// </summary>
    public Board()
    {
        // Initialize all 64 squares
        for (int i = 0; i < 64; i++) 
        {
            Squares[i] = new Square(i);
        }
    }

    /// <summary>
    /// Constructs a board from a FEN string, including pieces
    /// </summary>
    /// <param name="fen">FEN string representing board state</param>
    public Board(string fen)
    {
        // Initialize all 64 squares 
        for (int i = 0; i < 64; i++)
        {
            Squares[i] = new Square(i);
        }

        // Add pieces from FEN
        Pieces = Tools.load_from_fen(fen);
    }

    /// <summary>
    /// Adds a piece to the board
    /// </summary>
    /// <param name="piece">Piece to add</param>  
    public void AddPiece(Piece piece)
    {
        Pieces.Add(piece);
    }
}
