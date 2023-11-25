using ChessPlatform.API.dtypes;
using Raylib_cs;

namespace ChessPlatform.API;

public class Drawing
{
    public static void DrawBoard(Board board)
    {
        foreach (var square in board.Squares)
        {
            var (x, y) = square.Position();
            Raylib.DrawRectangle(x, y, Settings.CellSize, Settings.CellSize, (square.Row + square.File) % 2 == 0 ? Color.GRAY : Color.BROWN);
        }

        foreach (var piece in board.Pieces)
        {
            DrawPiece(piece);
        }
    }

    public static void DrawPiece(Piece piece)
    {
        Texture2D image = piece.ImagePath();
        var (x, y) = piece.Square.Position();
        
        Raylib.DrawTexture(image, x, y, Color.WHITE);
    }
}