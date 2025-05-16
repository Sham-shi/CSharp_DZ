
namespace C__DZ.DZ_28_04_25.Model;

public class TaskToDo
{
    public required string Title { get; set; }
    public required string Description { get; set; }
    public bool IsComplete { get; private set; }

    public void ChangeComplete()
    {
        IsComplete = !IsComplete;
    }

    public override string ToString()
    {
        return $"Название: {Title}, Описание: {Description}, Статус: {GetTextComplete()}";
    }

    private string GetTextComplete()
    {
        if (IsComplete)
        {
            return "Завершена";
        }

        return "Активна";
    }
}
