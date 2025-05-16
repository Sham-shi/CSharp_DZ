
using C__DZ.DZ_28_04_25.Commands.Interfaces;
using C__DZ.DZ_28_04_25.Model;
using NLog;

namespace C__DZ.DZ_28_04_25.Commands;

public class AddTaskCommand(List<TaskToDo> tasks, Logger logger) : ITaskCommand
{
    public void Execute()
    {
        var title = Console.ReadLine();
        var description = Console.ReadLine();

        var taskToDo = new TaskToDo()
        {
            Title = title,
            Description = description
        };

        tasks.Add(taskToDo);

        logger.Info($"Задача {taskToDo.Title} под номером {tasks.Count} добавлена");
    }
}
