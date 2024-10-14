using game;

class MainProgram
{
    static void Main(string[] args)
    {
        Grid g = new Grid(20);
        //glider:
        //g.SetCoord(1, 1);
        //g.SetCoord(3, 1);
        //g.SetCoord(2, 2);
        //g.SetCoord(3, 2);
        //g.SetCoord(2, 3);

        //Oscillator:
        g.SetCoord(5, 10);
        g.SetCoord(6, 10);
        g.SetCoord(7, 9);
        g.SetCoord(7, 11);
        g.SetCoord(8, 10);
        g.SetCoord(9, 10);
        g.SetCoord(10, 10);
        g.SetCoord(11, 10);
        g.SetCoord(12, 9);
        g.SetCoord(12, 11);
        g.SetCoord(13, 10);
        g.SetCoord(14, 10);
        var run = true;
        while (run)
        {
            g.NewGeneration();
            g.DisplayBoard();
            Thread.Sleep(150);
        }
    }
}