// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


int[,] FillMas(int n, int m)
{int[,] mas = new int[n, m];
for (int i = 0; i < n; i++)
{ for (int j = 0; j < m; j++)
    {mas[i, j] = new Random().Next(-10, 10);
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


void PrintMass(double[] mmm)
{
for (int i=0;i<mmm.Length;i++)
    {
    if (i!=mmm.Length-1) Console.Write($"{mmm[i]}, ");
    else Console.WriteLine($"{mmm[i]}");
    }
}

Console.WriteLine("Задайте размер массива");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
int[,]array =  FillMas(x, y);
PrintArray(array);
double [] average = new double[y];
double sum = 0;
int f = 0;
{for(int j = 0; j < array.GetLength(1); j++)
    {for (int i = 0; i < array.GetLength(0); i++)
        sum = sum + array[i,j];
        average[f] = sum;  
        f++;
        sum = 0; } 
}
for (f = 0; f<y; f++)
    {average[f] =  Math.Round((average[f]/x),3);
    }

Console.WriteLine("Средние арифметические каждого столбца = ");
PrintMass(average);
    
