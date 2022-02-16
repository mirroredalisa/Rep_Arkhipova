// 30. Показать кубы чисел, заканчивающихся на четную цифру

int B = 0;
int cube = 0;

Console.WriteLine("Введите число: ");
int A = int.Parse(Console.ReadLine()); //пользователь вводит число

B = A % 10;

if (B % 2 == 0)
{
cube = A * A * A;
Console.WriteLine("Куб числа: " + cube);
}
else
Console.WriteLine("Последняя цифра нечётная");