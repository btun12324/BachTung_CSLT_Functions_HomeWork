using System;

internal class EX5
{
    static string DaoNguocChuoi(string input)
    {
        char[] mangKyTu = input.ToCharArray();

        Array.Reverse(mangKyTu);

        return new string(mangKyTu);
    }
    public static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Nhập chuỗi cần đảo ngược: ");
        string chuoiGoc = Console.ReadLine();

        string chuoiDaoNguoc = DaoNguocChuoi(chuoiGoc);

        Console.WriteLine($"Chuỗi sau khi đảo ngược: {chuoiDaoNguoc}");

        Console.ReadKey();
    }
}