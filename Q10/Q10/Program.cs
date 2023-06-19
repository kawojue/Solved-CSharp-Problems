namespace NestedStruct
{
    struct Employee
    {
        public string Name { get; set; }
        public Date BirthDate { get; set; }
    }

    struct Date
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[2];

            employees[0] = new Employee()
            {
                Name = "H.Rana",
                BirthDate = new Date()
                {
                    Day = 5,
                    Month = 2,
                    Year = 58
                }
            };

            employees[1] = new Employee()
            {
                Name = "S.Mathur",
                BirthDate = new Date()
                {
                    Day = 4,
                    Month = 8,
                    Year = 59
                }
            };

            foreach (Employee employee in employees)
            {
                Console.WriteLine("Name: {0}, Birth Date: {1}/{2}/{3}", employee.Name, employee.BirthDate.Day, employee.BirthDate.Month, employee.BirthDate.Year);
            }
        }
    }
}
