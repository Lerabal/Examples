Console.Clear();
Console.Write("Введите 1 число ");
int num1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2 число ");
int num2 = int.Parse(Console.ReadLine()!);

if (num1 == num2 * num2 || num2 == num1 * num1)
{
    Console.Write("Число 1 является квадратом числа 2");
}
else
{
    Console.Write("Число 1 не является квадратом числа 2");
}

// 16. По двум  числам проверять является ли одно квадратом другого