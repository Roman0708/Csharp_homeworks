// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

float [,] array = new float [m, n];

for (int a = 0; a < m; a++)
{
    for (int b = 0; b < n; b++)
    {
        array[a,b] = new Random().Next(); //ограничивать не стал, интересные числа предлагает
        Console.Write($"{array[a,b]}|");
    }
    Console.WriteLine();
}