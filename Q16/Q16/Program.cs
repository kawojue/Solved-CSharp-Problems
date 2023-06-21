class Customer
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
}

class Program
{
    static Customer[] customers = new Customer[7];

    static void Main()
    {
        // Initialize customer array with sample data
        customers[0] = new Customer { Id = 1, FirstName = "Kawojue", LastName = "Raheem", DateOfBirth = new DateTime(1990, 5, 15) };
        customers[1] = new Customer { Id = 2, FirstName = "Victor", LastName = "Ola", DateOfBirth = new DateTime(1985, 10, 20) };
        customers[2] = new Customer { Id = 3, FirstName = "Always", LastName = "Appear", DateOfBirth = new DateTime(1982, 3, 8) };
        customers[3] = new Customer { Id = 4, FirstName = "Muyiwa", LastName = "Kawojue", DateOfBirth = new DateTime(1992, 7, 2) };
        customers[4] = new Customer { Id = 5, FirstName = "Vicky", LastName = "Jay", DateOfBirth = new DateTime(1989, 9, 12) };
        customers[5] = new Customer { Id = 6, FirstName = "Alice", LastName = "Bob", DateOfBirth = new DateTime(1995, 12, 30) };
        customers[6] = new Customer { Id = 7, FirstName = "Me", LastName = "Myself", DateOfBirth = new DateTime(1987, 2, 25) };

        // Prompt the user for input and perform the required operations
        Console.Write("Enter customer ID to search: ");
        int customerId = Convert.ToInt32(Console.ReadLine());

        var customer = GetCustomerById(customerId);
        if (customer != null)
        {
            Console.WriteLine($"Customer Name: {customer.FirstName} {customer.LastName}");
        }
        else
        {
            Console.WriteLine("Customer doesn't exist");
        }

        Console.Write("\nEnter first name to search customer's date of birth: ");
        string firstName = Console.ReadLine();

        var customerDateOfBirth = GetCustomerDateOfBirth(firstName);
        if (customerDateOfBirth != DateTime.MinValue)
        {
            Console.WriteLine($"Customer Date of Birth: {customerDateOfBirth.ToShortDateString()}");
        }
        else
        {
            Console.WriteLine("Customer doesn't exist");
        }

        Console.WriteLine("\nSorted list of customers by first name:");
        SortCustomersByFirstName();
    }

    static Customer GetCustomerById(int id)
    {
        return customers.FirstOrDefault(c => c.Id == id);
    }

    static DateTime GetCustomerDateOfBirth(string firstName)
    {
        var customer = customers.FirstOrDefault(c => c.FirstName == firstName);
        if (customer != null)
        {
            return customer.DateOfBirth;
        }
        return DateTime.MinValue;
    }

    static void SortCustomersByFirstName()
    {
        var sortedCustomers = customers.OrderBy(c => c.FirstName);
        foreach (var customer in sortedCustomers)
        {
            Console.WriteLine($"{customer.FirstName} {customer.LastName}");
        }
    }
}