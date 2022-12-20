Console.Clear();
Console.Write("Введите 1 число ");
int num = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2 число ");
int num1 = int.Parse(Console.ReadLine()!);
if (num%num1 == 0)
{
    Console.Write("Число 1 кратно число 2");
}
else
{
    int ost = num%num1;
    Console.Write($"Остаток от деления {ost}");
}