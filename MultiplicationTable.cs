ConsoleApplication.Run();

public class ConsoleApplication
{
    public static void Run()
    {
        Console.Write("Enter starting value for rows: ");
        int startingRow = int.Parse(Console.ReadLine());
        Console.Write("Enter ending value for rows: ");
        int endingRow = int.Parse(Console.ReadLine());
        Console.Write("Enter starting value for columns: ");
        int startingColumn = int.Parse(Console.ReadLine());
        Console.Write("Enter ending value for columns: ");
        int endingColumn = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.Write("\t");
        for (int j = startingColumn; j <= endingColumn; j++)
        {
            Console.Write($"{j}\t");
        }
        Console.WriteLine();

        Console.Write("============================================================\n");

        for (int i = startingRow; i <= endingRow; i++)
        {
            Console.Write($"{i}\t");
            for (int j = startingColumn; j <= endingColumn; j++)
            {
                Console.Write($"{i * j}\t");
            }
            Console.WriteLine();
        }
    }
}