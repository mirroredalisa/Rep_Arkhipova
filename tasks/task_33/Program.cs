// 33. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива

int sumpol = 0;
int sumotr = 0;

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 9); //для проверки расчёта суммы отрицательных поменять здесь 0 на любое отрицательное число
        Console.WriteLine(collection[index]);
        index++;
    }
}

void SumArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        if (collection[index] > 0)
        sumpol = sumpol + collection[index];
        else 
        sumotr = sumotr + collection[index];
        index++;
    }
    Console.WriteLine("Сумма положительных чисел: " + sumpol);
    Console.WriteLine("Сумма отрицательных чисел: " + sumotr);
}

int[] array = new int[12];
FillArray(array); 
SumArray(array); 