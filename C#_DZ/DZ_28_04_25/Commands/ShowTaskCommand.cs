
using C__DZ.DZ_28_04_25.Commands.Interfaces;
using C__DZ.DZ_28_04_25.Model;
using NLog;

namespace C__DZ.DZ_28_04_25.Commands;

public class ShowTaskCommand(List<TaskToDo> tasks, Action<string> show, Logger logger) : ITaskCommand
{
    public void Execute()
    {
        logger.Info($"Проверяю список задач");

        for (int i = 0; i < tasks.Count; i++)
        {
            show.Invoke($"{i + 1}: {tasks[i]}");
        }
    }
}
