internal class Baitap2
{
    static bool OddorEven(int n)
    {
        if (n % 2 == 0)
            return true;
        else
            return false;
    }

    private static void Main(string[] args)
    {
        Console.Write("Nhap vao so can kiem tra: ");
        int n = int.Parse(Console.ReadLine());

        if (OddorEven(n) == true)
            Console.WriteLine("n la so chan");
        else
            Console.WriteLine($"so {n} la so le");

        Console.ReadKey();
    }
}