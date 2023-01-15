void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;     // если задано значение для поиска вне значений массива, то -1 будет указывать, что элемент не найден.
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;       // после нахождения первого совпадения - выход.
        }
        index++;    
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();  //вывод пустой строки

int pos = IndexOf(array, 444);
Console.WriteLine(pos);