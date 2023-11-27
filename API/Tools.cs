using API.dtypes;

namespace API;

public static class Tools
{
    public static List<Piece> load_from_fen(string fen) // TODO should be changed to custom data type after implementing en passant, 50 moves draw, etc.
    {
        List<Piece> pieces = new List<Piece>();
        int row = 0; int file = 0;
        fen = fen.Split(' ')[0];

        foreach (var c in fen)
        {
            if (char.IsDigit(c))
            {
                file += int.Parse(c.ToString());
            } else if (c == '/')
            {
                ++row;
                file = 0;
            }
            else
            {
                pieces.Add(new Piece(CharToPieceType(char.ToLower(c)), new Square(file, row), !char.IsLower(c)));
                ++file;
            }
        }

        return pieces;
    }

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
            default:
                return PieceType.None;
        }
    }
}