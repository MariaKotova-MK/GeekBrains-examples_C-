// сдуфк

int[,] FillMas(int n, int m)
{int[,] mas = new int[n, m];
for (int i = 0; i < n; i++)
{ for (int j = 0; j < m; j++)
    {mas[i, j] = new Random().Next(-10, 11);
    }
}
return mas;
}

void PrintArray(int[,] arr)
{ for (int i = 0; i < arr.GetLength(0); i++)
    {for (int j = 0; j < arr.GetLength(1); j++)
        {if (j != arr.GetLength(1) - 1)
        Console.Write($"{arr[i, j]}| ");
        else if (i == arr.GetLength(0) - 1 && j == arr.GetLength(1) - 1)
        Console.WriteLine($"{arr[i, j]}");
        else if (j == arr.GetLength(1) - 1)
        Console.WriteLine($"{arr[i, j]}|");
        }
    }
}


void FindEll(int[,] arr, int x, int y)
{ for (int i = 0; i < arr.GetLength(0); i++)
        {for (int j = 0; j < arr.GetLength(1); j++)
           {if ( x == i && y == j) Console.WriteLine($"Искомый элемент {arr[i,j]}");
            } 
}
}

Console.WriteLine("Введите размер двумерного массива");
int i = Convert.ToInt32(Console.ReadLine());
int j = Convert.ToInt32(Console.ReadLine());
int[,] array = FillMas(i,j);
PrintArray(array);
Console.WriteLine("Введите индексы элемента");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
if (x>i && y>j) Console.WriteLine($"Такого элемента нет");
else FindEll(array, x, y);
