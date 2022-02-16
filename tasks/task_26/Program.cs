// 26. Возведите число А в натуральную степень B используя цикл

int M = 1;
int mult;

Console.WriteLine("Введите число A: ");
int A = int.Parse(Console.ReadLine()); //пользователь вводит число A

Console.WriteLine("Введите степень B: ");
int B = int.Parse(Console.ReadLine()); //пользователь вводит число B

mult = A;

while (M < B)
{
    mult = mult * A;
    M = (M + 1);
}
Console.WriteLine("Число A в степени B: " + mult);
