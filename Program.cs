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
Console.WriteLine("\n--- Test av avregistrering ---");

math.Remove(salwa);
ali.Leave(math);
math.Remove(salwa);

Console.WriteLine(math);
Console.WriteLine($"Salwas kurser: {salwa.Courses.Count}");
Console.WriteLine($"Alis kurser: {ali.Courses.Count}");

sara.Join(math);
Console.WriteLine(math);
Console.WriteLine($"Saras kurser: {sara.Courses.Count}");
Console.WriteLine("\n--- Test av listor ---");

Course programming = new Course("Programmering", 3);

programming.RollCall();
salwa.Schedule();

programming.Enroll(salwa);
sara.Join(programming);

math.RollCall();
programming.RollCall();

salwa.Schedule();
ali.Schedule();
sara.Schedule();