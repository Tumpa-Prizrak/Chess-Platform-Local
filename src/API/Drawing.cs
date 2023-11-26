using ChessPlatform.API.dtypes;
using Raylib_cs;

namespace ChessPlatform.API;

public static class Drawing
{
    /// <summary>
    /// Draws the chess board and pieces
    /// </summary>
    /// <param name="board">The Board to draw</param>
    public static void DrawBoard(Board board)
    {
        // Draw the chess board squares
        foreach (var square in board.Squares)
        {
            var (x, y) = square.Position();
            Raylib.DrawRectangle(x, y, Settings.CellSize, Settings.CellSize, (square.Row + square.File) % 2 == 0 ? Settings.BgColor1 : Settings.BgColor2);
        }

        // Draw each chess piece 
        foreach (var piece in board.Pieces)
        {
            DrawPiece(piece);
        }
    }
    
    /// <summary>
    /// Draws a chess piece on the board 
    /// </summary>
    /// <param name="piece">The Piece object to draw</param>
    public static void DrawPiece(Piece piece)
    {
        Texture2D image = piece.ImagePath();
        var (x, y) = piece.Square.Position();
        
        Raylib.DrawTexture(image, x, y, Color.WHITE);
    }
}
