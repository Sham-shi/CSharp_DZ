
using C__DZ.DZ_09_04_25;
using C__DZ.DZ_28_04_25.Commands.Interfaces;
using C__DZ.DZ_28_04_25.Model;
using NLog;

namespace C__DZ.DZ_28_04_25.Commands;

public class UpdateTaskCommand(List<TaskToDo> tasks, Logger logger) : ITaskCommand
{
    public void Execute()
    {
        try
        {
            string input = Console.ReadLine();

            logger.Info($"Получаю запись задачи по номеру: {input}");

            if (int.TryParse(input, out var numberTask))
            {
                if (tasks.Count >= numberTask && numberTask > 0)
                {
                    var task = tasks[numberTask - 1];

                    var title = Console.ReadLine();
                    var description = Console.ReadLine();

                    task.Title = title;
                    task.Description = description;

                    logger.Info($"Задача {task.Title} обновлена");
                }
                else
                {
                    logger.Warn($"Попытка обратиться к несуществующему номеру задачи: {numberTask}");
                }
            }
            else
            {
                logger.Warn($"Неверный ввод: {input}");
            }
        }
        catch(Exception ex)
        {
            logger.Error(ex.Message);
        }
    }
}
