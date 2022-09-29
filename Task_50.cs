// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

int m = new Random().Next(2, 11);
int n = new Random().Next(2, 11);

//Console.WriteLine($"{m},{n}");

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

Console.WriteLine("Введите позицию в столбце");
int i = Convert.ToInt32(Console.ReadLine()); //если считать "по-человечески", то достаточно будет сделать - 1, чтобы отсчет позиций начинался с 1 а не с 0

Console.WriteLine("Введите позицию в строке");
int j = Convert.ToInt32(Console.ReadLine());

if (i >= m || j >= n) Console.WriteLine("такого числа в массиве нет");
else Console.WriteLine(array[i,j]);