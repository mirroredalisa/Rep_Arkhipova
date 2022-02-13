// 5. Написать программу вычисления значения функции y = f(a)

int y (int a)
{
    int result = (a * a);
    return result;
}

Console.WriteLine("Введите число а: ");
int a = int.Parse(Console.ReadLine()); //пользователь вводит число

Console.WriteLine("y = " + y);