using C__DZ.DZ_16_04_25;

List<Student> students = new()
{
    new ("Пётр", 19, 3.6),
    new ("Оксана", 21, 3.4),
    new ("Иван", 22, 3.9),
    new ("Оля", 23, 4.9),
    new ("Тимур", 24, 4.2),
};

foreach (var student in students)
{
    Console.WriteLine(student);
}
Console.WriteLine();

List<Student> students1 = [.. students.Where(student => student.Age > 20 && student.GPA > 3.5)];
                          // students.Where(student => student.Age > 20 && student.GPA > 3.5).ToList()

foreach (var student in students1)
{
    Console.WriteLine(student);
}