using C__DZ.DZ_14_04_25;


var list = new List<int>() { 1, 2, 3, 4, 5 };

Console.WriteLine("Пример использования ModifyList");

Console.WriteLine("Было:");
foreach (var item in list)
{
    Console.Write($"{item} ");
}
Console.WriteLine();

var modifyList = list.ModifyList(x => x * 2);

Console.WriteLine("Стало:");
foreach (var item in modifyList)
{
    Console.Write($"{item} ");
}
Console.WriteLine();


Console.WriteLine("\nПример использования делегата Operation");

Operation operationAdd = MyOperations.Add;
Operation operationSubtract = MyOperations.Subtract;
Operation operationMultiply = MyOperations.Multiply;

Console.WriteLine($"operationAdd = {operationAdd.Invoke(4, 5)}");
Console.WriteLine($"operationSubtract = {operationSubtract.Invoke(4, 5)}");
Console.WriteLine($"operationMultiply = {operationMultiply.Invoke(4, 5)}");

public delegate int Operation(int x, int y);