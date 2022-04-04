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
          array2[a,b] = array [i]; //записываем первый элемент в массив
          Console.Write("Группа " + (b+1) + ": ");
          Console.Write(array2[a,b] + " ");
          a = a + 1;
          for (int j = 0; j < n; j++) //перебираем все элементы для проверки условия
        {
            if ((array[j] % array[i] != 0) && (array[j] % array[i] != 0)) //если не делится нацело
            {
                array2[a,b] = array[j]; //записываем элемент в массив
                Console.Write(array2[a,b] + " ");
                //нужно удалить этот элемент из исходного массива?
                a = a + 1;
            }
        }
        Console.WriteLine(" ");
        a = 0;
        b = b + 1;
    }

//PrintArray(array2);

/*
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(array2[i,j] + " ");
    }
    Console.WriteLine(" ");
}
*/


//}

/*
int[,] array = new int[n,n];
//int[,] group = new int[b,a];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i,j] = new Random().Next(1,50);
        Console.Write(array[i,j] + " ");
    }
    Console.WriteLine(" ");
}
/*


/*
for (int j = 0; j < n1; j++)
{
    for (int i = 0; i < n2; i++)
    {
        for (int u = 1; j < n1; j++)
        {
            for (int v = 0; j < n2; j++)
            {
                if (array[i,j] % array[v,u])
                group[a] = array[i,j];
                a = a + 1;
            }
        }
    }
 }

Console.WriteLine(group[a] + " "); 
*/