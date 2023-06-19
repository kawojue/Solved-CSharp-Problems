public class Person
{
    public string Name { get; set; }

    public Person(string name)
    {
        Name = name;
    }

    public override string ToString()
    {
        return Name;
    }
}

public class Student : Person
{
    public Student(string name) : base(name) { }

    public void Study()
    {
        Console.WriteLine($"{Name} is studying..");
    }
}

public class Teacher : Person
{
    public Teacher(string name) : base(name) { }

    public void Explain()
    {
        Console.WriteLine($"{Name} is explaining..");
    }
}

public class Program
{
    public static void Main()
    {
        Person[] people = new Person[3];
        Console.Write("Name of teacher: ");
        string teacherName = Console.ReadLine();
        people[0] = new Teacher(teacherName);

        Console.Write("Name of first student: ");
        string student1Name = Console.ReadLine();
        people[1] = new Student(student1Name);

        Console.Write("Name of second student: ");
        string student2Name = Console.ReadLine();
        people[2] = new Student(student2Name);

        Console.WriteLine();

        foreach (Person person in people)
        {
            if (person is Teacher)
            {
                Teacher teacher = (Teacher)person;
                teacher.Explain();
            }
            else if (person is Student)
            {
                Student student = (Student)person;
                student.Study();
            }
        }
    }
}