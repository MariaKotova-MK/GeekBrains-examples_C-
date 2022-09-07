// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

string Cube (int basic)
{
string result = string.Empty;
int count = 1;
double number;
while (count <= basic)
    {
    number = Math.Pow (count, 3);
    result = result+number+"  ";
    count++;
    }
return result;
}
Console.WriteLine ($"Кубы всех чисел от 1 до заданного числа: {Cube (6)}");
