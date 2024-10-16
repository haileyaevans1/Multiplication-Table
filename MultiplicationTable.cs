using System
public class MultiplicationTable
{
    static void Main() args
    {
        console.WriteLine("Enter starting value for rows: ");
        int startingRow = console.ReadLine();
        console.WriteLine("Enter ending value for rows: ");
        int endingRow = console.ReadLine();
        console.WriteLine("Enter starting value for columns: ");
        int startingColumn = console.ReadLine();
        console.WriteLine("Enter ending value for columns: ");
        int endingColumn = console.ReadLine();

        for (int i = startingRow; i <= endingRow; i++)
        {
            for (int j = startingColumn; j <= endingColumn; j++)
            {
                Console.Write($"{i * j}\t");
            }
            Console.WriteLine();
        }
    }
}