namespace C__DZ.DZ_23_04_25.Task4;

public class MyFileManager
{
    private void Write()
    {
        Console.WriteLine("Введите путь и имя файла для записи:");
        string path = Console.ReadLine();

        using var fileStream = new FileStream(path, FileMode.Append, FileAccess.Write);
        using var streamWriter = new StreamWriter(fileStream);

        Console.WriteLine("Введите текст:");
        string text = Console.ReadLine();

        streamWriter.WriteLine(text);

        EndMessage("обновлён", path);
    }

    private void Read()
    {
        Console.WriteLine("Введите путь и имя файла для чтения:");
        string path = Console.ReadLine();

        using var fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
        using var streamReader = new StreamReader(fileStream);
        string line;

        Console.WriteLine();
        while ((line = streamReader.ReadLine()) != null)
        {
            Console.WriteLine(line);
        }

        EndMessage("прочитан", path);
    }

    private void Delete()
    {
        Console.WriteLine("Введите путь и имя файла для удаления:");

        string path = Console.ReadLine();

        File.Delete(path);

        EndMessage("удалён", path);
    }

    private void EndMessage(string action, string path)
    {
        var fileName = Path.GetFileName(path);

        Console.WriteLine();
        Console.WriteLine("--------------------------------------------------------------");
        Console.WriteLine($"Файл {fileName} {action}\n");
        Console.WriteLine(">>>>Нажмите любую клавишу для продолжения<<<<");
        Console.ReadKey(true);
    }

    public void Start()
    {
        while (true)
        {
            try
            {
                Console.Clear();
                Console.WriteLine("\t\tМеню");
                Console.WriteLine("\t1. Записать текст в файл");
                Console.WriteLine("\t2. Прочитать текст из файла");
                Console.WriteLine("\t3. Удалить файл");
                Console.WriteLine("\t4. Выйти из программы\n");

                var choice = Console.ReadKey(true);

                if (choice.KeyChar == '1')
                {
                    Console.Clear();
                    Write();
                }
                else if (choice.KeyChar == '2')
                {
                    Console.Clear();
                    Read();
                }
                else if (choice.KeyChar == '3')
                {
                    Console.Clear();
                    Delete();
                }
                else if (choice.KeyChar == '4')
                {
                    break;
                }
            }
            catch (IOException ex)
            {
                Console.Clear();
                Console.WriteLine($"{ex.Message}");
                Console.WriteLine();
                Console.WriteLine(">>>>Нажмите любую клавишу для продолжения<<<<");
                Console.ReadKey(true);
            }
        }
    }
}