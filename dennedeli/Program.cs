// Дни недели3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.

Console.Clear();

Console.WriteLine ("Введите номер дня недели:" );
int userday = int.Parse(Console.ReadLine ()!);

if (userday==1)
{
    Console.Write("Понедельник ");
}
else if (userday==2)
{
    Console.Write("Вторник ");
}
else if (userday==3)
{
    Console.Write("Среда ");
}
else if (userday==4)
{
    Console.Write("Четверг ");
}
else if (userday==5)
{
    Console.Write("Пятница ");
}
else if (userday==6)
{
    Console.Write("Суббота ");
}
else if (userday==7)
{
    Console.Write("Воскресенье ");
}
else 
{
    Console.WriteLine ("Введите число от 1 до 7" );
    }