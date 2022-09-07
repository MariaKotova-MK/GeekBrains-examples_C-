// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double distance (int xa, int ya, int za, int xb, int yb, int zb)
{
    double res;
    res = Math.Sqrt ((xb - xa) * (xb - xa) + (yb - ya) * (yb - ya) + (zb - za)*(zb - za));
    return res;
}
try 
            {
            Console.Write ("Введите координату Х для первой точки ");
            int xa = Convert.ToInt32 (Console.ReadLine());
            Console.Write ("Введите координату Y для первой точки ");
            int ya = Convert.ToInt32 (Console.ReadLine());
            Console.Write ("Введите координату Z для первой точки ");
            int za = Convert.ToInt32 (Console.ReadLine());
            Console.Write ("Введите координату Х для второй точки ");
            int xb = Convert.ToInt32 (Console.ReadLine());
            Console.Write ("Введите координату Y для второй точки ");
            int yb = Convert.ToInt32 (Console.ReadLine());
            Console.Write ("Введите координату Z для второй точки ");
            int zb = Convert.ToInt32 (Console.ReadLine());
            double rez = distance (xa, ya, za, xb, yb, zb);
            Console.WriteLine ($"Расстоянием между точкой А с координатами ({xa},{ya},{za}) и точкой В с координатами ({xb},{yb},{zb}) равно {rez}");
            }
        catch
            {
                Console.WriteLine("please enter integers");
            }