//11. Удалить вторую цифру трёхзначного числа

Console.Clear();

int GetNumberFromRange(int start, int end)
{
int number = new Random().Next(start,end + 1);
return number;
}

int DeleteSecondDigit(int number)
{
    int digit3 = number % 10;
    int digit1 = number / 100;
    int result = digit1 * 10 + digit3;
    return result;
}

int randomNumber = GetNumberFromRange(100,999);
int numberWithoutSec =  DeleteSecondDigit(randomNumber);
Console.WriteLine($"Если из числа {randomNumber} удалить вторую цифру, получится число {numberWithoutSec}");

