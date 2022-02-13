// 15. Дано число. Проверить кратно ли оно 7 и 23

Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()); //пользователь вводит число

if (N % 7 == 0 && N % 23 == 0)
Console.WriteLine("Число " + N + " кратно 7 и 23");
else 
Console.WriteLine("Число " + N + " НЕ кратно 7 и 23");
