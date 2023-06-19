namespace Dcoder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int temp;
            int first;
            int second;

            Console.Write("First number: ");
            first = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second number: ");
            second = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before Swapping:\n\tfirst = " + first + "\n\tsecond= " + second);

            temp = first;
            first = second;
            second = temp;

            Console.WriteLine("After Swapping:\n\tfirst = " + first + "\n\tsecond= " + second);
        }
    }
}