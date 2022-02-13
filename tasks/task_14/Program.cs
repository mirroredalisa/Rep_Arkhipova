// 14. Найти третью цифру числа или сообщить, что её нет.

int C;

Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()); //пользователь вводит число

if (N < 100)
Console.WriteLine("Третьей цифры нет");
else if (N > 99)
{
    if (N < 1000)
    {
        C = (N % 10);
        Console.WriteLine("Третья цифра: " + C);
    }
    else 
    {
        while (N > 999)
        {
            N = N / 10;
        }
        C = (N % 10);
        Console.WriteLine("Третья цифра: " + C);
    }
}    
