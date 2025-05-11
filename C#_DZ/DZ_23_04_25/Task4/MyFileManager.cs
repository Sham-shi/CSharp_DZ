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

//using C__DZ.DZ_23_04_25.Task1;
//using C__DZ.DZ_23_04_25.Task2;
//using C__DZ.DZ_23_04_25.Task3;
//using C__DZ.DZ_23_04_25.Task4;


////// Задача 1 -------------------------------------------------------

//// 1
//string path1 = "C:\\Example";
//string path2 = "C:\\Example\\Subfolder1";
//string path3 = "C:\\Example\\Subfolder2";

//MyDirectory.Create(path1);
//MyDirectory.Create(path2);
//MyDirectory.Create(path3);

////// Задача 2 -------------------------------------------------------

//// 1
//string hello = "Hello, World!";
//var fileName = "\\hello.txt";
//var pathToHello = path2 + fileName;

//MyFile.WriteText(pathToHello, hello);
//MyFile.Append(pathToHello, "Bye-bye!");

//// 2
//MyFile.ReadText(pathToHello);
//Console.WriteLine();

//var strings = new List<string>()
//{
//    "Hello",
//    "World!"
//};

//MyFile.WriteLines(pathToHello, strings);
//MyFile.ReadLines(pathToHello);
//Console.WriteLine();

//// 3
//MyFile.Copy(pathToHello, path3 + fileName);

//MyFile.Move(pathToHello, path3 + fileName);

////// Задача 3 -------------------------------------------------------

//var pathToTst = $"{path2}\\tst.txt";

//MyFileStream.StreamWriterOpenOrCreate(pathToTst, hello);

//MyFileStream.StreamWriterAppend(pathToTst, "Bom");

//MyFileStream.StreamReader(pathToTst);
//Console.WriteLine();

////// Задача 4 -------------------------------------------------------


//Console.WriteLine(">>>>Нажмите любую клавишу для продолжения<<<<");
//Console.ReadKey(true);

//var fileManager = new MyFileManager();
//fileManager.Start();

////MyDirectory.Delete(path1);