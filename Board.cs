using System.Data;

class Board
{
    int[,] cells = new int[3, 3];

    public int this[int row, int col]
    {
        get { return cells[row, col]; }
        set { cells[row, col] = value; }
    }
}