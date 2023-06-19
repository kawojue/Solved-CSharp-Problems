public class NumberKeyPress
{
    public static void Main(string[] args)
    {
        Console.Write("Press a number key from 0 to 9: ");
        char key = Console.ReadKey().KeyChar;

        Console.WriteLine("\n");

        if (key >= '0' && key <= '9')
        {
            Console.WriteLine("You pressed: " + key);
        }
        else
        {
            Console.WriteLine("Not allowed");
        }
    }
}