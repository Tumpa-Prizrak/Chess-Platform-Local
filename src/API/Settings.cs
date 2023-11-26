using Raylib_cs;

namespace ChessPlatform.API;

/// <summary>
/// Contains configurable settings for the chess game.
/// </summary>
public static class Settings
{
    // The size of each chess board cell in pixels
    public const int CellSize = 128;  

    // The level of logging to output
    public const TraceLogLevel LogLevel = TraceLogLevel.LOG_WARNING;

    // Default starting FEN board position  
    public const string Fen = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1";

    // Background color 1 for the chess board
    public static Color BgColor1 = new (118, 150, 86, 255);  

    // Background color 2 for the chess board
    public static Color BgColor2 = new (238, 238, 210, 255);
}
