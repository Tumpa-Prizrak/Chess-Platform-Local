using Raylib_cs;

namespace ChessPlatform;

class Program
{
    public static void Main()
    {
        Raylib.InitWindow(1280, 720, "Hello World");

        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.BLACK);

            Raylib.DrawText("Hello, world!", 800 / 2, 480 / 2, 20, Color.WHITE );

            Raylib.EndDrawing();
        }

        Raylib.CloseWindow();
    }
}