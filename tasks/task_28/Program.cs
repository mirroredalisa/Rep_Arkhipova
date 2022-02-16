// 28. Подсчитать сумму цифр в числе

int sum = 0;

Console.WriteLine("Введите число: ");
int A = int.Parse(Console.ReadLine()); //пользователь вводит число

while (A > 1)
{
    sum = sum + (A % 10);
    A = A / 10;

}
Console.WriteLine("Количество цифр: " + sum);