
namespace C__DZ.DZ_02_04_25;

//Напишите программу, которая заполняет двумерный массив размером n x m числами от
//1 до n * m спиралью. Это означает, что заполнение должно идти по периметру матрицы, начиная с
//верхнего левого угла и двигаясь по часовой стрелке.


public class SpiralSnake
{
    private int rows;
    private int columns;
    private int[,] mass;

    public SpiralSnake(int row, int col)
    {
        rows = row;
        columns = col;
        mass = new int[row, col];
    }

    public void FillArray()
    {
        // счётчик чисел для заполнения массива
        int counter = 1;

        // индексы для прохождения по столбцам и строкам
        int i = 0; // строки
        int j = 0; // столбцы

        // количество прохождений по циклу (количество витков спирали)
        int spiralTurns = 0;

        while (counter < (columns * rows + 1)) // пока счётчик не достигнет своего максимума + 1
        {
            // спираль движется вправо
            while (j < (columns - spiralTurns))
            {
                mass[i, j++] = counter++;
            }
            j--; // возвращаем столбец на позицию, где последний раз был установлен счётчик в массиве
            i++; // идём вниз на следующую строку

            // спираль движется вниз
            while (i < (rows - spiralTurns))
            {
                mass[i++, j] = counter++;
            }
            i--; // возвращаем строку на позицию, где последний раз был установлен счётчик в массиве
            j--; // идём влево на следующий столбец

            // спираль движется влево
            while (j >= spiralTurns) // зависит от количества витков спирали
            {
                mass[i, j--] = counter++;
            }
            j++; // возвращаем столбец на позицию, где последний раз был установлен счётчик в массиве
            i--; // идём вверх на следующую строку

            // спираль движется вверх
            while (mass[i, j] == 0)
            {
                mass[i--, j] = counter++;
            }
            i++; // возвращаем строку на позицию, где последний раз был установлен счётчик в массиве
            j++; // идём вправо на следующий столбец

            // увеличили количество прохождений по циклу (витков в спирали)
            spiralTurns++;
        }
    }

    public void PrintArray()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{mass[i, j]}\t");
            }
            Console.WriteLine();
        }
    }

    // метод для вывода массива на консоль по спирали с задержкой и изменением цвета
    public void DelayedPrint()
    {
        int counter = 1;

        // переменные для установки курсора в конслои
        int x = 0;
        int y = 0;
        int tab = 5; // вместо табулятора

        int i = 0;
        int j = 0;

        int spiralTurns = 0;

        while (counter < (columns * rows + 1))
        {
            // спираль движется вправо
            while (j < (columns - spiralTurns))
            {
                // устанавливаем необходимые координаты курсора
                x = j * tab; // проходим по строкам
                Console.SetCursorPosition(x, y);

                Thread.Sleep(100); // для задержки вывода на консоль
                Console.WriteLine($"{mass[i, j++]}");

                counter++;
            }
            j--;
            i++;

            // спираль движется вниз
            while (i < (rows - spiralTurns))
            {
                y++; // проходим по столбцам
                Console.SetCursorPosition(x, y);

                Thread.Sleep(100);
                Console.WriteLine($"{mass[i++, j]}");

                counter++;
            }
            i--; // возвращаем строку на позицию, где последний раз был установлен счётчик в массиве
            j--; // идём влево на следующий столбец

            // спираль движется влево
            while (j >= spiralTurns) // зависит от количества витков спирали
            {
                x = j * tab;
                Console.SetCursorPosition(x, y);

                Thread.Sleep(100);
                Console.WriteLine($"{mass[i, j--]}");

                counter++;
            }
            j++; // возвращаем столбец на позицию, где последний раз был установлен счётчик в массиве
            i--; // идём вверх на следующую строку

            // спираль движется вверх
            while (i >= (spiralTurns + 1))
            {
                // для изменения цвета каждого витка спирали
                if ( i == (spiralTurns + 1) )
                {
                    Console.ForegroundColor = (ConsoleColor)(spiralTurns + 1);

                    // если цвет текста равен цвету фона, меняем
                    if (Console.ForegroundColor == Console.BackgroundColor)
                        Console.ForegroundColor = ConsoleColor.White;
                }

                y--;
                Console.SetCursorPosition(x, y);

                Thread.Sleep(100);
                Console.WriteLine($"{mass[i--, j]}");

                counter++;
            }
            i++; // возвращаем строку на позицию, где последний раз был установлен счётчик в массиве
            j++; // идём вправо на следующий столбец

            // увеличили количество прохождений по циклу (витков в спирали)
            spiralTurns++;
        }

        Console.SetCursorPosition(x, columns);
        Console.ResetColor(); // возвращаем цвет текста в консоли на настройки по умолчанию

        Console.ReadLine();
    }
}
