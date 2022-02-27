// 55. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

int average = 0;
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

for (int j = 0; j < n; j++)
{
    for (int i = 0; i < m; i++)
    {
        sum = sum + array[i,j];
    }
    average = sum / m;
    sum = 0;
    Console.WriteLine("Среднее арифметическое столбца " + j + ": " + average); //округленное до целых
}