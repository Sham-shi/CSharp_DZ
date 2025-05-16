using C__DZ.DZ_29_04_25;
using System.Net.Http.Headers;

var myStack1 = new MyStack<int>();

myStack1.Push(1);
myStack1.Push(3);
myStack1.Push(2);
myStack1.Push(3);

foreach (var item in myStack1)
{
    Console.WriteLine(item);
}
Console.WriteLine();

Console.WriteLine(myStack1.Peek());
Console.WriteLine();

Console.WriteLine(myStack1.Pop());
Console.WriteLine();

Console.WriteLine(myStack1.Pop());
Console.WriteLine();

foreach (var item in myStack1)
{
    Console.WriteLine(item);
}
Console.WriteLine();