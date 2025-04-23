
namespace C__DZ.DZ_14_04_25;

public static class ListExtensions
{
    public static List<int> ModifyList(this List<int> list, Func<int, int> func)
    {
        List<int> currentList = [];

        foreach (var item in list)
        {
            currentList.Add(func(item));
        }

        return currentList;
    }
}
