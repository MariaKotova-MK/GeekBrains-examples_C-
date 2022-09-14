//  Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.


int[] FillArray(int size)
{
int[] mas = new int[size];
for (int i=0;i<size;i++)
{
mas[i]= new Random().Next(100,1000);
}
return mas;
}

void PrintArray(int[] mmm)
{
for (int i=0;i<mmm.Length;i++)
    {
    if (i!=mmm.Length-1) Console.Write($"{mmm[i]}, ");
    else Console.WriteLine($"{mmm[i]}");
    }
}

void CountEven (int[] array)
{
   int result = 0;

   foreach (int item in array)
   {
    if (item%2==0)
    result = result + 1;
   } 

    Console.WriteLine($"Количество четных чисел {result}");
}


int[] array=FillArray(12);
PrintArray(array);
CountEven(array);
