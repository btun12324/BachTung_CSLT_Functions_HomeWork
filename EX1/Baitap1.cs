using System;

internal class Baitap1
{ 
    static int tinhtong( int a, int b)
    {
        int c = a + b;
        return c;
    }

    public static void Main(string[] args)
    {
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("a + b = ");
        Console.WriteLine(tinhtong(a, b));

        Console.ReadKey();
    }
}