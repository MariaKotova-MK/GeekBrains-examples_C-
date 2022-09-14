// // Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int PowerNumber(int x, int y)
{
int result = 1;
for (int i = 1; i <= y; i++)
{
    result = result * x;
    }
    return result;
}
try
{
    System.Console.Write("Введите число - ");
    int x = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("В какую степень возвести это число - ");
    int y = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine($"{x} в степени {y} = {PowerNumber(x,y)}");
}
catch
{
    System.Console.WriteLine("Попробуйте снова - Введите именно целое положительное число");
}