// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

void PrintArray(int[] mmm)
{
for (int i=0;i<mmm.Length;i++)
    {
    if (i!=mmm.Length-1) Console.Write($"{mmm[i]}| ");
    else Console.WriteLine($"{mmm[i]}");
    }
}

Console.WriteLine("Введите размер массива");
int n = Convert.ToInt32(Console.ReadLine());
int [] array = new int[n];
int sum = 0;
for (int i=0; i<n;i++)
    { Console.WriteLine("Введите значение массива -");
    int x = Convert.ToInt32(Console.ReadLine());
    array[i] = x;
    }
for (int i=0; i<n;i++)
    {if (array[i]>0) sum = sum +1;
    }
PrintArray(array);
Console.WriteLine($"Сумма чисел больше 0 = {sum}");


