// 73. Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем.

/*
void PrintArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        Console.Write(collection[index] + " ");
        index++;
    }
}
*/

Console.WriteLine("Введите N: ");
int n = int.Parse(Console.ReadLine());

int[] array = new int[n];

for (int i = 0; i < n; i++)
{
    array [i] = i+1;
   //Console.Write(array[i] + " ");
}

int[,] array2 = new int[n,n];

int a = 0;
int b = 0;

for (int i = 0; i < n; i++) //перебираем элементы, которые проверяем
{
  if (array [i] != -1)
   {
        b = b + 1;
        array2[a,b] = array [i]; //записываем первый элемент в массив
        Console.Write("Группа " + (b) + ": ");
        Console.Write(array2[a,b] + " ");
        a = a + 1;
        for (int j = 0; j < n; j++) //перебираем все элементы для проверки условия
        {  
           if ((array [j] != -1) && (array [j] != 2) && (array [j] != 1))
           {   
               if ((array[j] % array[i] != 0) && (array[j] % array[i] != 0)) //если не делится нацело
               {
                 array2[a,b] = array[j]; //записываем элемент в массив
                 array[j] = -1; //чтобы исключить этот элемент из исходного массива
                 Console.Write(array2[a,b] + " ");
                 a = a + 1; 
               }
           }
        }   
        Console.WriteLine(" ");
        a = 0;
   }
}
Console.WriteLine("Количество групп М: " + b);