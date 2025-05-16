using C__DZ.DZ_28_04_25;
using C__DZ.DZ_28_04_25.Commands;
using C__DZ.DZ_28_04_25.Commands.Interfaces;
using C__DZ.DZ_28_04_25.Model;
using NLog;
using NLog.Config;
using NLog.Targets;

var loggingConfiguration = new LoggingConfiguration();

var fileTarget = new FileTarget
{
    FileName = "C:\\Example\\log.txt",
    Layout = @"{longdate}|${level:uppercase=true}|${message} ${exeption}"
};

loggingConfiguration.AddRule(LogLevel.Info, LogLevel.Error, fileTarget);

LogManager.Configuration = loggingConfiguration;

var logger = LogManager.GetCurrentClassLogger();

//var fileLoger = new FileLogger("C:\\Example\\log.txt");

var tasks = new List<TaskToDo>();

var commandByNumberCommand = new Dictionary<string, ITaskCommand>()
{
    {"1", new AddTaskCommand(tasks, logger)},
    {"2", new RemoveTaskCommand(tasks, logger)},
    {"3", new UpdateTaskCommand(tasks, logger)},
    {"4", new ShowTaskCommand(tasks, Console.WriteLine, logger)},
    {"5", new ChangeStatusTaskCommand(tasks, logger)}
};

string numberCommand = null;

do
{
    numberCommand = Console.ReadLine();

    if (commandByNumberCommand.TryGetValue(numberCommand, out ITaskCommand command)) //commandByNumberCommand.ContainsKey(numberCommand)
    {
        command.Execute();
    }
}
while (numberCommand != "6");