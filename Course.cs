using System;
using System.Collections.Generic;

public class Course
{
    public string Name;
    public int MaxSeats;
    public List<Student> Students = new List<Student>();

    public Course(string name, int maxSeats)
    {
        Name = name;
        MaxSeats = maxSeats;
    }

    public void Enroll(Student student)
    {
        if (Students.Contains(student))
        {
            Console.WriteLine($"{student.Name} är redan registrerad på {Name}.");
            return;
        }

        if (Students.Count >= MaxSeats)
        {
            Console.WriteLine($"{Name} är full.");
            return;
        }

        Students.Add(student);
        student.Courses.Add(this);

        Console.WriteLine($"{student.Name} har registrerats på {Name}.");
    }

    public void Remove(Student student)
    {
        if (!Students.Contains(student))
        {
            Console.WriteLine($"{student.Name} är inte registrerad på {Name}.");
            return;
        }

        Students.Remove(student);
        student.Courses.Remove(this);

        Console.WriteLine($"{student.Name} har avregistrerats från {Name}.");
    }
public void RollCall()
{
    Console.WriteLine($"\nDeltagare i {Name}:");

    if (Students.Count == 0)
    {
        Console.WriteLine("Inga studenter är registrerade.");
        return;
    }

    foreach (Student student in Students)
    {
        Console.WriteLine(student);
    }
}
    public override string ToString()
    {
        return $"{Name} ({Students.Count}/{MaxSeats} platser)";
    }
}