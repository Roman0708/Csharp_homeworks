// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] array = new int[new Random().Next(2,11)]; // В задаче не описан размер массива, пускай сам решит 

int count = 0;

for (int a = 0; a < array.Length; a++) //Заполнение массива
{
    array[a] = new Random().Next(100,1000); //Присваивание каждому элементу массива 3-хзначного числа
    if (a % 2 != 0) count += array[a]; //Счетчик суммы чисел на нечетных позициях массива
    Console.Write($"{array[a]}, "); //В задании вывода массива не требуется, просто чтобы проверить
}
Console.WriteLine(); //Перенос курсора на следующую строку
Console.WriteLine(count); //Вывод результата