// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

void FillArray(float[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 100);
        Console.Write(collection[index] + " ");
        index++;
    }
}

void DiffArray(float[] collection)
{
    int length = collection.Length;
    int index = 0;
    float max = collection[0];
    float min = collection[0];
    float dif = 0;
        for (index = 0; index < length; index++)
    {
        if (collection[index] > max)
            max = collection[index];
        else if (collection[index] < min)
            min = collection[index];
    }
    dif = max - min;
    Console.WriteLine("Максимальный элемент: " + max);
    Console.WriteLine("Минимальный элемент: " + min);
    Console.WriteLine("Разница между максимальным и минимальным элементом: " + dif);
}

float[] array = new float[10];
FillArray(array); 
Console.WriteLine(" ");
DiffArray(array); 
