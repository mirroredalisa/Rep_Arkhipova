// 8. Показать чётные числа от 1 до N.

int M = 1;

Console.WriteLine("Введите число : ");
int N = int.Parse(Console.ReadLine()); //пользователь вводит число N

while (M <= N)
{
    if (M % 2 == 0)
    Console.WriteLine(" " + M);
    M = (M + 1);
}
