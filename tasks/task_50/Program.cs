// 50. В двумерном массиве n×k заменить четные элементы на противоположные

Console.WriteLine("Введите кол-во строк: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов: ");
int n = int.Parse(Console.ReadLine());

int[,] array = new int[m,n];

for (int i = 0; i < m; i++)
{
    
    for (int j = 0; j < n; j++)
    {
        array[i,j] = new Random().Next(-9,9);
        Console.Write(array[i,j] + " ");
    }
    Console.WriteLine(" ");
}

Console.WriteLine("Замена чётных: ");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (array[i,j] % 2 == 0) //проверяем, чётный ли элемент
        {
            array[i,j] = array[i,j] * (-1); //меняем значение на противоположное
        }
            Console.Write(array[i,j] + " ");
    }
    Console.WriteLine(" ");
}
