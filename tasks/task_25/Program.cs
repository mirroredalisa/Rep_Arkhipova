// 25. Найти сумму чисел от 1 до А

int M = 1;
int sum = 0;

Console.WriteLine("Введите число : ");
int A = int.Parse(Console.ReadLine()); //пользователь вводит число A

while (M <= A)
{
    sum = sum + M;
    M = (M + 1);
}
Console.WriteLine("Сумма чисел: " + sum);