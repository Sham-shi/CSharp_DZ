using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using C__DZ.DZ_25_04_25.Task1;
using C__DZ.DZ_25_04_25.Task3;

var jsonSerializerOptions = new JsonSerializerOptions
{
    Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
    WriteIndented = true
};


//// Задача 1 -------------------------------------------------------------------------------------

var student = new Student()
{
    Name = "Пётр",
    Age = 23,
    Grades = [4, 4, 3, 5, 3]
};

var jsonStudent = JsonSerializer.Serialize(student, jsonSerializerOptions);

Console.WriteLine("Сериализация студента в формате json:");
Console.WriteLine(jsonStudent);
Console.WriteLine();

//// Задача 2 -------------------------------------------------------------------------------------

student = JsonSerializer.Deserialize<Student>(jsonStudent);

Console.WriteLine("Студент после десериализации:");
Console.WriteLine(student);
Console.WriteLine();

//// Задача 3 -------------------------------------------------------------------------------------

var book = new Book()
{
    Title = "Война и мир",
    Author = "Лев Толстой",
    PublishedDate = new DateTime(1869, 12, 31)
};

var jsonBook = JsonSerializer.Serialize(book, jsonSerializerOptions);

Console.WriteLine("Сериализация книги в формате json с именами свойств в формате camelCase:");
Console.WriteLine(jsonBook);
Console.WriteLine();

//// Задача 4 -------------------------------------------------------------------------------------

var books = new List<Book>()
{
    book,
    new()
    {
        Title = "Преступление и наказание",
        Author = "Фёдор Достоевский",
        PublishedDate = new DateTime(1866, 1, 1)
    },
    new()
    {
        Title = "Мастер и Маргарита",
        Author = "Михаил Булгаков",
        PublishedDate = new DateTime(1966, 11, 1)
    },
    new()
    {
        Title = "1984",
        Author = "Джордж Оруэлл",
        PublishedDate = new DateTime(1949, 6, 8)
    },
    new()
    {
        Title = "Гарри Поттер и философский камень",
        Author = "Джоан Роулинг",
        PublishedDate = new DateTime(1997, 6, 26)
    }
};

var jsonBooks = JsonSerializer.Serialize(books, jsonSerializerOptions);

books = JsonSerializer.Deserialize<List<Book>>(jsonBooks);

Console.WriteLine("Коллекция книг после десериализации:");
foreach (var itemBook in books)
{
    Console.WriteLine(itemBook);
}
Console.WriteLine();

//// Задача 5 -------------------------------------------------------------------------------------

File.WriteAllText("C:\\Test\\data.json", jsonBooks);

var jsonFromFile = File.ReadAllText("C:\\Test\\data.json");

var booksFromFile = JsonSerializer.Deserialize<List<Book>>(jsonFromFile);

Console.WriteLine("Коллекция книг после чтения из файла и десериализации:");
foreach (var itemBook in booksFromFile)
{
    Console.WriteLine(itemBook);
}
Console.WriteLine();
