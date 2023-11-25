using Raylib_cs;
using ChessPlatform.API;
using ChessPlatform.API.dtypes;

namespace ChessPlatform;

static class Program
{
    public static void Main()
    {
        Raylib.InitWindow(Settings.CellSize * 8, Settings.CellSize * 8, "Chess!");
        Board board = new Board();
        board.AddPiece(new Piece(PieceType.King, new Square(0), true));
        board.AddPiece(new Piece(PieceType.Queen, new Square(1), true));
        board.AddPiece(new Piece(PieceType.King, new Square(50)));
        board.AddPiece(new Piece(PieceType.Queen, new Square(51)));

        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();

            Raylib.ClearBackground(Color.BLACK);

            Drawing.DrawBoard(board);

            Raylib.EndDrawing();
        }

        Raylib.CloseWindow();
    }
}