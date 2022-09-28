// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

string [] HelpArray = {"b1","k1","b2","k2"};
double [] array = new double [HelpArray.Length]; //при задании типа данных int вместо double получается совсем другой ответ, долго ломал голову

for (int a = 0; a < HelpArray.Length; a++)
{
    Console.WriteLine($"Введите {HelpArray[a]}");
    array[a] = Convert.ToInt32(Console.ReadLine());
}

if (array[1] == array[3])
{
    if (array[0] == array[2]) Console.WriteLine("Графики совпадают");
    else Console.WriteLine("Нет точек пересечения");
}
else
{
    double x = (array [2] - array [0]) / (array[1] - array[3]);
    double y = array [1] * x + array[0];
    
    Console.WriteLine($"({x};{y})");
}


/* 
k1 * x + b1 = k2 * x + b2
k1 * x - k2 * x = b2 - b1
x * (k1 - k2) = b2 - b1
x = (b2 - b1) / (k1 - k2)
*/

/* 
k1 * x + b1 = k2 * x + b2
b1 - b2 = k2 * x - k1 * x
b1 - b2 = x * (k2 - k1)
(b1 - b2) / (k2 - k1) = x
*/