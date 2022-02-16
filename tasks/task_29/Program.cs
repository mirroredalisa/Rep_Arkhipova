// 29. Написать программу вычисления произведения чисел от 1 до N

int M = 1;
int mult = 1;

Console.WriteLine("Введите число : ");
int N = int.Parse(Console.ReadLine()); //пользователь вводит число N

while (M <= N)
{
    mult = mult * M;
    M = (M + 1);
}
Console.WriteLine("Произведение чисел от 1 до N: " + mult);