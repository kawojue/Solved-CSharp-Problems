public class SumTriple
{
    public static void Main(string[] args)
    {
        Console.Write("Num 1: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Num 2: ");
        int b = int.Parse(Console.ReadLine());

        int sum = Sum(a, b);

        if (a == b)
        {
            sum *= 3;
        }

        Console.WriteLine("The sum of the two numbers is: " + sum);
    }

    public static int Sum(int a, int b)
    {
        return a + b;
    }
}