namespace API.dtypes;

public class Square
{
    public int Row, File, Index;
    public ulong Bitboard;
    public bool IsNull;
    
    public Square(int index)
    {
        Index = index;
        Row = index / 8;
        File = index % 8;
        Bitboard = (ulong)1 << index;
    }

    public Square(int row, int file)
    {
        Index = row * 8 + file;
        Row = row;
        File = file;
        Bitboard = (ulong)1 << Index;
    }

    public Square()
    {
        Index = -1;
        Row = -1;
        File = -1;
        Bitboard = 0;
        IsNull = true;
    }

    public (int, int) Position(bool center = false)
    {
        return (
                Row * Settings.CellSize + (center ? Settings.CellSize / 2 : 0), 
                File * Settings.CellSize + (center ? Settings.CellSize / 2 : 0)
            );
    }
}