// 54. В матрице чисел найти сумму элементов главной диагонали

int sum = 0;

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

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (i == j)
        {
            sum = sum + array[i,j];
        }
    }
    Console.WriteLine(" ");
}
Console.WriteLine("Сумма элементов главной диагонали: " + sum);