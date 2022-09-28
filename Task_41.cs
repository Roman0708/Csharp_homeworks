/*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

Console.WriteLine("Введите размер массива");
int i = Convert.ToInt32(Console.ReadLine());

int [] array = new int [i];

int count = 0;
for (int a = 0; a < array.Length; a++)
{
    Console.WriteLine($"Введите {a}-й элемент массива");
    array[a] = Convert.ToInt32(Console.ReadLine());
    if (array[a] > 0) count++;
}

//for (int a = 0; a < array.Length; a++) Console.Write ($"{array[a]} ");

Console.WriteLine();
Console.WriteLine(count);