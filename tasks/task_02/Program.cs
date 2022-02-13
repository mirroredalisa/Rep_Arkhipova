// 2. Даны два числа. Показать большее и меньшее число

Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine()); //пользователь вводит 1 число

Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine()); //пользователь вводит 2 число

if (num1 > num2)
{
Console.WriteLine("Большее число: " + num1);
Console.WriteLine("Меньшее число: " + num2);
}
else if (num2 > num1)
{
Console.WriteLine("Большее число: " + num2);
Console.WriteLine("Меньшее число: " + num1);
}
else
{
Console.WriteLine("Числа равны");
}