using C__DZ.DZ_23_04_25.Task1;
using C__DZ.DZ_23_04_25.Task2;
using C__DZ.DZ_23_04_25.Task3;
using C__DZ.DZ_23_04_25.Task4;


//// Задача 1 -------------------------------------------------------

// 1
string path1 = "C:\\Example";
string path2 = "C:\\Example\\Subfolder1";
string path3 = "C:\\Example\\Subfolder2";

MyDirectory.Create(path1);
MyDirectory.Create(path2);
MyDirectory.Create(path3);

//// Задача 2 -------------------------------------------------------

// 1
string hello = "Hello, World!";
var fileName = "\\hello.txt";
var pathToHello = path2 + fileName;

MyFile.WriteText(pathToHello, hello);
MyFile.Append(pathToHello, "Bye-bye!");

// 2
MyFile.ReadText(pathToHello);
Console.WriteLine();

var strings = new List<string>()
{
    "Hello",
    "World!"
};

MyFile.WriteLines(pathToHello, strings);
MyFile.ReadLines(pathToHello);
Console.WriteLine();

// 3
MyFile.Copy(pathToHello, path3 + fileName);

MyFile.Move(pathToHello, path3 + fileName);

//// Задача 3 -------------------------------------------------------

var pathToTst = $"{path2}\\tst.txt";

MyFileStream.StreamWriterOpenOrCreate(pathToTst, hello);

MyFileStream.StreamWriterAppend(pathToTst, "Bom");

MyFileStream.StreamReader(pathToTst);
Console.WriteLine();

//// Задача 4 -------------------------------------------------------


Console.WriteLine(">>>>Нажмите любую клавишу для продолжения<<<<");
Console.ReadKey(true);

var fileManager = new MyFileManager();
fileManager.Start();

//MyDirectory.Delete(path1);