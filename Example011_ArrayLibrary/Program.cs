void FillArray (int[] collection) // метод fillarray  int[] collection аргумент 
{
    int lenght = collection.Length; // получить длину массива
    int index = 0; //
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10); //обращаемся к аргументу на позицию индекс и положить новое случайное число из диапазона 1-10
        index++;
    }
}

void printArray (int[] col) //int[] col - аргумент функции, метод который будет печатать массив printArray
{
     int count = col.Length; // количество элементов
     int position = 0; //текущая позиция
     while (position < count)
     {
        Console.Write(col[position]);//Выводить на консоль значение текущего элемента
        position++;
     }
}

int IndexOf (int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
         {
            position = index;
            break;
         }
        index++;
    }
    return position;
}
int[] array = new int[10]; // по умолчанию в массиве 10 элементов.Создай новый массив с 10 элементами, по умолчанию он заполнен нулями
FillArray (array);
printArray (array);

Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine (pos);