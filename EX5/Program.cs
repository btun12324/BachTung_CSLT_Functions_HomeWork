using System;

internal class EX620
{
    
    public static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        EX06();

        /*EX07();

        EX08();

        EX09();

        EX10();

        EX11();

        EX12();

        EX13();

        EX14();

        EX15();

        EX16();

        EX17();

        EX18();

        EX19();

        EX20();*/

        Console.ReadKey();
    }


    public static bool KiemTraNguyenTo(int n)
    {
        if (n < 2)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    public static void InFibonacci(int n)
    {
        if (n <= 0) return;

        int soThuNhat = 0;
        int soThuHai = 1;

        for (int i = 0; i < n; i++)
        {
            Console.Write(soThuNhat + " ");

            int soTiepTheo = soThuNhat + soThuHai;
            soThuNhat = soThuHai;
            soThuHai = soTiepTheo;
        }
        Console.WriteLine(); 
    }

    public static void EX06()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Nhập vào số cần kiểm tra: ");
        int n = int.Parse(Console.ReadLine());

        if (KiemTraNguyenTo(n)) Console.WriteLine($"{n} là số nguyên tố");
        else Console.WriteLine($"{n} không phải là số nguyên tố");
    }

}