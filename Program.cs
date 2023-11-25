using Raylib_cs;
using ChessPlatform.API;
using ChessPlatform.API.dtypes;

namespace ChessPlatform;

static class Program
{
    public static void Main()
    {
        Raylib.SetTraceLogLevel(Settings.LogLevel);
        Raylib.InitWindow(Settings.CellSize * 8, Settings.CellSize * 8, "Chess!");

        Board board = new Board(Settings.Fen);

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