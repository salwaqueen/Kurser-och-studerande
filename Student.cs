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

    public override string ToString()
    {
        return Name;
    }
}