﻿// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int[] array = new int[8];

//Console.WriteLine("Введите 8 чисел массива, каждое число отедляя нажатием клавиши Enter");
//Раскомментировать, если массив должен задаваться вручную
for (int i = 0; i < 8; i++) 
{
    array[i] = new Random().Next(0,100);// не совсем понял как должен заполнятся массив, поэтому решил заполнять рандомно
    //Закомментировать, если массив должен задаваться вручную
    Console.Write($"{array[i]}, ");
}
