// 53. В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет

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

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (array[i,j] == a)
        {
            Console.WriteLine("Число находится на позиции " + i + "" + j);
        }
    }
 }