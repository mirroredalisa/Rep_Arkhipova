// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(100, 999);
        Console.WriteLine(collection[index]);
        index++;
    }
}

void CountArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    int cet = 0;
    int necet = 0;
    while (index < length)
    {
        if (collection[index] % 2 == 0)
        {
            cet = cet +1;
        }
        else
        {
            necet = necet + 1;
        }
        index++;
    }
    Console.WriteLine("Чётных чисел: " + cet + " Нечётных чисел: " + necet);
}

int[] array = new int[10];
FillArray(array); 
CountArray(array); 