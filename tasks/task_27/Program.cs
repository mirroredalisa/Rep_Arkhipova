// 27. Определить количество цифр в числе

int count = 0;

Console.WriteLine("Введите число: ");
int A = int.Parse(Console.ReadLine()); //пользователь вводит число

while (A > 1)
{
    A = A / 10;
    count = (count + 1);
}
Console.WriteLine("Количество цифр: " + count);
