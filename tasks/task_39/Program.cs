// 39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

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
    int index1 = 0;
    int index2 = collection.Length - 1;
    int sum = 0;
        for (index1 = 0; index1 < length; index1++)
    {
        if (index1 != index2)
        sum = collection[index1] + collection[index2];
        else 
        sum = collection[index1];
        Console.WriteLine("Сумма пары элементов: " + sum);
        index2 = index2 - 1;
    }

}

int[] array = new int[10];
FillArray(array); 
SumArray(array); 