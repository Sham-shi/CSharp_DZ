using C__DZ.DZ_18_04_25.Task1;
using C__DZ.DZ_18_04_25.Task2;
using C__DZ.DZ_18_04_25.Task3;
using C__DZ.DZ_18_04_25.Task4;
using C__DZ.DZ_18_04_25.Task5;


////// Задача 1 -------------------------------------------------------

var students = new List<C__DZ.DZ_18_04_25.Task1.Student>
{
     new C__DZ.DZ_18_04_25.Task1.Student { Name = "Alice", Score = 90 },
     new C__DZ.DZ_18_04_25.Task1.Student { Name = "Bob", Score = 80 },
     new C__DZ.DZ_18_04_25.Task1.Student { Name = "Charlie", Score = 88 },
     new C__DZ.DZ_18_04_25.Task1.Student { Name = "David", Score = 92 }
};

var sortedStudents = students.Where(student => student.Score > 85).ToList();

Console.WriteLine("Студенты с оценкой выше 85:");
foreach (var student in sortedStudents)
{
    Console.WriteLine(student);
}


////// Задача 2 -------------------------------------------------------

var books = new List<Book>
{
     new Book { Title = "1984" },
     new Book { Title = "To Kill a Mockingbird" },
     new Book { Title = "The Great Gatsby" }
};

var orderedBooks = from b in books
                    orderby b.Title
                    select b;

//var orderedBooks = books.OrderBy(b => b.Title).ToList();

Console.WriteLine("\nКниги после сортировки:");

foreach (var book in orderedBooks)
{
    Console.WriteLine($"Название: {book.Title}");
}


////// Задача 3 -------------------------------------------------------

var products = new List<Product>
{
     new Product { Name = "Apple", Category = "Fruits" },
     new Product { Name = "Carrot", Category = "Vegetables" },
     new Product { Name = "Banana", Category = "Fruits" },
     new Product { Name = "Broccoli", Category = "Vegetables" }
};

var groupedProducts = from product in products
                      group product by product.Category into c
                      select new
                      {
                          Category = c.Key,
                          Products = from p in c select p
                      };


//var groupedProducts = products
//                            .GroupBy(p => p.Category)
//                            .Select(c => new 
//                            {
//                            Category = c.Key,
//                            Products = c.Select(p => p)
//                            });

Console.WriteLine("\nПродукты по категориям:");
foreach (var category in groupedProducts)
{
    Console.WriteLine($"Категория: {category.Category}");

    foreach (var product in category.Products)
    {
        Console.WriteLine($"Продукт: {product.Name}");
    }
}


////// Задача 4 -------------------------------------------------------

var students2 = new List<C__DZ.DZ_18_04_25.Task4.Student>
{
     new C__DZ.DZ_18_04_25.Task4.Student { Id = 1, Name = "Alice" },
     new C__DZ.DZ_18_04_25.Task4.Student { Id = 2, Name = "Bob" }
};
var grades = new List<Grade>
{
     new Grade { StudentId = 1, Subject = "Math", LetterGrade = 'A' },
     new Grade { StudentId = 2, Subject = "Math", LetterGrade = 'B' },
     new Grade { StudentId = 1, Subject = "Science", LetterGrade = 'A' }
};

//var studentsProgress = students2.Join(grades,
//                                        s => s.Id,
//                                        g => g.StudentId,
//                                        (s, g) => new
//                                        {
//                                            StudentId = s.Id,
//                                            Name = s.Name,
//                                            Subject = g.Subject,
//                                            LetterGrade = g.LetterGrade
//                                        });

var studentsProgress = from s in students2
                       join g in grades on s.Id equals g.StudentId
                       select new
                       {
                           StudentId = s.Id,
                           Name = s.Name,
                           Subject = g.Subject,
                           LetterGrade = g.LetterGrade
                       };


Console.WriteLine("\nОбъединённые классы Student и Grade:");
foreach (var student in studentsProgress)
{
    Console.WriteLine($"ID: {student.StudentId}, Имя: {student.Name}");
    Console.WriteLine($"Предмет: {student.Subject}, Оценка: {student.LetterGrade}");
}


////// Задача 5 -------------------------------------------------------

var orders = new List<Order>
{
     new Order { Amount = 150.00m },
     new Order { Amount = 200.00m },
     new Order { Amount = 75.00m }
};

var ordersAmount = orders.Sum(o => o.Amount);

Console.WriteLine("\nОбщая сумма заказов:");
Console.WriteLine(ordersAmount);