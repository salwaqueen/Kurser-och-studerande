using System.Collections.Generic;

public class Student
{
    public string Name;
    public List<Course> Courses = new List<Course>();

    public Student(string name)
    {
        Name = name;
    }

    public void Join(Course course)
    {
        course.Enroll(this);
    }

    public void Leave(Course course)
    {
        course.Remove(this);
    }
public void Schedule()
{
    Console.WriteLine($"\nKurser för {Name}:");

    if (Courses.Count == 0)
    {
        Console.WriteLine("Inga kurser är registrerade.");
        return;
    }

    foreach (Course course in Courses)
    {
        Console.WriteLine(course);
    }
}
    public override string ToString()
    {
        return Name;
    }
}