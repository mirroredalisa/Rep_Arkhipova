// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

bool x = false;
bool y = false;

if (!(x || y) == (!x && !y)) 
{
    x = false;
    y = true;
    if (!(x || y) == (!x && !y)) 
    {
        x = true;
        y = false;
        if (!(x || y) == (!x && !y)) 
        {
            x = true;
            y = true;
            if (!(x || y) == (!x && !y))
            Console.WriteLine("ИСТИНА");
            else 
            Console.WriteLine("ЛОЖЬ");
        }
        else 
        Console.WriteLine("ЛОЖЬ");
    }
    else 
    Console.WriteLine("ЛОЖЬ");
}
else 
Console.WriteLine("ЛОЖЬ");






