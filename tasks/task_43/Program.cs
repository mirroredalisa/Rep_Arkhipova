// 43. Написать программу преобразования десятичного числа в двоичное

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()); //пользователь вводит число


int ost = 0;
int n = 0;
int[] mas = new int[0];
while (a > 0)
{
    ost = a % 2;
   // Console.Write(ost); элемент массива
    a = a / 2;
    Array.Resize(ref mas , n + 1);
    mas[n] = ost;
    //Console.Write(mas[n]); печать массива до разворота
    n = n + 1;
}

int m = n - 1;
int[] per = new int[n];
for (int i = 0; i <= m; i++)
{
    per[i] = mas[n-1];
    Console.Write(per[i]);
    n = n - 1;
}

