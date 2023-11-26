using Raylib_cs;
using ChessPlatform.API;
using ChessPlatform.API.dtypes;

namespace ChessPlatform;

static class Program 
{
    // The main entry point method
    public static void Main()  
    {
        // Set the trace log level from settings
        Raylib.SetTraceLogLevel(Settings.LogLevel);  

        // Initialize the game window 
        Raylib.InitWindow(Settings.CellSize * 8, Settings.CellSize * 8, "Chess!");

        // Create a new board with the FEN from setting
        Board board = new Board(Settings.Fen);   

        // Game loop
        while (!Raylib.WindowShouldClose())  
        {
            // Begin drawing the frame
            Raylib.BeginDrawing();

            // Clear background to black
            Raylib.ClearBackground(Color.BLACK);

            // Draw the chess board
            Drawing.DrawBoard(board);

            // Finish drawing the frame
            Raylib.EndDrawing();
        }

        // Close the game window
        Raylib.CloseWindow();
    }
}
