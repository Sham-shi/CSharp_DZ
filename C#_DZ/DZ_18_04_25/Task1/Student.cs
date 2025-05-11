namespace C__DZ.DZ_18_04_25.Task1;

public class Student
{
    public string Name { get; set; }
    public int Score { get; set; }

    public override string ToString()
    {
        return $"Имя: {Name}, Оценка: {Score}";
    }
}
