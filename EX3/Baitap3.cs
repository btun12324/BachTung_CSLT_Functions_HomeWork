using System;

internal class EX3
{
    static int Timmax(int a, int b, int c)
    {
        return Math.Max(Math.Max(a, b), c);
    }
    public static void Main(string[] args)
    {
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("c = ");
        int c = int.Parse(Console.ReadLine());

        Console.WriteLine("so lon nhat trong 3 so la: " + Timmax(a,b,c));

        Console.ReadKey();
    }
}