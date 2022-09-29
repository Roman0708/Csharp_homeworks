//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int m = new Random().Next(2, 11); 
int n = new Random().Next(2, 11); 

//проверял маленькими массивами

//Console.WriteLine("Введите количество строк");
//int m = Convert.ToInt32(Console.ReadLine());
//
//Console.WriteLine("Введите количество столбцов");
//int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];

for (int a = 0; a < m; a++)
{
    for (int b = 0; b < n; b++)
    {
        array[a, b] = new Random().Next(0, 10);
        Console.Write($"{array[a, b]} ");
    }
    Console.WriteLine();
}
 
 Console.Write("Среднее арифметическое каждого столбца: ");
 for (int j = 0; j < n; j++)
 {
    double columnAvg = 0;
     for (int i = 0; i < m; i++)
    {
        columnAvg = columnAvg + array [i,j];
    }
    Console.Write($"{columnAvg / m}; ");
 }