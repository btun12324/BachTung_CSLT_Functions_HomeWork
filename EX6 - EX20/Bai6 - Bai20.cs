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

        int a = 0;
        int b = 1;

        for (int i = 0; i < n; i++)
        {
            Console.Write(a + " ");

            int soTiepTheo = a + b;
            a = b;
            b = soTiepTheo;
        }
        Console.WriteLine();
    }

    public static int DemNguyenAm(string s)
    {
        int count = 0;
        
        string chuoiVietThuong = s.ToLower();

        for (int i = 0; i < chuoiVietThuong.Length; i++)
        {
            char c = chuoiVietThuong[i];
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            {
                count++;
            }
        }

        return count;
    }

    public static double TinhLuyThua(double x, int y)
    {
        int count = y;

        while(count != 0)
        {
            x = x * x;
            count--;
        }

        return x;
    }

    public static double TinhTrungBinh(int[] arr)
    {
        if (arr == null || arr.Length == 0)
        {
            return 0;
        }

        double tong = 0;

        foreach (int so in arr)
        {
            tong += so;
        }

        return tong / arr.Length;
    }

    public static bool KiemTraDoiXung(string s)
    {
        if (string.IsNullOrEmpty(s) || s.Length <= 1)
        {
            return true;
        }

        int a = 0;
        int b = s.Length - 1;

        while (a < b)
        {
            if (s[a] != s[b])
            {
                return false;
            }

            a++;
            b--;
        }

        return true;
    }

    public static double CelsiusToFarenheit(double c)
    {
        return (c * 1.8 + 32);
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