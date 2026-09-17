using System;

internal class EX4
{
    static long Tinhgiaithua(int n)
    {
        long factorial = 1;

        for ( int i = 1; i <= n; i++)
        {
            factorial = factorial * i;
        }

        return factorial;

    }
    public static void Main(string[] args)
    {
        Console.Write("Nhap vao so can tinh giai thua: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"Giai thua cua {n} la {Tinhgiaithua(n)}");

        Console.ReadKey();
    }
}