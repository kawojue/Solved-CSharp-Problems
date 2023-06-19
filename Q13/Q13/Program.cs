namespace AddFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = Add(1, 2, 3, 4, 5);
            Console.WriteLine(sum);
        }
        public static int Add(params int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            return sum;
        }
    }
}