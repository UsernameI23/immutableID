using System;
using System.Net;

class Program
{
public record Student
{
    // auto-implemented properties
    public int Id { get; init; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // default constructor
    public Student()
    {
        Id = 0;
        FirstName = "";
        LastName = "";
    }
    // parameterized constructor

    public Student(int i, string First, string Last)
    {
        Id = i;
        FirstName = First;
        LastName = Last;
    }
    public static void Main()
    {
        Student student = new(32,"Emma", "Madison");
        Console.WriteLine(student);
        Student student2 = new();
        student2.FirstName = "James";
        student2.LastName = "Williams";
        Console.WriteLine(student2);

        

    }
}
}

