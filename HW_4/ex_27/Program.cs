//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Ввеите число");
int x = Convert.ToInt32(Console.ReadLine());
int i = 0;
while (x/((int)Math.Pow((Double)10,i))!=0) i++;
{
    return i;
}    

Console.WriteLine($"Количество ццифр в числе {i}");

