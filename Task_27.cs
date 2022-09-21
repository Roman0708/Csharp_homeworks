// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 0) num = num * -1; //Чтобы сумма чисел была корректной

//for (int i = num % 10; num / 10 > 0 ; num = num / 10) 
//{
//    i = i + (num % 10);
//    Console.WriteLine(i);
//}

int res = num % 10;
while (num / 10 > 0) 
{
    num = num / 10;
    res = res + (num % 10);
}
Console.WriteLine(res);