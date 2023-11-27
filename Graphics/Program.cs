using Raylib_cs;
using API.dtypes;
using System.Drawing;

namespace Graphics;

static class Program
{
    public static void Main()
    {
        Raylib.SetTraceLogLevel(Settings.LogLevel);
        Raylib.InitWindow(API.Settings.CellSize * 8, API.Settings.CellSize * 8, "Chess!");

        Board board = new Board(API.Settings.Fen);

        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();

            Raylib.ClearBackground(Raylib_cs.Color.BLACK);

            Drawing.DrawBoard(board);

            Raylib.EndDrawing();
        }

        Raylib.CloseWindow();
    }
}