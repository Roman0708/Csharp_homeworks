// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2

Console.WriteLine("Введите размер первой ячейки массива");
int i = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите размер второй ячейки массива");
int j = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите размер третьей ячейки массива");
int l = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int[,] arraySetNumbers = new int[2, i * j * l]; /*Двумерный массив здесь на самом деле не нужен, 
но у меня был метод для печати двумерного массива чтобы просто проверить как я задал этот самый массив, и мне было лень писать новый :)*/

for (int a = 0; a < i * j * l; a++) //Создаем массив из уникальных чисел
{
    int number = new Random().Next(10, 100);
    int count = 0;

    while (count < i * j * l)
    {
        if (number == arraySetNumbers[0, count]) break;
        else count++;
    }

    if (count == i * j * l)
    {
        arraySetNumbers[0, a] = number;
    }
}

/*void Print2DArray(int[,] array) //Это проверка работоспособности метода для создания массива уникальных чисел
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

Print2DArray(arraySetNumbers);

Console.WriteLine();*/

int[,,] CreateRandom3DArray(int m, int n, int k)
{
    int counter = 0;
    int[,,] array = new int[m, n, k];
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {
            for (int c = 0; c < array.GetLength(2); c++)
            {
                //int hashSet = new HashSet<int>();

                array[a, b, c] = arraySetNumbers[0, counter];
                counter++;
            }
        }
    }
    return array;
}

int [,,] resultArray = CreateRandom3DArray(2, 2, 2);

void Print3DArray(int[,,] array)
{
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {
            for (int c = 0; c < array.GetLength(2); c++)
            {
                //int hashSet = new HashSet<int>();

                Console.Write($"{array[a, b, c]} ({a},{b},{c})");
            }
            Console.WriteLine();
        }

    }
}

Print3DArray(resultArray);