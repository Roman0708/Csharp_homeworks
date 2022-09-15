//Напишите программу, которая выводит третью цифру слева заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//3267912 -> 6

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int i = 0;
if (num / 100 == 0) Console.WriteLine("Третьей цифры нет");
else
{
    while (num / 100 > 0)
    {
        i = num % 10;
        num = num / 10;
    }
    Console.WriteLine(i);
}