// 52. В двумерном массиве заменить элементы, у которых оба индекса чётные, на их квадраты

Console.WriteLine("Введите кол-во строк: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов: ");
int n = int.Parse(Console.ReadLine());

int[,] array = new int[m,n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i,j] = new Random().Next(0,9);
        Console.Write(array[i,j] + " ");
    }
    Console.WriteLine(" ");
}

Console.WriteLine("Результат: ");

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (i % 2 == 0 && j % 2 == 0)
        {
            array[i,j] = array[i,j] * array[i,j];
        }
        Console.Write(array[i,j] + " ");
    }
    Console.WriteLine(" ");
}