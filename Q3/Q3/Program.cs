// Q3 — Stack

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a sequence of characters: ");
        string input = Console.ReadLine();

        string reversed = ReverseString(input);
        Console.WriteLine("Reversed string: " + reversed);
    }

    static string ReverseString(string input)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char c in input)
        {
            stack.Push(c);
        }

        string reversed = "";
        while (stack.Count > 0)
        {
            reversed += stack.Pop();
        }

        return reversed;
    }
}