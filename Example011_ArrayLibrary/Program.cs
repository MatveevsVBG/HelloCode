Console.Write("Введите диапазон значений: ");
int range = Convert.ToInt32(Console.ReadLine());

void FillArray(int[] collection)     // Объявление функции; collection - имя массива в функции
{
    int length = collection.Length;  // Присваеваем размер массива переменной length
    int index = 0;                    // Начальный индекс
    while (index < length)          // Пока текущий индекс значения массива меньше длины массива
    {
        collection[index] = new Random().Next(1, range);  // Присваивание значения от 1 до 9 с текущим индексом 
        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;      // Присваеваем размер массива переменной count 
    int position = 0;         // Начальный индекс
    while (position < count)     // Пока текущий индекс значения массива меньше длины массива
    {
        Console.Write($"{col[position]} ");    //  Вывод в консоль значения с текущим индексом
        position++;
    }
}
int IndexOf(int[] collection, int find)   // Объявление функции, возвращающей значение; 2 аргумента: массив и переменная find
{
    int count = collection.Length;        // Присваеваем размер массива переменной count
    int index = 0;
    int position = -1;     // если задано значение для поиска вне значений массива, то -1 будет указывать, что элемент не найден.
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;     //  Если значение найдено, то сохраняем индекс значения в переменную position
            break;              // после нахождения первого совпадения - выход.
        }
        index++;
    }
    return position;
}
Console.Write("Введите размер массива: ");
int len = Convert.ToInt32(Console.ReadLine());
int[] array = new int[len];    // Задаём размер массива

Console.Write("Введите искомое число: ");
int nums = Convert.ToInt32(Console.ReadLine());

FillArray(array);            // Заполняем массив
PrintArray(array);           // Выводим в консоль массив
Console.WriteLine();      //вывод пустой строки
int pos = IndexOf(array, nums);  // Вызов функции поиска и запись результата в переменную pos
Console.WriteLine($"Позиция: {pos}");          // Вывод в консоль