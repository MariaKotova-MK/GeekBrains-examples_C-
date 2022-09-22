// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] FillMas(int n, int m)
{
double[,] mas = new double[n, m];
    for (int i = 0; i < n; i++)
        { for (int j = 0; j < m; j++)
            {mas[i, j] = new Random().NextDouble()*10;
        }
        }
    for (int i = 0; i < n; i++)
        {for (int j = 0; j < m; j++)
        {mas[i, j] = Math.Round(mas[i,j],2);
        }
    }
return mas;
}

void PrintArray(double[,] arr)
 {
for (int i = 0; i < arr.GetLength(0); i++)
    { for (int j = 0; j < arr.GetLength(1); j++)
            {if (j != arr.GetLength(1) - 1)
            Console.Write($"{arr[i, j]}| ");
            else if (i == arr.GetLength(0) - 1 && j == arr.GetLength(1) - 1)
            Console.WriteLine($"{arr[i, j]}");
            else if (j == arr.GetLength(1) - 1)
            Console.WriteLine($"{arr[i, j]}|");
            }
        }
 }

double[,] array=FillMas(2,5);
PrintArray(array);
