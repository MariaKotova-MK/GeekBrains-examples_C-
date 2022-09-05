// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число...");
void SecondNumber ();
{
    int x = Convert.ToInt32(Console.ReadLine());
    if (х>99)
    {
        int y = (x%100)/10;
        Console.WriteLine("Вторая цифра этого числа " +y);
    } 
    else Console.WriteLine("Это не трехзначное чило, попробуйте снова");
}
SecondNumber ();