using System.Collections.Generic;

namespace ChessPlatform.API.dtypes;

public class Board
{
    public Square[] Squares = new Square[64];
    public List<Piece> Pieces = new ();
    
    public Board()
    {
        for (int i = 0; i < 64; i++)
        {
            Squares[i] = new Square(i);
        }
    }
}