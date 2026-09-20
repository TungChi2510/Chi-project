using System;

class Program
{
    static void Main()
    {
        Bai1();
    }

    // Bài 1: Tính tổng hai số nguyên
    static void Bai1()
    {
        int a = 10;
        int b = 20;

        int ketQua = TinhTong(a, b);

        Console.WriteLine("Bài 1: Tổng = {0}", ketQua);
    }

    static int TinhTong(int a, int b)
    {
        return a + b;
    }


    // Bài 2: Kiểm tra số chẵn lẻ
    static void Bai2()
    {
        int n = 8;

        bool ketQua = KiemTraChan(n);

        if (ketQua == true)
        {
            Console.WriteLine("Bài 2: {0} là số chẵn", n);
        }
        else
        {
            Console.WriteLine("Bài 2: {0} là số lẻ", n);
        }
    }

    static bool KiemTraChan(int n)
    {
        return n % 2 == 0;
    }


    // Bài 3: Tìm số lớn nhất trong ba số
    static void Bai3()
    {
        int a = 15;
        int b = 25;
        int c = 10;

        int ketQua = TimMax(a, b, c);

        Console.WriteLine("Bài 3: Số lớn nhất = {0}", ketQua);
    }

    static int TimMax(int a, int b, int c)
    {
        if (a >= b && a >= c)
        {
            return a;
        }
        else if (b >= a && b >= c)
        {
            return b;
        }
        else
        {
            return c;
        }
    }


    // Bài 4: Tính giai thừa
    static void Bai4()
    {
        int n = 5;

        long ketQua = TinhGiaiThua(n);

        Console.WriteLine("Bài 4: {0}! = {1}", n, ketQua);
    }

    static long TinhGiaiThua(int n)
    {
        long ketQua = 1;

        for (int i = 1; i <= n; i++)
        {
            ketQua = ketQua * i;
        }

        return ketQua;
    }


    // Bài 5: Đảo ngược chuỗi
    static void Bai5()
    {
        string input = "Hello World";

        string ketQua = DaoNguocChuoi(input);

        Console.WriteLine("Bài 5: {0}", ketQua);
    }

    static string DaoNguocChuoi(string input)
    {
        char[] mangKyTu = input.ToCharArray();

        Array.Reverse(mangKyTu);

        return new string(mangKyTu);
    }


    // Bài 6: Kiểm tra số nguyên tố
    static void Bai6()
    {
        int n = 7;

        bool ketQua = KiemTraNguyenTo(n);

        Console.WriteLine("Bài 6: {0}", ketQua);
    }

    static bool KiemTraNguyenTo(int n)
    {
        if (n < 2)
        {
            return false;
        }

        for (int i = 2; i < n; i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }

        return true;
    }


    // Bài 7: In dãy Fibonacci
    static void Bai7()
    {
        int n = 6;

        Console.Write("Bài 7: ");
        InFibonacci(n);
    }

    static void InFibonacci(int n)
    {
        int a = 0;
        int b = 1;

        for (int i = 0; i < n; i++)
        {
            Console.Write(a + " ");

            int c = a + b;
            a = b;
            b = c;
        }

        Console.WriteLine();
    }


    // Bài 8: Đếm số lượng nguyên âm trong chuỗi
    static void Bai8()
    {
        string s = "Hello World";

        int ketQua = DemNguyenAm(s);

        Console.WriteLine("Bài 8: Số lượng nguyên âm = {0}", ketQua);
    }

    static int DemNguyenAm(string s)
    {
        int dem = 0;

        for (int i = 0; i < s.Length; i++)
        {
            char kyTu = char.ToLower(s[i]);

            if (kyTu == 'a' || kyTu == 'e' || kyTu == 'i' ||
                kyTu == 'o' || kyTu == 'u')
            {
                dem++;
            }
        }

        return dem;
    }


    // Bài 9: Tính lũy thừa
    static void Bai9()
    {
        double x = 2;
        int y = 3;

        double ketQua = TinhLuyThua(x, y);

        Console.WriteLine("Bài 9: {0}^{1} = {2}", x, y, ketQua);
    }

    static double TinhLuyThua(double x, int y)
    {
        double ketQua = 1;

        for (int i = 1; i <= y; i++)
        {
            ketQua = ketQua * x;
        }

        return ketQua;
    }


    // Bài 10: Tính điểm trung bình của mảng
    static void Bai10()
    {
        int[] arr = { 4, 5, 6, 7 };

        double ketQua = TinhTrungBinh(arr);

        Console.WriteLine("Bài 10: Trung bình = {0}", ketQua);
    }

