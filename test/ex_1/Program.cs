int[,] FillMas(int n, int m)
{
int[,] mas = new int[n, m];
for (int i = 0; i < n; i++)
{
for (int j = 0; j < m; j++)
{
mas[i, j] = new Random().Next(-10, 11);
}
}
return mas;
}


void PrintArray(int[,] arr)
{
for (int i = 0; i < arr.GetLength(0); i++)
{
for (int j = 0; j < arr.GetLength(1); j++)
{
if (j != arr.GetLength(1) - 1) Console.Write($"{arr[i, j]}, ");
else if (i == arr.GetLength(0) - 1 && j == arr.GetLength(1) - 1) Console.WriteLine($"{arr[i, j]}");
else if (j == arr.GetLength(1) - 1) Console.WriteLine($"{arr[i, j]},");
}
}
}


int[,] ChangeMas(int n, int m)
{
int[,] mas = new int[n, m];
for (int i = 0; i < n; i++)
    {
    for (int j = 0; j < m; j++)
        {
        if (i%2==1 & j%2==1)
        mas[i, j] =  mas[i, j]*  mas[i, j];
        }
}


int[,] newArray = FillMas(3, 4);
PrintArray(ChangeMas(3,5));