/*14. Принимает на вход число и проверяет кратно ли оно 7 и 23 одновременно

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
*/

void numbers (int firstNumber)
{
    int result = firstNumber % 7;
    int result2  = firstNumber % 23;
    if (result == 0 & result2 == 0)
    {
        Console.Write("Кратно");
    }
    else
    {
        Console.Write("Нет");
    }
}

int firstNumber = int.Parse(Console.ReadLine()!);
numbers(firstNumber);
