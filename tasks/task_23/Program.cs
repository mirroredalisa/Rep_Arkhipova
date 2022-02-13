// 23. Показать таблицу квадратов чисел от 1 до N

int M = 1;

Console.WriteLine("Введите число : ");
int N = int.Parse(Console.ReadLine()); //пользователь вводит число N

while (M <= N)
{
    Console.WriteLine(" " + M + " " + (M * M));
    M = (M + 1);
}