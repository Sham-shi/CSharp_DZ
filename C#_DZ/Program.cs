using C__DZ.DZ_30_04_25;


var myLinkedList = new MyLinkedList<string>();

Console.WriteLine($"{myLinkedList.Contains("Катя")}");
Console.WriteLine();

myLinkedList.Add("Вася");
myLinkedList.Add("Петя");
myLinkedList.Add("Оля");
myLinkedList.Add("Маша");
myLinkedList.Add("Катя");

Console.WriteLine($"{myLinkedList.Count}");
foreach (var item in myLinkedList)
{
    Console.WriteLine(item);
}
Console.WriteLine();

Console.WriteLine($"{myLinkedList.Contains("Катя")}");
Console.WriteLine();

Console.WriteLine($"{myLinkedList.Contains("Саша")}");
Console.WriteLine();

myLinkedList.Remove("Вася");
myLinkedList.Remove("Оля");
myLinkedList.Remove("Катя");

Console.WriteLine($"{myLinkedList.Count}");
foreach (var item in myLinkedList)
{
    Console.WriteLine(item);
}
Console.WriteLine();