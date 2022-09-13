// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.


// int mult = 1;
// Console.Write("Введите число - ");
// int N = Convert.ToInt32(Console.ReadLine());
// for (int i =1; i<=N; i++) mult = mult*i;
// Console.Write("Произведение равно " + mult);


Console.WriteLine("Введите размерность массива - " );
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
for(int i = 0;i<N;i++)
{
        array[i] = new Random().Next(1,100);
        Console.Write(array[i]+" ");
}

