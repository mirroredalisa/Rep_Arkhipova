// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

Console.WriteLine("Введите координату x: ");
int x = int.Parse(Console.ReadLine()); //пользователь вводит число x

Console.WriteLine("Введите координату y: ");
int y = int.Parse(Console.ReadLine()); //пользователь вводит число y

if ((x == 0) || (y == 0))
Console.WriteLine("Координаты находятся на оси");

else if ((x < 0) && (y < 0))
Console.WriteLine("Четверть номер 3");

else if ((x < 0) && (y > 0))
Console.WriteLine("Четверть номер 2");

else if ((x > 0) && (y < 0))
Console.WriteLine("Четверть номер 4");

else if ((x > 0) && (y > 0))
Console.WriteLine("Четверть номер 2");   
