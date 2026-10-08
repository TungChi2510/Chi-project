using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Bai_15();

        Console.ReadKey();
    }

    // 1. Tạo một file rỗng
    static void Bai_1()
    {
        string path = "file1.txt";

        File.Create(path).Close();

        Console.WriteLine("Da tao file rong: " + path);
    }

    // 2. Xoa mot file
    static void Bai_2()
    {
        string path = "file2.txt";

        File.WriteAllText(path, "Noi dung cua file");

        if (File.Exists(path))
        {
            File.Delete(path);
            Console.WriteLine("Da xoa file: " + path);
        }
        else
        {
            Console.WriteLine("File khong ton tai.");
        }
    }

    // 3. Tao file va them mot so text
    static void Bai_3()
    {
        string path = "file3.txt";

        Console.Write("Nhap noi dung: ");
        string text = Console.ReadLine();

        File.WriteAllText(path, text);

        Console.WriteLine("Da ghi noi dung vao file.");
    }

    // 4. Tao file text va doc file
    static void Bai_4()
    {
        string path = "file4.txt";

        File.WriteAllText(path, "Xin chao C#");

        string content = File.ReadAllText(path);

        Console.WriteLine("Noi dung file:");
        Console.WriteLine(content);
    }

    // 5. Tao file va ghi mang chuoi vao file
    static void Bai_5()
    {
        string path = "file5.txt";

        string[] lines =
        {
            "Dong thu nhat",
            "Dong thu hai",
            "Dong thu ba"
        };

        File.WriteAllLines(path, lines);

        Console.WriteLine("Da ghi mang chuoi vao file.");
    }

    // 6. Them text vao file da ton tai
    static void Bai_6()
    {
        string path = "file6.txt";

        File.WriteAllText(path, "Noi dung ban dau.\n");

        File.AppendAllText(path, "Noi dung duoc them vao.");

        Console.WriteLine(File.ReadAllText(path));
    }

    // 7. Copy file sang ten khac va hien thi noi dung
    static void Bai_7()
    {
        string source = "file7.txt";
        string destination = "file7_copy.txt";

        File.WriteAllText(source, "Day la noi dung cua file.");

        File.Copy(source, destination, true);

        Console.WriteLine("Noi dung file copy:");
        Console.WriteLine(File.ReadAllText(destination));
    }

    // 8. Tao file va doi ten file trong cung thu muc
    static void Bai_8()
    {
        string source = "file8.txt";
        string destination = "file8_new.txt";

        File.WriteAllText(source, "Noi dung file 8.");

        if (File.Exists(destination))
        {
            File.Delete(destination);
        }

        File.Move(source, destination);

        Console.WriteLine("Da doi ten file.");
        Console.WriteLine("Ten moi: " + destination);
    }

    // 9. Doc dong dau tien cua file
    static void Bai_9()
    {
        string path = "file9.txt";

        string[] lines =
        {
            "Dong dau tien",
            "Dong thu hai",
            "Dong thu ba"
        };

        File.WriteAllLines(path, lines);

        string[] content = File.ReadAllLines(path);

        Console.WriteLine("Dong dau tien:");
        Console.WriteLine(content[0]);
    }

    // 10. Doc dong cuoi cung cua file
    static void Bai_10()
    {
        string path = "file10.txt";

        string[] lines =
        {
            "Dong 1",
            "Dong 2",
            "Dong 3",
            "Dong cuoi"
        };

        File.WriteAllLines(path, lines);

        string[] content = File.ReadAllLines(path);

        Console.WriteLine("Dong cuoi cung:");
        Console.WriteLine(content[content.Length - 1]);
    }

    // 11. Doc n dong cuoi cung cua file
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

        Console.Write("Nhap so dong cuoi cung can doc: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("So dong phai lon hon 0.");
            return;
        }

        if (n > lines.Length)
        {
            n = lines.Length;
        }

        Console.WriteLine("N dong cuoi:");

        for (int i = lines.Length - n; i < lines.Length; i++)
        {
            Console.WriteLine(lines[i]);
        }
    }

    // 12. Doc mot dong cu the
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

        Console.Write("Nhap so dong can doc: ");
        int lineNumber = Convert.ToInt32(Console.ReadLine());

        string[] content = File.ReadAllLines(path);

        if (lineNumber >= 1 && lineNumber <= content.Length)
        {
            Console.WriteLine("Noi dung dong " + lineNumber + ":");
            Console.WriteLine(content[lineNumber - 1]);
        }
        else
        {
            Console.WriteLine("So dong khong hop le.");
        }
    }

    // 13. Dem so dong trong file
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

    // 14. In cau truc cua thu muc, bao gom ca file
    static void Bai_14()
    {
        Console.Write("Nhap duong dan thu muc: ");
        string folderPath = Console.ReadLine();

        if (!Directory.Exists(folderPath))
        {
            Console.WriteLine("Thu muc khong ton tai.");
            return;
        }

        Console.WriteLine("\nCau truc thu muc:");
        PrintFolder(folderPath, 0);
    }

    static void PrintFolder(string folderPath, int level)
    {
        string[] files = Directory.GetFiles(folderPath);

        foreach (string file in files)
        {
            Console.WriteLine(new string(' ', level * 2) + "- " + Path.GetFileName(file));
        }

        string[] folders = Directory.GetDirectories(folderPath);

        foreach (string folder in folders)
        {
            Console.WriteLine(new string(' ', level * 2) + "+ " + Path.GetFileName(folder));

            PrintFolder(folder, level + 1);
        }
    }

    // 15. Doc file va thong ke chu cai, chu so
    static void Bai_15()
    {
        string path = "file15.txt";

        Console.Write("Nhap noi dung: ");
        string text = Console.ReadLine();

        File.WriteAllText(path, text);

        string content = File.ReadAllText(path);

        // Mang chu nhat:
        // Hang 0: chu cai A-Z
        // Hang 1: chu so 0-9
        int[,] count = new int[2, 26];

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
                count[1, c - '0']++;
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
            if (count[1, i] > 0)
            {
                Console.WriteLine(i + ": " + count[1, i]);
            }
        }

        Console.WriteLine("\nDa luu noi dung vao file: " + path);
    }
}