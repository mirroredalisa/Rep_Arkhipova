// 7. Показать числа от -N до N

int M;

Console.WriteLine("Введите число : ");
int N = int.Parse(Console.ReadLine()); //пользователь вводит число N

M = (N*(-1));

while (M <= N)
{
    Console.WriteLine(" " + M);
    M = (M + 1);
}