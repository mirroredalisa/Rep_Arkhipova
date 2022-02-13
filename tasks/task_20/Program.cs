// 20. Задать номер четверти, показать диапазоны для возможных координат

Console.WriteLine("Введите номер четверти: ");
int a = int.Parse(Console.ReadLine()); //пользователь вводит число

if ((a > 4) || (a < 1))
Console.WriteLine("Не является номером четверти");

else if (a == 1)
Console.WriteLine("х = -inf;0 y = 0;inf");

else if (a == 2)
Console.WriteLine("х = 0;inf y = 0;inf");

else if (a == 3)
Console.WriteLine("х = -inf;0 y = -inf;0");

else if (a == 4)
Console.WriteLine("х = 0;inf y = -inf;0");  