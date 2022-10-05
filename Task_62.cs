// Напишите программу, которая заполнит спирально массив 4 на 4.

//хотел сделать программу масштабируемой в зависимости от размера массива
// Но сейчас основная задача выполнена и нужно идти дальше, возможно сделаю масштабируемой позже
// с массивом 4х4 работает

Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

void Print2DArray(int[,] array)
{
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {
            if (array[a, b] < 10) Console.Write($"0{array[a, b]} ");
            else Console.Write($"{array[a, b]} ");
        }
        Console.WriteLine();
    }
}

int[,] array = new int[m, n];

int count = 1;
for (int circle = 0; circle < 2; circle++)
{
    for (int j = 0 + circle; j < array.GetLength(1) - circle; j++) // ->
    {
        array[circle, j] = count;
        count++;
    }
    //Print2DArray(array);
    //Console.WriteLine("->");
    for (int k = 1 + circle; k < array.GetLength(0) - circle; k++) // |
    {
        array[k, array.GetLength(1) - 1 - circle] = count;
        count++;
    }
    //Print2DArray(array);
    //Console.WriteLine("|");
    for (int l = 1 + circle; l < array.GetLength(0) - circle; l++) // <-
    {
        array[array.GetLength(0) - 1 - circle, array.GetLength(1) - l - 1] = count;
        count++;
    }
    //Print2DArray(array);
    //Console.WriteLine("<-");
    for (int q = 2 + circle; q < array.GetLength(0) - circle; q++) // ^
    {
        array[array.GetLength(0) - q - circle, 0 + circle] = count;
        count++;
    }
    //Print2DArray(array);
    //Console.WriteLine("^");
}

Print2DArray(array);