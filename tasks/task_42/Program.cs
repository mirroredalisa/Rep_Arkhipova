// 42. Определить сколько чисел больше 0 введено с клавиатуры

int N = 0;

void FillArray(int[] range)
{
    int length = N;
    for (int i = 0; i < N; i++)
    {
        Console.WriteLine("Введите число " + i);
        int num = int.Parse(Console.ReadLine()); //пользователь вводит числа
        range[i] = num;
    }
    /* печать массива
    for (int i = 0; i < N; i++)
    {
        Console.Write(range[i] + " ");
    }
    */
}

void CheckArray(int[] range)
{
    int length = range.Length;
    int i = 0;
    float calc = 0;
        for (i = 0; i < length; i++)
    {
        if (range[i] > 0)
            calc = calc + 1;
    }
    Console.WriteLine("Чисел больше 0: " + calc);
}


Console.WriteLine("Сколько чисел вы будете вводить?");
N = int.Parse(Console.ReadLine()); //пользователь вводит количество

int[] array = new int[N];
FillArray(array); 
Console.WriteLine(" ");
CheckArray(array);

