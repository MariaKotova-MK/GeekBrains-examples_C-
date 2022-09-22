// На вход программы подаются три целых положительных числа. Определить , является ли это сторонами треугольника
// . Если да, то вывести всю информацию по нему - площадь, периметр, значения углов треугольника в градусах, является ли он прямоугольным, равнобедренным, равносторонним.

string Triangular (double arg1, double arg2, double arg3)
{
    double P = arg1 + arg2 + arg3;
    double S = Math.Sqrt(P/2*(P/2 - arg1)*(P/2 - arg2)*(P/2 - arg3));
    string res = "такого треугольника не сущетсвует";
    if (arg1 < arg2+arg3 & arg2 < arg1+arg3 & arg3 < arg1+arg2) 
        if (arg1 == arg2 | arg2==arg3 | arg3==arg1) 
            {
            if (arg1 == arg2 && arg2 == arg3) res = $"Треугольник равнобедренный, периметр равен {P},площадь равна {S}";
            else res = $"Треугольник равносторонний, периметр равен {P},площадь равна {S}";
            }       
            else res = $"Треугольник разносторонний, периметр равен {P},площадь равна {S}";
    return res;
}


Console.WriteLine ("Введите стороны треугольника");
double arg1 = Convert.ToInt32 (Console.ReadLine());
double arg2 = Convert.ToInt32 (Console.ReadLine());
double arg3 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine (Triangular (arg1, arg2, arg3));

