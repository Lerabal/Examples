int[] array = {25,59,78,4,458,9,5,7,0};

int n = array.Length; //автоматически определяет длину массива int[] array = {25,59,78,456,458,9,5,2,0}; ВЗОВРАЩАЕТ ДЛИНУ (КОЛ-ВО ЭЛЕМЕНТОВ) МАССИВА

int find = 458;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine (index); // break; - прерви
    }
    index++;
}
