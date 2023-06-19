namespace CopyArrayElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[3];

            Console.Write("Input the number of elements to be stored in the array: ");
            int numberOfElements = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array: ", numberOfElements);
            for (int i = 0; i < numberOfElements; i++)
            {
                Console.Write("element - {0}: ", i);
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] array2 = new int[array1.Length];
            Array.Copy(array1, 0, array2, 0, array1.Length);

            Console.Write("The elements stored in the first array are: ");
            foreach (int element in array1)
            {
                Console.Write("{0} ", element);
            }

            Console.WriteLine();

            Console.Write("The elements copied into the second array are: ");
            foreach (int element in array2)
            {
                Console.Write("{0} ", element);
            }
        }
    }
}