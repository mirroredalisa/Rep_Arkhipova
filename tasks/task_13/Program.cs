// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.

Console.WriteLine("Введите число 1: ");
int N = int.Parse(Console.ReadLine()); //пользователь вводит число 1

Console.WriteLine("Введите число 2: ");
int M = int.Parse(Console.ReadLine()); //пользователь вводит число 2

if (N % M == 0)
Console.WriteLine("Число " + N + " кратно числу " + M);
else 
Console.WriteLine("Остаток " + (N % M));
    


