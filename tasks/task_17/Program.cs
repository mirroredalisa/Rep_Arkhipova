// 17. По двум заданным числам проверять, является ли одно квадратом другого

Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine()); //пользователь вводит 1 число

Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine()); //пользователь вводит 2 число

if (num1 == num2 * num2)
Console.WriteLine("Первое число является квадратом второго");
else if (num2 == num1 * num1)
Console.WriteLine("Второе число является квадратом первого");
else
Console.WriteLine("Ни одно из чисел не является квадратом другого");