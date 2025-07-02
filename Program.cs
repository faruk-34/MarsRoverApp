using MarsRoverApp;

class Program
{
    static void Main()
    {
        // Mars yüzey boyutu
        string[] surfaceInput = Console.ReadLine().Split(' ');
        var plateau = new Plateau(int.Parse(surfaceInput[0]), int.Parse(surfaceInput[1]));

        // İlk rover
        string[] rover1Pos = Console.ReadLine().Split(' ');
        var rover1 = new Rover(
            int.Parse(rover1Pos[0]),
            int.Parse(rover1Pos[1]),
            char.Parse(rover1Pos[2]),
            plateau
        );
        string rover1Commands = Console.ReadLine();
        rover1.ExecuteCommands(rover1Commands);

        // İkinci rover
        string[] rover2Pos = Console.ReadLine().Split(' ');
        var rover2 = new Rover(
            int.Parse(rover2Pos[0]),
            int.Parse(rover2Pos[1]),
            char.Parse(rover2Pos[2]),
            plateau
        );
        string rover2Commands = Console.ReadLine();
        rover2.ExecuteCommands(rover2Commands);
        Console.ReadLine();  

        // Çıktılar
        Console.WriteLine(rover1.GetCurrentPosition());
        Console.WriteLine(rover2.GetCurrentPosition());
    }
}