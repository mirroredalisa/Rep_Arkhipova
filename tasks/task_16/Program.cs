// 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным


Console.WriteLine("Введите номер дня недели: ");
string num = Console.ReadLine(); //пользователь вводит число

if (num == "1")
Console.WriteLine("НЕ выходной");
else if (num == "2")
Console.WriteLine("НЕ выходной");
else if (num == "3")
Console.WriteLine("НЕ выходной");
else if (num == "4")
Console.WriteLine("НЕ выходной");
else if (num == "5")
Console.WriteLine("НЕ выходной");
else if (num == "6")
Console.WriteLine("выходной");
else if (num == "7")
Console.WriteLine("выходной");
else
{
Console.WriteLine("Это не номер дня недели");
}