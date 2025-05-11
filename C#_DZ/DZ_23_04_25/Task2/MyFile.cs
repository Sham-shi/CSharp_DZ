
namespace C__DZ.DZ_23_04_25.Task2;

public static class MyFile
{
    public static void WriteText(string path, string data)
    {
        if (!string.IsNullOrWhiteSpace(path))
        {
            File.WriteAllText(path, data);
        }
    }

    public static void WriteLines(string path, List<string> data)
    {
        if (!string.IsNullOrWhiteSpace(path))
        {
            File.WriteAllLines(path, data);
        }

    }

    public static void Append(string path, string data)
    {
        if (!string.IsNullOrWhiteSpace(path))
        { 
            File.AppendAllText(path, data); 
        }
    }

    public static void ReadText(string path)
    {
        if (!string.IsNullOrWhiteSpace(path))
        {
            Console.WriteLine($"{File.ReadAllText(path)}");
        }
    }

    public static void ReadLines(string path)
    {
        if (!string.IsNullOrWhiteSpace(path))
        {
            var lines = File.ReadAllLines(path);

            for (int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {lines[i]}");
            }
        }
    }

    public static void Copy(string path, string newPath)
    {
        if (!string.IsNullOrWhiteSpace(path) && !string.IsNullOrWhiteSpace(newPath))
        {
            File.Copy(path, newPath, true);
        }
    }

    public static void Move(string path, string newPath)
    {
        if (!string.IsNullOrWhiteSpace(path) && !string.IsNullOrWhiteSpace(newPath))
        {
            File.Move(path, newPath, true);
        }
    }
}
