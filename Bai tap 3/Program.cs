using System;

class Program
{
    static void Main()
    {
        Bai5();
    }

    static void Bai1()
    {
        // Nhập số a, b, c từ phương trình đề cho
        double a, b, c;
        double delta;
        double x1, x2;

        Console.Write("Nhập a: ");
        a = double.Parse(Console.ReadLine());

        Console.Write("Nhập b: ");
        b = double.Parse(Console.ReadLine());

        Console.Write("Nhập c: ");
        c = double.Parse(Console.ReadLine());

        // Trường hợp a = 0
        if (a == 0)
        {
            if (b == 0)
            {
                if (c == 0)
                {
                    Console.WriteLine("Phương trình có vô số nghiệm.");
                }
                else
                {
                    Console.WriteLine("Phương trình vô nghiệm.");
                }
            }
            else
            {
                double x = -c / b;
                Console.WriteLine("Phương trình có một nghiệm x = " + x);
            }
        }
        else
        {
            // Tính delta
            delta = b * b - 4 * a * c;

            if (delta < 0)
            {
                Console.WriteLine("Phương trình vô nghiệm.");
            }
            else if (delta == 0)
            {
                x1 = -b / (2 * a);
                Console.WriteLine("Phương trình có nghiệm kép x = " + x1);
            }
            else
            {
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                Console.WriteLine("Phương trình có hai nghiệm phân biệt:");
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);
            }
        }
    }

    static void Bai2()
    {
        int n;

        Console.Write("Nhập số nguyên n: ");
        n = int.Parse(Console.ReadLine());

        if (n % 2 == 0)
        {
            Console.WriteLine($"{n} là số chẵn.");
        }
        else
        {
            Console.WriteLine($"{n} là số lẻ.");
        }
    }

    static void Bai3()
    {
        double a, b, c;

        Console.Write("Nhập số thứ nhất: ");
        a = double.Parse(Console.ReadLine());

        Console.Write("Nhập số thứ hai: ");
        b = double.Parse(Console.ReadLine());

        Console.Write("Nhập số thứ ba: ");
        c = double.Parse(Console.ReadLine());

        if (a >= b && a >= c)
        {
            Console.WriteLine("Số lớn nhất là: " + a);
        }
        else if (b >= a && b >= c)
        {
            Console.WriteLine("Số lớn nhất là: " + b);
        }
        else
        {
            Console.WriteLine("Số lớn nhất là: " + c);
        }
    }

    static void Bai4()
    {
        // Nhập số đo 3 cạnh của tam giác
        double a, b, c;

        Console.Write("Nhập cạnh a: ");
        a = double.Parse(Console.ReadLine());

        Console.Write("Nhập cạnh b: ");
        b = double.Parse(Console.ReadLine());

        Console.Write("Nhập cạnh c: ");
        c = double.Parse(Console.ReadLine());

        // Kiểm tra xem có phải tam giác không
        if (a <= 0 || b <= 0 || c <= 0 ||
            a + b <= c || a + c <= b || b + c <= a)
        {
            Console.WriteLine("Không phải là tam giác.");
        }
        else
        {
            // Kiểm tra tam giác đều
            if (a == b && b == c)
            {
                Console.WriteLine("Đây là tam giác đều.");
            }
            // Kiểm tra tam giác cân
            else if (a == b || a == c || b == c)
            {
                Console.WriteLine("Đây là tam giác cân.");
            }
            // Kiểm tra tam giác thường
            else
            {
                Console.WriteLine("Đây là tam giác thường.");
            }
        }
    }

    static void Bai5()
    {
        // Nhập tọa độ điểm
        int x, y;

        Console.Write("Nhập X: ");
        x = int.Parse(Console.ReadLine());

        Console.Write("Nhập Y: ");
        y = int.Parse(Console.ReadLine());

        // Xác định điểm nằm ở góc phần tư nào
        if (x > 0 && y > 0)
        {
            Console.WriteLine("Điểm (" + x + "," + y + ") nằm ở góc phần tư thứ nhất.");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine("Điểm (" + x + "," + y + ") nằm ở góc phần tư thứ hai.");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("Điểm (" + x + "," + y + ") nằm ở góc phần tư thứ ba.");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine("Điểm (" + x + "," + y + ") nằm ở góc phần tư thứ tư.");
        }
        else
        {
            Console.WriteLine("Điểm nằm trên một trục.");
        }
    }
}