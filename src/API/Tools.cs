using ChessPlatform.API.dtypes;

namespace ChessPlatform.API;

/// <summary>
/// Provides utility methods for working with chess tools and notation.
/// </summary>
public static class Tools
{
    /// <summary>
    /// Parses a FEN (Forsyth-Edwards Notation) string to generate a list of Piece objects on the board
    /// </summary>
    /// <param name="fen">The FEN string to parse</param>
    /// <returns>A list of Piece objects representing the board position</returns>
    public static List<Piece> load_from_fen(string fen) 
    {
        // List to hold parsed pieces 
        List<Piece> pieces = new List<Piece>();

        // Current row and file we are parsing
        int row = 0; 
        int file = 0;

        // Split FEN string to get just the board position part
        fen = fen.Split(' ')[0];  

        foreach (var c in fen)
        {
            // If character is a digit, increment file
            if (char.IsDigit(c))  
            {
                file += int.Parse(c.ToString());
            } 
            else if (c == '/')
            {
                // Slash indicates new row
                ++row;
                file = 0; 
            }
            else
            {
                // Otherwise, parse piece at current position
                pieces.Add(new Piece(CharToPieceType(char.ToLower(c)), new Square(file, row), !char.IsLower(c)));
                ++file;
            }
        }

        return pieces;
    }


    /// <summary>
    /// Converts a character representing a chess piece to the corresponding PieceType enum value
    /// </summary>
    /// <param name="c">The character representing the chess piece</param>
    /// <returns>The PieceType enum value for the given character</returns>
    public static PieceType CharToPieceType(char c)
    {
        switch (c)
        {
            case 'p':  
                return PieceType.Pawn;
            case 'r':
                return PieceType.Rook;
            case 'n':
                return PieceType.Knight;
            case 'b':
                return PieceType.Bishop;
            case 'q':
                return PieceType.Queen;
            case 'k':
                return PieceType.King;
        
            // Invalid piece
            default:
                return PieceType.None;
        }
    }

}