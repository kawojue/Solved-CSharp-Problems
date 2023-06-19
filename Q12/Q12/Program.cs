namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("String: ");
            string inputString = Console.ReadLine();

            bool isPalindrome = IsPalindrome(inputString);
            Console.WriteLine(isPalindrome);
        }

        public static bool IsPalindrome(string inputString)
        {
            char[] chars = inputString.ToCharArray();

            int start = 0;
            int end = chars.Length - 1;

            while (start < end)
            {
                if (chars[start] != chars[end])
                {
                    return false;
                }

                start++;
                end--;
            }

            return true;
        }
    }
}