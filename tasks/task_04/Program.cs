// 4. Найти максимальное из трёх чисел.

int max = 0; //вводим переменную

Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine()); //пользователь вводит 1 число

Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine()); //пользователь вводит 2 число

Console.WriteLine("Введите третье число: ");
int num3 = int.Parse(Console.ReadLine()); //пользователь вводит 3 число

max = num1;
if (num2 > max) max = num2;
if (num3 > max) max = num3;

Console.WriteLine("Максимальное число: " + max);
