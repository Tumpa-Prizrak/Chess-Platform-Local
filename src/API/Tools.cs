using ChessPlatform.API.dtypes;

namespace ChessPlatform.API;

public static class Tools
{
    public static List<Piece> load_from_fen(string fen) // TODO should be changed to custom data type after implementing en passant, 50 moves draw, etc.
    {
        int row, file;
        List<Piece> pieces = new();

        row = file = 0;
        fen = fen.Split(' ')[0];

        foreach (var c in fen)
        {
            if (Char.IsNumber(c))
            {
                file += int.Parse(c.ToString());
            }
            else if (c == '/')
            {
                file = 0;
                ++row;
            }
            else
            {
                switch (c)
                {
                    case 'r':
                        pieces.Add(new Piece(PieceType.Rook, new Square(row, file), false));
                        break;
                    case 'n':
                        pieces.Add(new Piece(PieceType.Knight, new Square(row, file), false));
                        break;
                    case 'b':
                        pieces.Add(new Piece(PieceType.Bishop, new Square(row, file), false));
                        break;
                    case 'q':
                        pieces.Add(new Piece(PieceType.Queen, new Square(row, file), false));
                        break;
                    case 'k':
                        pieces.Add(new Piece(PieceType.King, new Square(row, file), false));
                        break;
                    
                    case 'R':
                        pieces.Add(new Piece(PieceType.Rook, new Square(row, file), true));
                        break;
                    case 'N':
                        pieces.Add(new Piece(PieceType.Knight, new Square(row, file), true));
                        break;
                    case 'B':
                        pieces.Add(new Piece(PieceType.Bishop, new Square(row, file), true));
                        break;
                    case 'Q':
                        pieces.Add(new Piece(PieceType.Queen, new Square(row, file), true));
                        break;
                    case 'K':
                        pieces.Add(new Piece(PieceType.King, new Square(row, file), true));
                        break;
                }
            }

            ++file;
        }

        return pieces;
    }
}