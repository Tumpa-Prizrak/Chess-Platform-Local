namespace ChessPlatform.API.dtypes;

public class Square
{
    public int Row, File, Index;
    public uint Bitboard;
    public bool IsNull = false;
    
    public Square(int index)
    {
        Index = index;
        Row = index / 8;
        File = index % 8;
        Bitboard = (uint)1 << index;
    }

    public Square(int row, int file)
    {
        Index = row * 8 + file;
        Row = row;
        File = file;
        Bitboard = (uint)1 << Index;
    }

    public Square()
    {
        Index = -1;
        Row = -1;
        File = -1;
        Bitboard = 0;
        IsNull = true;
    }
}