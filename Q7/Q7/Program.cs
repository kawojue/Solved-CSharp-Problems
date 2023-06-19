public class Convert
{
    public static void Main(string[] args)
    {
        Console.Write("Celcius Degree: ");
        int c = int.Parse(Console.ReadLine());
        int k = ConvertToKelvin(c);
        int f = ConvertToFahrenheit(c);

        Console.WriteLine("Kelvin = " + k + "\nFahrenheit = " + f);
    }

    public static int ConvertToKelvin(int c)
    {
        return c + 273;
    }
    public static int ConvertToFahrenheit(int c)
    {
        return c * 18 / 10 + 32;
    }
}