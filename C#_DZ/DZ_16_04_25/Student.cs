
namespace C__DZ.DZ_16_04_25;

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double GPA { get; set; }

    public Student(string name, int age, double gPA)
    {
        Name = name;
        Age = age;
        GPA = gPA;
    }

    public override string ToString()
    {
        return $"Имя: {Name}, Возраст: {Age}, Средний бал: {GPA}";
    }
}
