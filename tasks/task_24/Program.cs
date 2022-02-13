// 24. Найти кубы чисел от 1 до N

int M = 1;

Console.WriteLine("Введите число : ");
int N = int.Parse(Console.ReadLine()); //пользователь вводит число N

while (M <= N)
{
    Console.WriteLine(" " + M + "\t " + (M * M * M));
    M = (M + 1);
}
