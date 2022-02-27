// 41. Выяснить, являются ли три числа сторонами треугольника (теорема о неравенстве треугольника: каждая сторона меньше суммы двух его других сторон)

int sum12 = 0;
int sum23 = 0;
int sum31 = 0;


Console.WriteLine("Введите длину первой стороны: ");
int side1 = int.Parse(Console.ReadLine()); //пользователь вводит 1 число

Console.WriteLine("Введите длину второй стороны: ");
int side2 = int.Parse(Console.ReadLine()); //пользователь вводит 2 число

Console.WriteLine("Введите длину третьей стороны: ");
int side3 = int.Parse(Console.ReadLine()); //пользователь вводит 3 число

sum12 = side1 + side2;
sum23 = side2 + side3;
sum31 = side3 + side1;

if ((sum12 > side3) && (sum23 > side1) && (sum31 > side2))
Console.WriteLine("Введённые числа являются сторонами треугольника");
else
Console.WriteLine("Введённые числа НЕ являются сторонами треугольника");

