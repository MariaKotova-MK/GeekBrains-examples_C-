// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число...");
void ThirdNumber ()
{ int x = Convert.ToInt32 (Console.ReadLine());
    if (x>99 && x<1000)
    {
    int y = (x%100)/10;
    Console.WriteLine ("Вторая цифра " +y);
    }
else Console.WriteLine ("Попробуйте снова" );
}
ThirdNumber ();