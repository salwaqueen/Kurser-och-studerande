Course math = new Course("Matematik", 2);

Student salwa = new Student("Salwa");
Student ali = new Student("Ali");
Student sara = new Student("Sara");

math.Enroll(salwa);
salwa.Join(math);
ali.Join(math);
sara.Join(math);

Console.WriteLine();
Console.WriteLine(math);
Console.WriteLine($"Salwas kurser: {salwa.Courses.Count}");
Console.WriteLine($"Alis kurser: {ali.Courses.Count}");
Console.WriteLine($"Saras kurser: {sara.Courses.Count}");