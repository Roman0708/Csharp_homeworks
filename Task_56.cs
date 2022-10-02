//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int[,] CreateRandom2DArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int a = 0; a < m; a++)
    {
        for (int b = 0; b < n; b++)
        {
            array[a, b] = new Random().Next(0, 10);
        }
    }
    return array;
}

int[,] array = CreateRandom2DArray(m, n);

void Print2DArray(int[,] array)
{
    for (int a = 0; a < m; a++)
    {
        for (int b = 0; b < n; b++)
        {
            Console.Write($"{array[a, b]} ");
        }
        Console.WriteLine();
    }

}

Print2DArray(array);

Console.WriteLine();

for (int a = 0; a < m; a++)
{
    for (int b = 0; b < n - 1; b++)
    {
        array[a, b + 1] = array[a, b] + array[a, b + 1];
    }
}

Print2DArray(array);

int minSumForRow = array[0, n - 1];
int count = 0;

for (int a = 0; a < m; a++)
{
    if (minSumForRow > array[a, n - 1])
    {
        minSumForRow = array[a, n - 1];
        count = a;
        Console.WriteLine(count);
    }
}

Console.WriteLine($"{count+1} строка");