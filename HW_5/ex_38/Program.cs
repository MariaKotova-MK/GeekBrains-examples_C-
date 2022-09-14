//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


// int[] FillArray(int size)
// {
// int[] mas = new int[size];
// for (int i=0;i<size;i++)
// {
// mas[i]= new Random().Next(0,100);
// }
// return mas;
// }

// void PrintArray(int[] mmm)
// {
// for (int i=0;i<mmm.Length;i++)
//     {
//     if (i!=mmm.Length-1) Console.Write($"{mmm[i]}, ");
//     else Console.WriteLine($"{mmm[i]}");
//     }
// }

// int[] array1 = FillArray(8);
// void SubMaxMin(int[] array)
// {
// int max = array[0];
// int min = array[0];
// int Sub = 0;
// for (int i = 1; i < array.Length; i++)
// {
//     if (array[i] > max) 
//     {
//     max = array[i];
//     }
//     if (array[i] < min) 
//     {
//     min = array[i];
//     }
//     Sub = max-min;
// }
//  Console.WriteLine($"макисмально значение {max}, минимальное значение {min}, разница {Sub}");
// }

// PrintArray(array1);
// SubMaxMin(array1);



double[] FillArray(int size)
{
double[] mas = new double[size];
for (int i=0;i<size;i++)
{
mas[i]= new Random().NextDouble()*10000;
}
for (int i=0;i<size;i++)
{
mas[i]= Math.Round(mas[i],3);
}
return mas;
}

void PrintArray(double[] mmm)
{
for (int i=0;i<mmm.Length;i++)
    {
    if (i!=mmm.Length-1) Console.Write($"{mmm[i]}| ");
    else Console.WriteLine($"{mmm[i]}");
    }
}

double[] array1 = FillArray(3);
void SubMaxMin(double[] array)
{
double max = array[0];
double min = array[0];
double Sub = 0;
for (int i = 1; i < array.Length; i++)
{
    if (array[i] > max) 
    {
    max = array[i];
    }
    if (array[i] < min) 
    {
    min = array[i];
    }
    Sub = max-min;
}
 Console.WriteLine($"макисмально значение {max}, минимальное значение {min}, разница {Sub}");
}

PrintArray(array1);
SubMaxMin(array1);

