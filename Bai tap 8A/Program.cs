using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Bai_15();

        Console.ReadKey();
    }

    // Bài 1: Tạo một file rỗng
    static void Bai_1()
    {
        string path = "file1.txt";

        File.Create(path).Close();

        Console.WriteLine("Da tao file rong: " + path);
    }

    // Bài 2: Xóa một file
    static void Bai_2()
    {
        string path = "file1.txt";

        if (File.Exists(path))
        {
            File.Delete(path);
            Console.WriteLine("Da xoa file!");
        }
        else
        {
            Console.WriteLine("File khong ton tai!");
        }
    }

    // Bài 3: Tạo file và ghi text
    static void Bai_3()
    {
        string path = "file3.txt";

        File.WriteAllText(path, "Xin chao! Day la noi dung cua file.");

        Console.WriteLine("Da tao file va ghi text.");
    }

    // Bài 4: Tạo file text và đọc file
    static void Bai_4()
    {
        string path = "file4.txt";

        File.WriteAllText(path, "Xin chao C#!");

        string content = File.ReadAllText(path);

        Console.WriteLine("Noi dung file:");
        Console.WriteLine(content);
    }

    // Bài 5: Ghi một mảng chuỗi vào file
    static void Bai_5()
    {
        string path = "file5.txt";

        string[] lines =
        {
            "Dong thu nhat",
            "Dong thu hai",
            "Dong thu ba",
            "Dong thu tu"
        };

        File.WriteAllLines(path, lines);

        Console.WriteLine("Da ghi mang chuoi vao file.");
    }

    // Bài 6: Thêm text vào file đã tồn tại
    static void Bai_6()
    {
        string path = "file6.txt";

        File.WriteAllText(path, "Noi dung ban dau.\n");

        File.AppendAllText(path, "Noi dung duoc them vao.");

        Console.WriteLine("Noi dung file:");
        Console.WriteLine(File.ReadAllText(path));
    }

    // Bài 7: Copy file sang tên khác và hiển thị nội dung
    static void Bai_7()
    {
        string source = "file7.txt";
        string destination = "file7_copy.txt";

        File.WriteAllText(source, "Day la noi dung cua file goc.");

        File.Copy(source, destination, true);

        Console.WriteLine("Noi dung file copy:");
        Console.WriteLine(File.ReadAllText(destination));
    }

    // Bài 8: Move file sang tên khác trong cùng thư mục
    static void Bai_8()
    {
        string source = "file8.txt";
        string destination = "file8_new.txt";

        File.WriteAllText(source, "Day la file can move.");

        File.Move(source, destination);

        Console.WriteLine("Da move file thanh: " + destination);
    }

    // Bài 9: Đọc dòng đầu tiên của file
    static void Bai_9()
    {
        string path = "file9.txt";

        string[] lines =
        {
            "Day la dong dau tien.",
            "Day la dong thu hai.",
            "Day la dong thu ba."
        };

        File.WriteAllLines(path, lines);

        string[] content = File.ReadAllLines(path);

        Console.WriteLine("Dong dau tien:");
        Console.WriteLine(content[0]);
    }

    // Bài 10: Đọc dòng cuối cùng của file
    static void Bai_10()
    {
        string path = "file10.txt";

        string[] lines =
        {
            "Dong 1",
            "Dong 2",
            "Dong 3",
            "Dong cuoi cung"
        };

        File.WriteAllLines(path, lines);

        string[] content = File.ReadAllLines(path);

        Console.WriteLine("Dong cuoi cung:");
        Console.WriteLine(content[content.Length - 1]);
    }

    // Bài 11: Đọc n dòng cuối cùng
    static void Bai_11()
    {
        string path = "file11.txt";

        string[] lines =
        {
            "Dong 1",
            "Dong 2",
            "Dong 3",
            "Dong 4",
            "Dong 5"
        };

        File.WriteAllLines(path, lines);

        Console.Write("Nhap n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        string[] content = File.ReadAllLines(path);

        if (n > content.Length)
        {
            n = content.Length;
        }

        if (n <= 0)
        {
            Console.WriteLine("n phai lon hon 0!");
            return;
        }

        Console.WriteLine("N dong cuoi:");

        for (int i = content.Length - n; i < content.Length; i++)
        {
            Console.WriteLine(content[i]);
        }
    }

    // Bài 12: Đọc một dòng cụ thể
    static void Bai_12()
    {
        string path = "file12.txt";

        string[] lines =
        {
            "Dong 1",
            "Dong 2",
            "Dong 3",
            "Dong 4",
            "Dong 5"
        };

        File.WriteAllLines(path, lines);

        Console.Write("Nhap so dong muon doc: ");
        int lineNumber = Convert.ToInt32(Console.ReadLine());

        string[] content = File.ReadAllLines(path);

        if (lineNumber >= 1 && lineNumber <= content.Length)
        {
            Console.WriteLine("Noi dung dong " + lineNumber + ":");
            Console.WriteLine(content[lineNumber - 1]);
        }
        else
        {
            Console.WriteLine("So dong khong hop le!");
        }
    }

    // Bài 13: Đếm số dòng trong file
    static void Bai_13()
    {
        string path = "file13.txt";

        string[] lines =
        {
            "Dong 1",
            "Dong 2",
            "Dong 3",
            "Dong 4"
        };

        File.WriteAllLines(path, lines);

        string[] content = File.ReadAllLines(path);

        Console.WriteLine("So dong trong file: " + content.Length);
    }

    // Bài 14: In cấu trúc folder, bao gồm cả file
    static void Bai_14()
    {
        Console.Write("Nhap duong dan folder: ");
        string folderPath = Console.ReadLine();

        if (!Directory.Exists(folderPath))
        {
            Console.WriteLine("Folder khong ton tai!");
            return;
        }

        Console.WriteLine("\nCau truc folder:");

        PrintFolder(folderPath, 0);
    }

    static void PrintFolder(string folderPath, int level)
    {
        string indent = "";

        for (int i = 0; i < level; i++)
        {
            indent += "    ";
        }

        Console.WriteLine(indent + "[Folder] " + Path.GetFileName(folderPath));

        string[] files = Directory.GetFiles(folderPath);

        foreach (string file in files)
        {
            Console.WriteLine(indent + "    [File] " + Path.GetFileName(file));
        }

        string[] folders = Directory.GetDirectories(folderPath);

        foreach (string folder in folders)
        {
            PrintFolder(folder, level + 1);
        }
    }

    // Bài 15: Nhập nội dung, ghi vào file và thống kê chữ cái, chữ số
static void Bai_15()
{
    string path = "file15.txt";

    Console.Write("Nhap noi dung: ");
    string text = Console.ReadLine();

    File.WriteAllText(path, text);

    string content = File.ReadAllText(path);

    int[,] count = new int[1, 26];
    int[] digitCount = new int[10];

    for (int i = 0; i < content.Length; i++)
    {
        char c = content[i];

        if (c >= 'a' && c <= 'z')
        {
            count[0, c - 'a']++;
        }
        else if (c >= 'A' && c <= 'Z')
        {
            count[0, c - 'A']++;
        }
        else if (c >= '0' && c <= '9')
        {
            digitCount[c - '0']++;
        }
    }

    Console.WriteLine("\nTHONG KE CHU CAI:");

    for (int i = 0; i < 26; i++)
    {
        if (count[0, i] > 0)
        {
            char c = (char)('A' + i);

            Console.WriteLine(c + ": " + count[0, i]);
        }
    }

    Console.WriteLine("\nTHONG KE CHU SO:");

    for (int i = 0; i < 10; i++)
    {
        if (digitCount[i] > 0)
        {
            Console.WriteLine(i + ": " + digitCount[i]);
        }
    }

    Console.WriteLine("\nDa luu noi dung vao file: " + path);
}
}