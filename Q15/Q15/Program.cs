namespace SortArrayElementsInDescendingOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[3];
            Console.Write("Input the size of array: ");
            int size = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array: ", size);
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("element - {0}: ", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < size - 1; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (array[i] < array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            Console.WriteLine("Elements of the array in sorted descending order: ");
            foreach (int element in array)
            {
                Console.Write("{0} ", element);
            }
        }
    }
}