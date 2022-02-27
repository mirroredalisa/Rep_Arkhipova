// 46. Написать программу масштабирования фигуры

Console.WriteLine("Сколько вершин у фигуры? ");
int N = int.Parse(Console.ReadLine()); //пользователь вводит кол-во точек

int[] masx = new int[N];
int[] masy = new int[N];

for (int i = 1; i <= (N); i++)
{
    Console.WriteLine("Введите координату х вершины: " + i);
    int x = int.Parse(Console.ReadLine()); //пользователь вводит x
    masx[i-1] = x;
    Console.WriteLine("Введите координату y вершины: " + i);
    int y = int.Parse(Console.ReadLine()); //пользователь вводит y
    masy[i-1] = y;
    //Console.Write(masx[i-1]);
    //Console.Write(masy[i-1]);
}

Console.WriteLine("Задайте коэффициент масштабирования: ");
int k = int.Parse(Console.ReadLine()); //пользователь вводит k

Console.Write(" ");
for (int i = 1; i <= (N); i++)
{
    masx[i-1] = masx[i-1] * k;
    masy[i-1] = masy[i-1] * k;
    Console.Write("(" + masx[i-1] + " , " + masy[i-1] + ") ");
}
