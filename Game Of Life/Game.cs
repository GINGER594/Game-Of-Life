using System.Data;

namespace game;

class Grid
{
    char[][] grid;
    public Grid(int size)
    {
        grid = new char[size][];
        for (int i = 0; i < grid.Length; i++)
        {
            char[] row = new char[size];
            for (int j = 0; j < row.Length; j++)
            {
                row[j] = ' ';
            }
            grid[i] = row;
        }
    }

    public void SetCoord(int x, int y)
    {
        grid[y][x] = '+';
    }

    public bool CheckCell(int x, int y)
    {
        var neighbours = 0;
        var arrLength = grid.Length - 1;
        if (x > 0)
        {
            if (grid[y][x - 1] == '+')
            {
                neighbours += 1;
            }
        }
        if (x < arrLength)
        {
            if (grid[y][x + 1] == '+')
            {
                neighbours += 1;
            }
        }
        if (y > 0)
        {
            if (grid[y - 1][x] == '+')
            {
                neighbours += 1;
            }
        }
        if (y < arrLength)
        {
            if (grid[y + 1][x] == '+')
            {
                neighbours += 1;
            }
        }
        if ((x > 0) & (y < arrLength))
        {
            if (grid[y + 1][x - 1] == '+')
            {
                neighbours += 1;
            }
        }
        if ((x < arrLength) & (y > 0))
        {
            if (grid[y - 1][x + 1] == '+')
            {
                neighbours += 1;
            }
        }
        if ((x > 0) & (y > 0))
        {
            if (grid[y - 1][x - 1] == '+')
            {
                neighbours += 1;
            }
        }
        if ((x < arrLength) & (y < arrLength))
        {
            if (grid[y + 1][x + 1] == '+')
            {
                neighbours += 1;
            }
        }

        if ((neighbours == 2 & grid[y][x] == '+') || (neighbours == 3))
        {
            return true;
        }
        return false;
    }

    public void NewGeneration()
    {
        char[][] newgrid = new char[grid.Length][];
        for (int y = 0; y < grid.Length; y++)
        {
            char[] row = new char[grid.Length];
            for (int x = 0; x < grid.Length; x++)
            {
                if (CheckCell(x, y))
                {
                    row[x] = '+';
                }
                else
                {
                    row[x] = ' ';
                }
            }
            newgrid[y] = row;
        }
        grid = newgrid;
    }

    public void DisplayBoard()
    {
        Console.Clear();
        Console.WriteLine(new string('-', (grid.Length * 2) + 2));
        foreach (char[] row in grid)
        {
            Console.Write("|");
            foreach (char cell in row)
            {
                Console.Write(cell + " ");
            }
            Console.Write("|\n");
        }
        Console.WriteLine(new string('-', (grid.Length * 2) + 2));
    }
}