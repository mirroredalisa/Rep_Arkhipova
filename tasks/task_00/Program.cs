// 0. Вывести квадрат числа

//int num = 15; //задаём число сами
//int num = new Random().Next(1, 10); //генерация случайного числа в заданном диапазоне

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()); //число вводит пользователь

Console.WriteLine("num: " + num);

Console.WriteLine("num^2: " + num * num);

