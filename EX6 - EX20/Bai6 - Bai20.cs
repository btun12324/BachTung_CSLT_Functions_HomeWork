using System;

internal class EX620
{

    public static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        EX06();

        //EX07();

        //EX08();

        //EX09();

        //EX10();

        //EX11();

        //EX12();

        //EX13();

        //EX14();

        //EX15();

        //EX16();

        //EX17();

        //EX18();

        //EX19();

        //EX20();

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

    static void nhapmang(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            Console.Write($"a[{i}]:  ");
            a[i] = int.Parse(Console.ReadLine());
        }
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

    public static int TimMin(int[] arr)
    {
        int temp = 0;

        foreach ( int n in arr)
        {
            if (n < temp)
            {
                temp = n;
            }
        }

        return temp;
    }

    public static int TongCacChuSo(int n)
    {
        int tong = 0;

        n = Math.Abs(n);

        while (n > 0)
        {
            int chuSoCuoi = n % 10;

            tong += chuSoCuoi;

            n = n / 10;
        }

        return tong;
    }

    public static void SapXepMang(int[] arr)
    {
        if (arr == null || arr.Length == 0) return;

        Array.Sort(arr);

        foreach (int so in arr)
        {
            Console.Write(so + " ");
        }
        Console.WriteLine(); 
    }

    public static string XoaTrungLap(string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return s;
        }

        string chuoiKetQua = "";

        foreach (char kyTu in s)
        {
            if (!chuoiKetQua.Contains(kyTu))
            {
                chuoiKetQua += kyTu;
            }
        }

        return chuoiKetQua;
    }


    public static int UCLN(int a, int b)
    {
        int c = 0;

        if(a < b)
        {
            c = b;
            b = a;
            a = c;
        }

        while (b != 0)
        {
            int temp = a % b;
            a = b;
            b = temp;
        }

        return a;
    }

    public static string DecimalToBinary(int n)
    {
        if (n == 0)
        {
            return "0";
        }

        string kq = "";

        while (n > 0)
        {
            int phanDu = n % 2;

            kq = phanDu + kq;

            n = n / 2;
        }

        return kq;
    }

    public static bool KiemTraNamNhuan(int year)
    {
        return (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
    }

    public static void EX06()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("--KIỂM TRA SỐ NGUYÊN TỐ--");

        Console.Write("Nhập vào số cần kiểm tra: ");
        int n = int.Parse(Console.ReadLine());

        if (KiemTraNguyenTo(n)) Console.WriteLine($"{n} là số nguyên tố");
        else Console.WriteLine($"{n} không phải là số nguyên tố");
    }

    public static void EX07()
    {
        Console.WriteLine("--IN DÃY FIBONACCI--");

        Console.Write("Nhập vào số nguyên n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"dãy fibo của {n} là");
        InFibonacci(n);
    }

    public static void EX08()
    {
        Console.WriteLine("--ĐẾM SỐ LƯỢNG NGUYÊN ÂM TRONG CHUỖI--");

        Console.Write("Nhập vào chuỗi cần đếm nguyên âm: ");
        string chuoi = Console.ReadLine();

        Console.WriteLine("Số lượng nguyên âm trong chuỗi là: " + DemNguyenAm(chuoi));
    }

    public static void EX09()
    {
        Console.WriteLine("--TÍNH LŨY THỪA--");

        Console.Write("x = ");
        int x = int.Parse(Console.ReadLine());

        Console.WriteLine();

        Console.Write("y = ");
        int y = int.Parse(Console.ReadLine());

        Console.WriteLine("result = " + TinhLuyThua(x,y));
    }

    public static void EX10()
    {
        Console.WriteLine("--TÍNH TRUNG BÌNH CỦA MẢNG--");

        Console.Write("Nhap vao do dai cua mang: ");
        int n = int.Parse(Console.ReadLine());

        int[] mang;
        mang = new int[n];

        nhapmang(mang);

        Console.WriteLine("Điểm trung bình của mảng là " + TinhTrungBinh(mang));
    }

    public static void EX11()
    {
        Console.WriteLine("--KIỂM TRA CHUỖI ĐỐI XỨNG--");

        Console.Write("Nhập vào chuỗi cần kiểm tra: ");
        string chuoi = Console.ReadLine();

        if(KiemTraDoiXung(chuoi) == true)
            Console.WriteLine("Chuỗi đối xứng");
        else
            Console.WriteLine("Chuỗi KHÔNG đối xứng");
    }

    public static void EX12()
    {
        Console.WriteLine("--CHUYỂN ĐỔI NHIỆT ĐỘ--");

        Console.Write("Nhập vào độ C: ");
        int c = int.Parse(Console.ReadLine());

        Console.WriteLine("Nhiệt độ theo thang nhiệt độ F là: " + CelsiusToFarenheit(c));
    }

    public static void EX13()
    {
        Console.WriteLine("--TÌM GIÁ TRỊ NHỎ NHẤT TRONG MẢNG--");

        Console.Write("Độ dài của mảng: ");
        int n = int.Parse(Console.ReadLine());

        int[] mang;
        mang = new int[n];

        nhapmang(mang);

        Console.WriteLine("giá trị nhỏ nhất trong mảng là: " + TimMin(mang));
    }

    public static void EX14()
    {
        Console.WriteLine("--TÍNH TỔNG CÁC CHỮ SỐ CỦA MỘT SỐ NGUYÊN--");

        Console.Write("Nhập vào số nguyên n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"Tổng các chữ số của {n} là: " + TongCacChuSo(n));
    }

    public static void EX15()
    {
        Console.WriteLine("--SẮP XẾP MẢNG TĂNG DẦN--");

        Console.Write("Độ dài mảng: ");
        int n = int.Parse(Console.ReadLine());

        int[] mang;
        mang = new int[n];

        nhapmang(mang);

        Console.WriteLine("Mảng sau khi sắp xếp: ");
        SapXepMang(mang);
    }

    public static void EX16()
    {
        Console.WriteLine("--XÓA KÝ TỰ TRÙNG LẶP--");

        Console.Write("Nhập vào chuỗi cần xóa ký tự: ");
        string s = Console.ReadLine();

        Console.WriteLine("Chuỗi sau khi xóa ký tự trùng lặp là: " + XoaTrungLap(s));
    }

    public static void EX17()
    {
        Console.WriteLine("---TÌM ƯỚC CHUNG LỚN NHẤT--");

        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Ước chung lớn nhất của a và b là: " + UCLN(a,b));
    }

    public static void EX18()
    {
        Console.WriteLine("--CHUYỂN ĐỔI HỆ THẬP PHÂN SANG HỆ NHỊ PHÂN--");

        Console.Write("Nhập vào số cần đổi: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Số đã đổi sang hệ nhị phân là : " + DecimalToBinary(n));
    }

    public static void EX19()
    {
        Console.WriteLine("--KIỂM TRA NĂM NHUẬN--");

        Console.Write("Nhập vào năm cần kiểm tra: ");
        int year = int.Parse(Console.ReadLine());

        if(KiemTraNamNhuan(year) == true)
            Console.WriteLine("Năm nhuận");
        else
            Console.WriteLine("Không phải năm nhuận");
    }
}