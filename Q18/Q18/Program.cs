public class Fibonacci
{
    private int n1;
    private int n2;

    public Fibonacci()
    {
        n1 = 0;
        n2 = 1;
    }

    public Fibonacci(int firstTerm, int secondTerm)
    {
        n1 = firstTerm;
        n2 = secondTerm;
    }

    public int CalculateNext()
    {
        int next = n1 + n2;
        n1 = n2;
        n2 = next;
        return next;
    }

    public static Fibonacci operator +(Fibonacci fib, int m)
    {
        Fibonacci result = new Fibonacci(fib.n1, fib.n2);
        for (int i = 0; i < m; i++)
        {
            result.CalculateNext();
        }
        return result;
    }

    public static Fibonacci operator ++(Fibonacci fib)
    {
        return fib + 1;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Fibonacci fib = new Fibonacci();
        Console.Write("Enter the value of n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        // Generate nth order Fibonacci number
        for (int i = 2; i < n; i++)
        {
            fib.CalculateNext();
        }

        Console.WriteLine($"The {n}th order Fibonacci number is: {fib.CalculateNext()}");

        // Calculate (n+1)th order Fibonacci number using ++
        Fibonacci fibPlusOne = fib++;
        Console.WriteLine($"The {(n + 1)}th order Fibonacci number is: {fibPlusOne.CalculateNext()}");

        // Calculate (n+m)th order Fibonacci number using +
        Console.Write("\nEnter the value of m: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Fibonacci fibPlusM = fib + m;
        Console.WriteLine($"The {(n + m)}th order Fibonacci number is: {fibPlusM.CalculateNext()}");
    }
}