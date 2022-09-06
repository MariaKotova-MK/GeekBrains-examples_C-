// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

gitConsole.WriteLine("Введите число от 1 до 7");
int x = Convert.ToInt32 (Console.ReadLine());
void WeekEnd()
    {
        if (x>0 & x<8)
        {
            if (x==6|x==7) 
            {
            Console.WriteLine("Это выходной :)");
            }
            else Console.WriteLine("Это рабочий день :(");
        }
        else Console.WriteLine("попробуйте ещё раз");
    }
    WeekEnd();
