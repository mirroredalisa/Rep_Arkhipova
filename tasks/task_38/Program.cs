// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 9);
        Console.WriteLine(collection[index]);
        index++;
    }
}

void SumArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    int sum = 0;
    while (index < length)
    {
        sum = sum +collection[index];
        index = index + 2;
    }
    Console.WriteLine("Сумма нечётных элементов: " + sum);
}

int[] array = new int[10];
FillArray(array); 
SumArray(array); 