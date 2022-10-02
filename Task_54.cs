//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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
    for (int b = 0; b < n; b++)
    {
        for (int maxFigurePosition = 0; maxFigurePosition < n - 1; maxFigurePosition++)
            if (array[a, b] > array[a, maxFigurePosition])
            {
                int help = array[a, b];
                array[a, b] = array[a, maxFigurePosition];
                array[a, maxFigurePosition] = help;
                maxFigurePosition--;
            }
    }
}

Print2DArray(array);