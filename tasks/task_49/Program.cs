// 49. Показать двумерный массив размером m×n заполненный вещественными числами

Console.WriteLine("Введите кол-во строк: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов: ");
int n = int.Parse(Console.ReadLine());

double[,] array = new double[m,n];

for (int i = 0; i < m; i++)
{
    
    for (int j = 0; j < n; j++)
    {
        array[i,j] = new Random().NextDouble();
        Console.Write(array[i,j] + " ");
    }
    Console.WriteLine(" ");
}
