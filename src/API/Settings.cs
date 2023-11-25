using Raylib_cs;

namespace ChessPlatform.API;

public static class Settings
{
    public const int CellSize = 128; // Cell size in pixels
    public const TraceLogLevel LogLevel = TraceLogLevel.LOG_WARNING;
    public const string Fen = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1";

    public static Color BgColor1 = new (118, 150, 86, 255);
    public static Color BgColor2 = new (238, 238, 210, 255);
}
