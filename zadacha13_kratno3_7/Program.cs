/*14. Принимает на вход число и проверяет кратно ли оно 7 и 23 одновременно*/

Console.Clear();
Console.Write ("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int a = 7;
int b = 3;

if (number % a ==0 && number % b == 0)
{
    Console.WriteLine("Кратно обоим числам");
}
else
{
    Console.WriteLine("Число не кратно обоим числам");
}