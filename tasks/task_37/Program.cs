// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 300);
        Console.Write(collection[index] + " ");
        index++;
    }
}

void CountArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    int count = 0;
    while (index < length)
    {
        if (collection[index] >= 10 && collection[index] <=99)
        {
            count = count + 1;
        }
        index++;
    }
    Console.WriteLine("Количество элементов из отрезка [10,99]: " + count);
}

int[] array = new int[123];
FillArray(array); 
Console.WriteLine();
CountArray(array); 
