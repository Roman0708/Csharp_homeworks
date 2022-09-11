Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());

int count = 2; // В задании сказано что нужно выводить все числа начиная с 1 - поэтому 0 и отрицательные числа в расчет не взял, надеюсь правильно
while ( count <= a )
{
    Console.Write(count + ", ");
    count = count + 2;
}