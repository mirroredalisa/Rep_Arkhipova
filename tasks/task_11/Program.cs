// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

Console.WriteLine("Введите 2-значное число: ");
int N = int.Parse(Console.ReadLine()); //пользователь вводит число

int First = N / 10;
int Second = N % 10;

if (First > Second) 
Console.WriteLine("Наибольшая цифра: " + First);
else if (Second > First)
Console.WriteLine("Наибольшая цифра: " + Second);
else 
Console.WriteLine("Цифры равны");