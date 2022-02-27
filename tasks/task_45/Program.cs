// 45. Показать числа Фибоначчи

double Fibonacci (int n)
{
    if (n<3)
    {
        return 1;
    }
    return Fibonacci (n - 1) + Fibonacci (n - 2);
}

int num = 7;

Console.WriteLine(Fibonacci (num));

for (int i = 1; i < num; i++)
{
    Console.WriteLine(Fibonacci (i));
}
