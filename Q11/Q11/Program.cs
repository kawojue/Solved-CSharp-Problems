namespace CheckIfFirstOrLastElementAreEqual
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[] { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            int[] array2 = new int[] { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5 };

            bool areEqual = CheckIfFirstOrLastElementAreEqual(array1, array2);

            Console.WriteLine(areEqual);

            Console.ReadKey(true);
        }

        public static bool CheckIfFirstOrLastElementAreEqual(int[] array1, int[] array2)
        {
            if (array1.Length < 1 || array2.Length < 1)
            {
                return false;
            }

            return array1[0] == array2[0] || array1[array1.Length - 1] == array2[array2.Length - 1];
        }
    }
}
