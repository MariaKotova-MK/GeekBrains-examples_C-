// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.


int[] FillArray(int size)
{
int[] mas = new int[size];
for (int i=0;i<size;i++)
{
mas[i]= new Random().Next(0,100);
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

void CountOddInd(int[] array)
{
   int result = 0;

   for (int i = 0; i < array.Length; i++)
       {if (i%2==1)
       result = result + array[i];
       }
Console.WriteLine($"Сумма элементов на нечетных позициях - {result}");
}



int[] array=FillArray(3);
PrintArray(array);
CountOddInd(array);