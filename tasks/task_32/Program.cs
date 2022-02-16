// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран


void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 2);
        Console.WriteLine(collection[index]);
        index++;
    }
}


int[] array = new int[8];
FillArray(array); 


