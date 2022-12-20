Console.Clear();
Console.Write("Введите пятизначное число:   ");
string number = Console.ReadLine()!;
int length = number.Length;
string txtToCheck = number.Replace(" ","");  // для проверки текста на палиндром

bool Palindrome()
{
    for (int i = 0; i < length / 2; i++)
        while (number[i] == number[length - 1])
        {
            return true;
        }
    return false;
}

if (Palindrome()) Console.WriteLine($"{number} - является палиндромом");
else Console.WriteLine($"{number} не является палиндромом");


