
namespace C__DZ.DZ_23_04_25.Task1;

public static class MyDirectory
{
    public static void Create(string path)
    {
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }
    }

    public static void Delete(string path)
    {
        Directory.Delete(path, true);
    }
}
