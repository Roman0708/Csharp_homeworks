//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Введите трёхзначное число");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 100 || num > 999)
{
    Console.WriteLine("Это не трёхзначное число"); //Не уверен нужно ли это  и можно ли так
}
else
{
    int FirstAndSecondFigure = num/10;
    int SecondFigure = FirstAndSecondFigure%10;
    Console.WriteLine(SecondFigure);
}