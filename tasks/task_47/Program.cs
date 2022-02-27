// 47. Написать программу копирования массива

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 9);
        //Console.Write(collection[index] + " ");
        index++;
    }
}

void PrintArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        Console.Write(collection[index] + " ");
        index++;
    }
}


int[] array = new int[8];
int[] mass = new int[8];
FillArray(array); 
Console.WriteLine("Первый массив: ");
PrintArray(array);
Console.WriteLine(" ");
FillArray(mass);
Console.WriteLine("Второй массив: ");
PrintArray(mass);


for (int i = 0; i < array.Length; i++)
{
    mass[i] = array[i];
}
Console.WriteLine(" ");
Console.WriteLine("Второй массив перезаписан: ");
PrintArray(mass);