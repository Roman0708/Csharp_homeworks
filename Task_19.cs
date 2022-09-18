// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine("Введите 5-тизначное число");

int num = Convert.ToInt32(Console.ReadLine());

if ( num > 9999 && num < 100000 )
{
    if ( num / 10000 == num % 10)
    {
        if ( num % 10000 / 1000 == num /10 % 10) Console.WriteLine("да");
        else
        {
            Console.WriteLine("нет");
        }
    }
    else
    {
        Console.WriteLine("нет");
    }
}
else 
{
    Console.WriteLine("Это не 5-тизначное число");
}
//Console.WriteLine( num / 10000);
//Console.WriteLine( num % 10000);
//Console.WriteLine( num % 10000 / 1000);
//Console.WriteLine( num /10 % 10);