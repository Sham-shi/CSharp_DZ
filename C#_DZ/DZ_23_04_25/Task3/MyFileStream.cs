
namespace C__DZ.DZ_23_04_25.Task3;

public static class MyFileStream
{
    public static void StreamWriterOpenOrCreate(string path, string data)
    {
        using var fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
        using var streamWriter = new StreamWriter(fileStream);

        streamWriter.WriteLine(data);
    }

    public static void StreamWriterAppend(string path, string data)
    {
        using var fileStream = new FileStream(path, FileMode.Append, FileAccess.Write);
        using var streamWriter = new StreamWriter(fileStream);

        streamWriter.WriteLine(data);
    }

    public static void StreamReader(string path)
    {
        using var fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
        using var streamReader = new StreamReader(fileStream);

        string line;

        while ((line = streamReader.ReadLine()) != null)
        {
            Console.WriteLine(line);
        }
    }
}
