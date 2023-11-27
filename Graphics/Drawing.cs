using API.dtypes;
using Raylib_cs;
using API;
using System.ComponentModel;

namespace Graphics;

public static class Drawing
{
    public static void DrawBoard(Board board)
    {
        foreach (var square in board.Squares)
        {
            var (x, y) = square.Position();
            Raylib.DrawRectangle(x, y, API.Settings.CellSize, API.Settings.CellSize, (square.Row + square.File) % 2 == 0 ? Settings.BgColor1 : Settings.BgColor2);
        }

        foreach (var piece in board.Pieces)
        {
            DrawPiece(piece);
        }
    }

    public static void DrawPiece(Piece piece)
    {
        Texture2D image = ImagePath(piece);
        var (x, y) = piece.Square.Position();
        
        Raylib.DrawTexture(image, x, y, Color.WHITE);
    }

    public static Texture2D ImagePath(Piece piece)
    {
        var color = piece.IsWhite ? "white" : "black";
        Image image = Raylib.LoadImage($"resources\\{color}-{piece.PieceType.ToString().ToLower()}.png");
        return Raylib.LoadTextureFromImage(image);
    }
}
