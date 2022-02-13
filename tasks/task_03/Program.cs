// 3. По заданному номеру дня недели вывести его название

Console.WriteLine("Введите номер дня недели: ");
string num = Console.ReadLine(); //пользователь вводит число

if (num == "1")
Console.WriteLine("понедельник");
else if (num == "2")
Console.WriteLine("вторник");
else if (num == "3")
Console.WriteLine("среда");
else if (num == "4")
Console.WriteLine("четверг");
else if (num == "5")
Console.WriteLine("пятница");
else if (num == "6")
Console.WriteLine("суббота");
else if (num == "7")
Console.WriteLine("воскресенье");
else
{
Console.WriteLine("Число не соответствует условию");
}