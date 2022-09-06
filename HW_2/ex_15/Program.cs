//11 hard Напишите программу, которая принимает на вход целое число любой разрядности число и удаляет вторую цифру слева направо этого


Console.WriteLine("Введите любое целое число");
int x = Convert.ToInt32(Console.ReadLine());
void DelSecondNumber()
    {
        int counter = 1;
        int x2 = x;
        while (x2>100)
            {
            x2 = x2/10;
            counter = counter*10;
            }
        int result = ((x2/10)*counter) + (x%counter);
        Console.WriteLine("Число без 2й цифры " +result);
    }
DelSecondNumber();
