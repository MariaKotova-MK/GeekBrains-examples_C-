// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Трехзначное число...");
void SecondNumber ()
{
int x = new Random().Next(100,1000);;
Console.WriteLine(x);
int y = (x%100)/10;
Console.WriteLine("Вторая цифра этого числа " +y);
}
SecondNumber ();