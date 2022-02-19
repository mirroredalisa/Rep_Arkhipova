//35. Определить, присутствует ли в заданном массиве, некоторое число

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(-9, 9);
        Console.Write(collection[index] + "\t ");
        index++;
    }
}

void CheckArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    int res = 0;
    Console.WriteLine("Введите число: ");
    int number = int.Parse(Console.ReadLine()); //пользователь вводит число
    while (index < length)
    {
        if (collection[index] == number)
        {
            res = 1;
        }
        index++;
    }
    if (res == 1)
        Console.Write("Число " + number + " присутствует в массиве"); 
    else
        Console.Write("Числа " + number + " нет в массиве");

}

int[] array = new int[10];
FillArray(array); 
Console.WriteLine();
CheckArray(array);