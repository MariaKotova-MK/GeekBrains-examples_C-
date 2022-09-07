//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
string Palindrome(int x)
{
string result;
int x1 = x/10000;
int x5 = x%10;
int x2 = (x/1000)%10;
int x4 = (x%100)/10;
if (x1==x5 && x2==x4) result = "Это палиндром";
else result = "Это не палиндромом";
return result;
}

try
{
    Console.WriteLine ("Введите целое пятизначное число");
    int x = Convert.ToInt32 (Console.ReadLine());
    string result = Palindrome (x);
    Console.WriteLine (result);
    
}
catch
{
    Console.WriteLine ("некорректное число. Попробуйте снова");
}

