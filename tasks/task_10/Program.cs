// 10. Показать вторую цифру трёхзначного числа.


int Second(int N)
{
    int result = (N / 10 % 10);
    return result;
}

Console.WriteLine("Введите 3-значное число: ");
int N = int.Parse(Console.ReadLine()); //пользователь вводит число


Console.WriteLine("Вторая цифра: " + Second(N));
