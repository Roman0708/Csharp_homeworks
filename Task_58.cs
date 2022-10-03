// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

//Хотел придумать метод, принимаюзий на вход комментарий и имя, которое будет дано переменной с длиной массива, но что-то как-то неполучилось :(

Console.WriteLine("Введите количество строк первой матрицы");
int m1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов первой матрицы");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

Console.WriteLine("Введите количество строк второй матрицы");
int m2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов второй матрицы");
int n2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int[,] CreateRandom2DArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {
            array[a, b] = new Random().Next(0, 10);
        }
    }
    return array;
}

int[,] matrix1 = CreateRandom2DArray(m1, n1);

int[,] matrix2 = CreateRandom2DArray(m2, n2);

void Print2DArray(int[,] array)
{
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {
            Console.Write($"{array[a, b]} ");
        }
        Console.WriteLine();
    }
}

Print2DArray(matrix1);

Console.WriteLine();

Print2DArray(matrix2);

Console.WriteLine();

int [,] resultMatrix = new int [matrix1.GetLength(0),matrix2.GetLength(1)];
if (matrix1.GetLength(1) == matrix2.GetLength(0))
{
    for (int a = 0; a < resultMatrix.GetLength(0); a++)
    {
        for (int b = 0; b < resultMatrix.GetLength(1); b++)
        {
            for (int i = 0; i < matrix1.GetLength(1); i++)
            {
                resultMatrix[a,b] = resultMatrix[a,b] + matrix1[a,i] * matrix2[i,b];
            }
            Console.Write($"{resultMatrix[a, b]} ");
        }
        Console.WriteLine();
    }
}
else Console.WriteLine("Произведение матриц невозможно");