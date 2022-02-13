// 21. Программа проверяет пятизначное число на палиндромом.

int b = 0;
int a1 = 0;
int a2 = 0;
int a3 = 0;
int a4 = 0;
int a5 = 0;
int a6 = 0;

Console.WriteLine("Введите 5-значное число: ");
int a = int.Parse(Console.ReadLine()); //пользователь вводит число

if ((a > 99999) || (a < 10000))
Console.WriteLine("Число не 5-значное");

else 
{
a1 = a % 10;
a2 = a / 10 % 10;
a3 = a / 100 % 10;
a4 = a / 1000 % 10;
a5 = a / 10000;

b = a1 * 10000 + a2 * 1000 + a3 * 100 + a4 * 10 + a5;

//Console.WriteLine(" " + b); //вывод числа в обратном порядке

if (a == b)
Console.WriteLine("Число является палиндромом");
else
Console.WriteLine("Число НЕ является палиндромом");
}
