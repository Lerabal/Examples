﻿//Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
//4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
//2 -> " -2, -1, 0, 1, 2"

Console.Clear();
Console.Write ("Введите число: ");
int number1 = int.Parse(Console.ReadLine()!);
int number2 = -number1;

while (number2 <= number1)
{
   Console.Write(number2+ " ");
   number2++;
}

/*Console.Clear();
Console.Write ("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
int n2 = 1;

while (n2 <= n)
{
   int cub=n2*n2*n2;
   Console.Write(cub + " ");
   n2++;
}
Console.WriteLine();*/