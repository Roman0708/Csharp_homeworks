//Введение чисел по очереди использовано чтобы предотвратить присваивание чисел в одну переменную
Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число");
int c = Convert.ToInt32(Console.ReadLine());

if (a <= b)
{
    if (b <= c)
    {
        Console.WriteLine( c ); //В примере к задаче на вывод указано только число, поэтому никаких тесктовых пояснений не ставил
    }
    else
    {
        Console.WriteLine( b );
    }
}
else
{
    Console.WriteLine( a );
}