    static double TinhTrungBinh(int[] arr)
    {
        int tong = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            tong = tong + arr[i];
        }

        return (double)tong / arr.Length;
    }


    // Bài 11: Kiểm tra chuỗi đối xứng
    static void Bai11()
    {
        string s = "radar";

        bool ketQua = KiemTraDoiXung(s);

        Console.WriteLine("Bài 11: {0}", ketQua);
    }

    static bool KiemTraDoiXung(string s)
    {
        for (int i = 0; i < s.Length / 2; i++)
        {
            if (s[i] != s[s.Length - 1 - i])
            {
                return false;
            }
        }

        return true;
    }


    // Bài 12: Chuyển đổi nhiệt độ
    static void Bai12()
    {
        double c = 25;

        double ketQua = CelsiusToFahrenheit(c);

        Console.WriteLine("Bài 12: {0} độ C = {1} độ F", c, ketQua);
    }

    static double CelsiusToFahrenheit(double c)
    {
        return c * 9 / 5 + 32;
    }


    // Bài 13: Tìm giá trị nhỏ nhất trong mảng
    static void Bai13()
    {
        int[] arr = { 10, 5, 8, 2, 9 };

        int ketQua = TimMin(arr);

        Console.WriteLine("Bài 13: Giá trị nhỏ nhất = {0}", ketQua);
    }

    static int TimMin(int[] arr)
    {
        int min = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }

        return min;
    }


    // Bài 14: Tính tổng các chữ số
    static void Bai14()
    {
        int n = 1234;

        int ketQua = TongCacChuSo(n);

        Console.WriteLine("Bài 14: Tổng các chữ số = {0}", ketQua);
    }

    static int TongCacChuSo(int n)
    {
        int tong = 0;

        while (n > 0)
        {
            tong = tong + n % 10;
            n = n / 10;
        }

        return tong;
    }


    // Bài 15: Sắp xếp mảng tăng dần
    static void Bai15()
    {
        int[] arr = { 3, 1, 4, 2 };

        Console.Write("Bài 15: ");
        SapXepMang(arr);
    }

    static void SapXepMang(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] > arr[j])
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }

        Console.WriteLine();
    }


    // Bài 16: Xóa ký tự trùng lặp
    static void Bai16()
    {
        string s = "programming";

        string ketQua = XoaTrungLap(s);

        Console.WriteLine("Bài 16: {0}", ketQua);
    }

    static string XoaTrungLap(string s)
    {
        string ketQua = "";

        for (int i = 0; i < s.Length; i++)
        {
            bool daTonTai = false;

            for (int j = 0; j < ketQua.Length; j++)
            {
                if (s[i] == ketQua[j])
                {
                    daTonTai = true;
                    break;
                }
            }

            if (daTonTai == false)
            {
                ketQua = ketQua + s[i];
            }
        }

        return ketQua;
    }


    // Bài 17: Tìm UCLN
    static void Bai17()
    {
        int a = 12;
        int b = 18;

        int ketQua = UCLN(a, b);

        Console.WriteLine("Bài 17: UCLN = {0}", ketQua);
    }

    static int UCLN(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }

        return a;
    }


    // Bài 18: Chuyển đổi thập phân sang nhị phân
    static void Bai18()
    {
        int n = 10;

        string ketQua = DecimalToBinary(n);

        Console.WriteLine("Bài 18: {0}", ketQua);
    }

    static string DecimalToBinary(int n)
    {
        if (n == 0)
        {
            return "0";
        }

        string ketQua = "";

        while (n > 0)
        {
            int phanDu = n % 2;
            ketQua = phanDu + ketQua;
            n = n / 2;
        }

        return ketQua;
    }


    // Bài 19: Kiểm tra năm nhuận
    static void Bai19()
    {
        int year = 2024;

        bool ketQua = KiemTraNamNhuan(year);

        Console.WriteLine("Bài 19: {0}", ketQua);
    }

    static bool KiemTraNamNhuan(int year)
    {
        if (year % 400 == 0)
        {
            return true;
        }
        else if (year % 100 == 0)
        {
            return false;
        }
        else if (year % 4 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    // Bài 20: Đếm số từ trong câu
    static void Bai20()
    {
        string sentence = "Học lập trình C# rất thú vị";

        int ketQua = DemSoTu(sentence);

        Console.WriteLine("Bài 20: Số từ = {0}", ketQua);
    }

    static int DemSoTu(string sentence)
    {
        string[] cacTu = sentence.Split(
            new char[] { ' ' },
            StringSplitOptions.RemoveEmptyEntries
        );

        return cacTu.Length;
    }
}