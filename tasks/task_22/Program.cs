// 22. Найти расстояние между точками в пространстве 2D/3D

int A;
int B;
int C;
int D;

Console.WriteLine("Точки в пространстве 3D или 2D? (3/2)");
int O = int.Parse(Console.ReadLine()); //пользователь выбирает пространство

if (O == 3)
{
    Console.WriteLine("Введите координату x первой точки: ");
    int x1 = int.Parse(Console.ReadLine()); //пользователь вводит число x

    Console.WriteLine("Введите координату y первой точки: ");
    int y1 = int.Parse(Console.ReadLine()); //пользователь вводит число y

    Console.WriteLine("Введите координату z первой точки: ");
    int z1 = int.Parse(Console.ReadLine()); //пользователь вводит число z

    Console.WriteLine("Введите координату x второй точки: ");
    int x2 = int.Parse(Console.ReadLine()); //пользователь вводит число x

    Console.WriteLine("Введите координату y второй точки: ");
    int y2 = int.Parse(Console.ReadLine()); //пользователь вводит число y

    Console.WriteLine("Введите координату z второй точки: ");
    int z2 = int.Parse(Console.ReadLine()); //пользователь вводит число z

    A = (x2 - x1) * (x2 - x1);
    B = (y2 - y1) * (y2 - y1);
    C = (z2 - z1) * (z2 - z1);
    D = A + B + C;

    Console.WriteLine("Расстояние: " + D);
}

else if (O == 2)
{
    Console.WriteLine("Введите координату x первой точки: ");
    int x1 = int.Parse(Console.ReadLine()); //пользователь вводит число x

    Console.WriteLine("Введите координату y первой точки: ");
    int y1 = int.Parse(Console.ReadLine()); //пользователь вводит число y

    Console.WriteLine("Введите координату x второй точки: ");
    int x2 = int.Parse(Console.ReadLine()); //пользователь вводит число x

    Console.WriteLine("Введите координату y второй точки: ");
    int y2 = int.Parse(Console.ReadLine()); //пользователь вводит число y

    A = (x2 - x1) * (x2 - x1);
    B = (y2 - y1) * (y2 - y1);
    D = A + B;

    Console.WriteLine("Расстояние: " + D);
}

else
Console.WriteLine("Необходимо ввести цифру 2 или 3");

 



