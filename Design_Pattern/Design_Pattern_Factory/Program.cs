using System;


public interface IStudentFactory
{
    Student CreateStudent(string name, int age);
}
public class StudentFactory : IStudentFactory
{
    public Student CreateStudent(string name, int age)
    {
        return new Student(name, age);
    }
}
public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Student: {Name}, Age: {Age}");
    }
}
public class SchoolFactory
{
    public static School CreateSchool(string name)
    {
        return new School(name);
    }
}
public class School
{
    public string Name { get; set; }

    public School(string name)
    {
        Name = name;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"School: {Name}");
    }
}
class Program
{
    static void Main()
    {
        // Sử dụng StudentFactory để tạo đối tượng Student
        IStudentFactory studentFactory = new StudentFactory();
        Student student = studentFactory.CreateStudent("John Doe", 20);
        student.DisplayInfo();

        // Sử dụng SchoolFactory để tạo đối tượng School
        School school = SchoolFactory.CreateSchool("Example School");
        school.DisplayInfo();
    }
}
