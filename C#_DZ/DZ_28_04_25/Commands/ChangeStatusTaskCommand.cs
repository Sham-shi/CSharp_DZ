
using C__DZ.DZ_28_04_25.Commands.Interfaces;
using C__DZ.DZ_28_04_25.Model;
using NLog;

namespace C__DZ.DZ_28_04_25.Commands;

public class ChangeStatusTaskCommand(List<TaskToDo> tasks, Logger logger) : ITaskCommand
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
                    task.ChangeComplete();

                    logger.Info($"Задача {task.Title} сменила статус");
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
        catch (Exception ex)
        {
            logger.Error(ex.Message);
        }
    }
}
