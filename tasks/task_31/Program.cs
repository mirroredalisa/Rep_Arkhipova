// 31. Задать массив из 8 элементов и вывести их на экран

// через функцию и for
void print(int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
       Console.WriteLine(mass[i]); 
    }
    
}

int[] array = { 8, 7, 6, 5, 4, 3, 2, 1 };
print(array); 

/*
// через while
 //             0  1  2  3  4  5  6  7 
int[] array = { 8, 7, 6, 5, 4, 3, 2, 1 };

int a = 0;

while (a < array.Length)
{
    Console.WriteLine(array[a]);
    a++;
}
*/