# Question

If you enter you instructor name it should say “Explain” and if you enter your name, it
should say “Study”.

## Specifications

    1. Create a C# program that prompts the user for three names of people and stores them in an array of Person-type objects. There will be two people of the Student type and one person of the Teacher type.
    2. To do this, create a Person class that has a Name property of type string, a constructor that receives the name as a parameter and overrides the ToString () method.
    3. Then create two more classes that inherit from the Person class, they will be called Student and Teacher.
    4. The Student class has a Study method that writes by console that the student is studying. The Teacher class will have an Explain method that writes to the console that the teacher is explaining. Remember to also create two constructors on the child classes that call the parent constructor of the Person class.
    5. End the program by reading the people (the teacher and the students) and execute the Explain and Study methods.
    6. When defining all the properties, use property concept of C#

Input:
Juan, 
Sara, 
Carlos

Output:
Explain, 
Study, 
Study
