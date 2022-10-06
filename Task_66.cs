// SЗадача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

if (m < n)
    {
        int help = m;
        m = n;
        n = help;
    }

int sum = n;

void RecursionSum (int m, int n)
{
    if (n < m)
    {
        n = n + 1;
        sum = sum + n;
        
        RecursionSum(m,n);
    }
}

RecursionSum(m,n);

Console.Write(sum);
