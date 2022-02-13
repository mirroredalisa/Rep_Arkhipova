// 12. Удалить вторую цифру трёхзначного числа.


int First(int N)
{
    int result = (N / 100 % 10);
    return result;
}

int Second(int N)
{
    int result = (N / 10 % 10);
    return result;
}

int Third(int N)
{
    int result = (N % 10);
    return result;
}

Console.WriteLine("Введите 3-значное число: ");
int N = int.Parse(Console.ReadLine()); //пользователь вводит число


Console.WriteLine(First(N) +""+ Third(N));
