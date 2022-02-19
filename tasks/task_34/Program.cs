// 34. Написать программу замену элементов массива на противоположные

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(-9, 9);
        if (collection[index] >= 0)
            Console.Write(" " + collection[index] + "\t "); //отступ перед положительным числом для красивого вывода
        else
            Console.Write(collection[index] + "\t ");
            index++;
    }
}

void OppositeArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = (collection[index] * -1);
        if (collection[index] >= 0)
            Console.Write(" " + collection[index] + "\t "); //отступ перед положительным числом для красивого вывода
        else
            Console.Write(collection[index] + "\t ");
        index++;
    }
}

int[] array = new int[10];
FillArray(array); 
Console.WriteLine();
OppositeArray(array);