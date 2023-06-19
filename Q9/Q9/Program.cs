public class SquareRoot
{
    public static void Main(string[] args)
    {
        double number;

        try
        {
            Console.Write("Enter a real number: ");
            number = double.Parse(Console.ReadLine());

            Console.WriteLine("The square root of {0} is {1}", number, Math.Sqrt(number));
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a valid real number.");
        }
    }
}