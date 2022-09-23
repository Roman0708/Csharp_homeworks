// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] array = new double[new Random().Next(2,11)]; // В задаче не описан размер массива, пускай сам решит 

for (int a = 0; a < array.Length; a++) //Заполнение массива
{
    array[a] = new Random().Next(0,100); //Присваивание каждому элементу числа
    Console.Write($"{array[a]}, "); //В задании вывода массива не требуется, просто чтобы проверить
}

Console.WriteLine(); //Перенос курсора на следующую строку

double max = array[0]; double min = array[0]; //Создание и присваивание первых max и min

for (int b = 0; b < array.Length; b++) //Поиск max и in
{
    if (max < array[b]) max = array[b]; 
    if (min > array[b]) min = array[b];
}
// Проверка max и min
Console.WriteLine(min); 
Console.WriteLine(max);

double res = max - min;

Console.WriteLine(res); //Вывод результата