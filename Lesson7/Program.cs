/*// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

void CreatRundom2Array(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(-99, 99) / 10.0;
    }
}
void show2Array(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
Console.Write("Введите число рядов: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число колонок: ");
int colums = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[rows, colums];
CreatRundom2Array(array);
show2Array(array);
*/
/*//Задача 50. Напишите программу, которая на вход принимает позиции элемента
//в двумерном массиве, и возвращает значение этого элемента или же указание,
//что такого элемента нет.

void Random2Array(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 10);
        }
    }
}
void Show2Array(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Введите индекс строки: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс столбца: ");
int colums = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[5, 5];
if (rows < array.GetLength(0) && colums < array.GetLength(1)) 
    Console.WriteLine(array[rows, colums]);
else Console.WriteLine($"Ряд {rows}, столбец {colums} -> такого числа в массиве нет");
Random2Array(array);
Show2Array(array);
*/
/*//Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
Console.WriteLine("введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов: ");
int colums = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[rows, colums];
CreatRandom2Array (numbers);

for (int j = 0; j < numbers.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        avarage = (avarage + numbers[i, j]);
    }
    avarage = avarage / rows;
    Console.Write(avarage + "; ");
}
Console.WriteLine();
ShowArray(numbers);
void CreatRandom2Array(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void ShowArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}
*/