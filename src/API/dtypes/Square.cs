namespace ChessPlatform.API.dtypes;


/// <summary>
/// Represents a square on a chess board.
/// Contains row, file, index, bitboard representation, and utilities. 
/// </summary>
public class Square
{
    public readonly int Row, File, Index;
    public ulong Bitboard;
    public bool IsNull;
    
    /// <summary>
    /// Creates a Square from a 0-63 index
    /// </summary>
    /// <param name="index">The index of the square (0-63)</param>
    public Square(int index)
    {
        // Set index 
        Index = index;
    
        // Calculate row and file
        Row = index / 8;  
        File = index % 8;
    
        // Set bitboard mask
        Bitboard = (ulong)1 << index; 
    }

    /// <summary>
    /// Creates a Square from a row (0-7) and file (0-7)
    /// </summary>
    /// <param name="row">The row of the square</param>
    /// <param name="file">The file of the square</param>
    public Square(int row, int file)
    {
        // Calculate index
        Index = row * 8 + file;
    
        // Set row and file
        Row = row;
        File = file;
    
        // Set bitboard mask
        Bitboard = (ulong)1 << Index;
    }  

    /// <summary>
    /// Creates an empty, null Square 
    /// </summary>
    public Square()  
    {
        // Set defaults for a null square
        Index = -1;
        Row = -1;
        File = -1; 
        Bitboard = 0;
        IsNull = true;  
    }

    /// <summary>
    /// Gets the screen position of the square
    /// </summary>
    /// <param name="center"><br></br>If true - return coords of the center of the square.<br></br>If false - left up corner</param>
    /// <returns>The (x, y) screen position</returns>
    public (int, int) Position(bool center = false) 
    {
        // Calculate x position based on row, cell size and center parameter
        int x = Row * Settings.CellSize + (center ? Settings.CellSize / 2 : 0);

        // Calculate y position based on file, cell size and center parameter
        int y = File * Settings.CellSize + (center ? Settings.CellSize / 2 : 0);

        return (x, y);
    }
}