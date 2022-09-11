Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());

if ( a % 2 == 0)
{
    Console.WriteLine("Да"); // Сомневался по поводу чётности нуля - https://ru.wikipedia.org/wiki/%D0%A7%D1%91%D1%82%D0%BD%D0%BE%D1%81%D1%82%D1%8C_%D0%BD%D1%83%D0%BB%D1%8F#:~:text=%D0%9D%D0%BE%D0%BB%D1%8C%20%D0%B4%D0%B5%D0%BB%D0%B8%D1%82%D1%81%D1%8F%20%D0%BD%D0%B5%20%D1%82%D0%BE%D0%BB%D1%8C%D0%BA%D0%BE%20%D0%BD%D0%B0,%D1%87%D1%91%D1%82%D0%BD%D1%8B%D0%BC%C2%BB%20%D1%87%D0%B8%D1%81%D0%BB%D0%BE%D0%BC%20%D0%B8%D0%B7%20%D0%B2%D1%81%D0%B5%D1%85%20%D1%87%D0%B8%D1%81%D0%B5%D0%BB.
}
else
{
    Console.WriteLine("Нет");
}