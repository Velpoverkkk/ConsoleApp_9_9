using System;
class Program
{   //Вычислить произведение n>=2 соиножителей  (с применением рекурсии и без неё)
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int n;
        System.Console.WriteLine("Chislo N");
        n = System.Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Chislo M");
        Console.WriteLine(Norm(n));
        Console.WriteLine(Rec(n,1));

    }
    static double Norm(int n)
    {
        double a = 1.0;
        for (double i = 2.0; i <= n; i+=2.0)
        {
            a*= i * i /((i - 1) * (i + 1));
            
        }
        return a;
    }
    static double Rec(double n, double a)
    {
        if (n != 0) return Rec(n - 2.0, a*(n*n)/((n-1.0)*(n+1.0)));
        else return a;
    }
}
