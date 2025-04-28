
namespace C__DZ.DZ_25_04_25.Task1;

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public List<int> Grades { get; set; }

    public override string ToString()
    {
        return $"Имя: {Name}, Возраст: {Age}, Оценки:  {{{String.Join(", ", Grades)}}}";
    }
}
