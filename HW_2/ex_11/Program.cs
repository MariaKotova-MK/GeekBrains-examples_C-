// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число...");
void ThirdNumber ()
{
int x = Convert.ToInt32 (Console.ReadLine());
int counter = 1;
int x2 = x;
if (x>100)
    { while (x2>100)
        {
            x2 = x2/10;
            counter = counter*10;
        }
        int x3 = (x%counter)/(counter/10);
        Console.WriteLine("Третья цифра этого числа " +x3);
    }
else Console.WriteLine("У этого числа нет 3ей цифры");
}
ThirdNumber ();