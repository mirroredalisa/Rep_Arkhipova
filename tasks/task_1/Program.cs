// 1. По двум заданным числам проверять является ли первое квадратом второго

Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine()); //пользователь вводит 1 число

Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine()); //пользователь вводит 2 число

if (num1 == num2 * num2)
Console.WriteLine("Первое число является квадратом второго");
else
Console.WriteLine("Первое число НЕ является квадратом второго");