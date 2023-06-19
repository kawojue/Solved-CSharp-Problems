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
    public int Id { get; set; }
    public string CourseEnrolled { get; set; }

    public Student(string name, int id, string courseEnrolled) : base(name)
    {
        Id = id;
        CourseEnrolled = courseEnrolled;
    }

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

        Console.Write("Name of the first student: ");
        string student1Name = Console.ReadLine();

        Console.Write("ID of the first student: ");
        int student1Id = int.Parse(Console.ReadLine());

        Console.Write("Course enrolled by the first student: ");
        string student1Course = Console.ReadLine();
        people[0] = new Student(student1Name, student1Id, student1Course);
        Console.WriteLine();

        Console.Write("Name of the second student: ");
        string student2Name = Console.ReadLine();

        Console.Write("ID of the second student: ");
        int student2Id = int.Parse(Console.ReadLine());

        Console.Write("Course enrolled by the second student: ");
        string student2Course = Console.ReadLine();
        people[1] = new Student(student2Name, student2Id, student2Course);
        Console.WriteLine();

        Console.Write("Name of the teacher: ");
        string teacherName = Console.ReadLine();
        people[2] = new Teacher(teacherName);

        foreach (Person person in people)
        {
            if (person is Student)
            {
                Student student = (Student)person;
                student.Study();
            }
            else if (person is Teacher)
            {
                Teacher teacher = (Teacher)person;
                teacher.Explain();
            }
        }

        Console.WriteLine();

        Queue<Student> studentQueue = new Queue<Student>();

        // Store 5 students' information in the queue
        studentQueue.Enqueue(new Student("Victor", 101, "Math"));
        studentQueue.Enqueue(new Student("Raheem", 102, "Science"));
        studentQueue.Enqueue(new Student("Muyiwa", 103, "English"));
        studentQueue.Enqueue(new Student("VickyJay", 104, "History"));
        studentQueue.Enqueue(new Student("Kawojue", 105, "Computer Science"));

        // Sort the students using a lambda expression and print their names in sorting order
        var sortedStudents = studentQueue.OrderBy(student => student.Name);
        foreach (var student in sortedStudents)
        {
            Console.WriteLine(student.Name);
        }

        // Iterate over the queue, remove each element, and print their details simultaneously
        while (studentQueue.Count > 0)
        {
            Student student = studentQueue.Dequeue();
            Console.WriteLine($"Name: {student.Name}\n\tID: {student.Id}\n\tCourse Enrolled: {student.CourseEnrolled}");
        }
    }
}