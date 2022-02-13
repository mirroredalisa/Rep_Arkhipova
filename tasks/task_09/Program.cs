// 9. Показать последнюю цифру трёхзначного числа


Console.WriteLine("Введите 3-значное число: ");
int N = int.Parse(Console.ReadLine()); //пользователь вводит число

int C = N % 10;

Console.WriteLine("Последняя цифра: " + C);
