using System;

class Program
{
    static void Main(string[] args)
    {
        // Gọi từng bài ở đây để chạy
        Bai1();
    }

    // 1. Input a string and print it
    static void Bai1()
    {
        Console.Write("Nhap chuoi: ");
        string s = Console.ReadLine();

        Console.WriteLine("Chuoi vua nhap: " + s);
    }

    // 2. Find the length of a string without using a library function
    static void Bai2()
    {
        Console.Write("Nhap chuoi: ");
        string s = Console.ReadLine();

        int length = 0;

        foreach (char c in s)
        {
            length++;
        }

        Console.WriteLine("Do dai cua chuoi: " + length);
    }

    // 3. Separate individual characters from a string
    static void Bai3()
    {
        Console.Write("Nhap chuoi: ");
        string s = Console.ReadLine();

        Console.WriteLine("Cac ky tu trong chuoi:");

        for (int i = 0; i < s.Length; i++)
        {
            Console.WriteLine(s[i]);
        }
    }

    // 4. Print individual characters of the string in reverse order
    static void Bai4()
    {
        Console.Write("Nhap chuoi: ");
        string s = Console.ReadLine();

        Console.WriteLine("Chuoi theo thu tu nguoc:");

        for (int i = s.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(s[i]);
        }
    }

    // 5. Count the total number of words in a string
    static void Bai5()
    {
        Console.Write("Nhap chuoi: ");
        string s = Console.ReadLine();

        int count = 0;
        bool insideWord = false;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != ' ' && s[i] != '\t')
            {
                if (!insideWord)
                {
                    count++;
                    insideWord = true;
                }
            }
            else
            {
                insideWord = false;
            }
        }

        Console.WriteLine("So tu trong chuoi: " + count);
    }

    // 6. Compare two strings without using string library functions
    static void Bai6()
    {
        Console.Write("Nhap chuoi thu nhat: ");
        string s1 = Console.ReadLine();

        Console.Write("Nhap chuoi thu hai: ");
        string s2 = Console.ReadLine();

        bool same = true;

        // Kiem tra do dai
        if (s1.Length != s2.Length)
        {
            same = false;
        }
        else
        {
            // Kiem tra tung ky tu
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != s2[i])
                {
                    same = false;
                    break;
                }
            }
        }

        if (same)
            Console.WriteLine("Hai chuoi giong nhau.");
        else
            Console.WriteLine("Hai chuoi khac nhau.");
    }

    // 7. Count alphabets, digits and special characters
    static void Bai7()
    {
        Console.Write("Nhap chuoi: ");
        string s = Console.ReadLine();

        int alphabet = 0;
        int digit = 0;
        int special = 0;

        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];

            if ((c >= 'a' && c <= 'z') ||
                (c >= 'A' && c <= 'Z'))
            {
                alphabet++;
            }
            else if (c >= '0' && c <= '9')
            {
                digit++;
            }
            else
            {
                special++;
            }
        }

        Console.WriteLine("So chu cai: " + alphabet);
        Console.WriteLine("So chu so: " + digit);
        Console.WriteLine("So ky tu dac biet: " + special);
    }

    // 8. Count vowels and consonants
    static void Bai8()
    {
        Console.Write("Nhap chuoi: ");
        string s = Console.ReadLine();

        int vowels = 0;
        int consonants = 0;

        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];

            // Dua chu hoa ve chu thuong bang cach tu kiem tra
            if (c >= 'A' && c <= 'Z')
            {
                c = (char)(c + 32);
            }

            if (c >= 'a' && c <= 'z')
            {
                if (c == 'a' || c == 'e' || c == 'i' ||
                    c == 'o' || c == 'u')
                {
                    vowels++;
                }
                else
                {
                    consonants++;
                }
            }
        }

        Console.WriteLine("So nguyen am: " + vowels);
        Console.WriteLine("So phu am: " + consonants);
    }

    // 9. Check whether a substring is present in a string
    static void Bai9()
    {
        Console.Write("Nhap chuoi: ");
        string s = Console.ReadLine();

        Console.Write("Nhap chuoi con can tim: ");
        string sub = Console.ReadLine();

        bool found = false;

        for (int i = 0; i <= s.Length - sub.Length; i++)
        {
            bool same = true;

            for (int j = 0; j < sub.Length; j++)
            {
                if (s[i + j] != sub[j])
                {
                    same = false;
                    break;
                }
            }

            if (same)
            {
                found = true;
                break;
            }
        }

        if (found)
            Console.WriteLine("Chuoi con co trong chuoi.");
        else
            Console.WriteLine("Chuoi con khong co trong chuoi.");
    }

    // 10. Search for the position of a substring
    static void Bai10()
    {
        Console.Write("Nhap chuoi: ");
        string s = Console.ReadLine();

        Console.Write("Nhap chuoi con can tim: ");
        string sub = Console.ReadLine();

        int position = -1;

        for (int i = 0; i <= s.Length - sub.Length; i++)
        {
            bool same = true;

            for (int j = 0; j < sub.Length; j++)
            {
                if (s[i + j] != sub[j])
                {
                    same = false;
                    break;
                }
            }

            if (same)
            {
                position = i;
                break;
            }
        }

        if (position != -1)
            Console.WriteLine("Vi tri dau tien cua chuoi con: " + position);
        else
            Console.WriteLine("Khong tim thay chuoi con.");
    }

    // 11. Check whether a character is an alphabet
    // and check its case
    static void Bai11()
    {
        Console.Write("Nhap mot ky tu: ");
        char c = Console.ReadKey().KeyChar;

        Console.WriteLine();

        if (c >= 'A' && c <= 'Z')
        {
            Console.WriteLine("Day la chu cai.");
            Console.WriteLine("Day la chu hoa.");
        }
        else if (c >= 'a' && c <= 'z')
        {
            Console.WriteLine("Day la chu cai.");
            Console.WriteLine("Day la chu thuong.");
        }
        else
        {
            Console.WriteLine("Day khong phai la chu cai.");
        }
    }

    // 12. Find the number of times a substring appears
    static void Bai12()
    {
        Console.Write("Nhap chuoi: ");
        string s = Console.ReadLine();

        Console.Write("Nhap chuoi con can tim: ");
        string sub = Console.ReadLine();

        int count = 0;

        for (int i = 0; i <= s.Length - sub.Length; i++)
        {
            bool same = true;

            for (int j = 0; j < sub.Length; j++)
            {
                if (s[i + j] != sub[j])
                {
                    same = false;
                    break;
                }
            }

            if (same)
            {
                count++;

                // Khong cho phep cac lan xuat hien bi chong len nhau
                i = i + sub.Length - 1;
            }
        }

        Console.WriteLine("So lan chuoi con xuat hien: " + count);
    }

    // 13. Insert a substring before the first occurrence of a string
    static void Bai13()
    {
        Console.Write("Nhap chuoi: ");
        string s = Console.ReadLine();

        Console.Write("Nhap chuoi can tim: ");
        string target = Console.ReadLine();

        Console.Write("Nhap chuoi muon chen: ");
        string insert = Console.ReadLine();

        int position = -1;

        // Tim vi tri xuat hien dau tien cua target
        for (int i = 0; i <= s.Length - target.Length; i++)
        {
            bool same = true;

            for (int j = 0; j < target.Length; j++)
            {
                if (s[i + j] != target[j])
                {
                    same = false;
                    break;
                }
            }

            if (same)
            {
                position = i;
                break;
            }
        }

        if (position == -1)
        {
            Console.WriteLine("Khong tim thay chuoi can tim.");
        }
        else
        {
            string result = "";

            // Phan truoc chuoi target
            for (int i = 0; i < position; i++)
            {
                result += s[i];
            }

            // Chen chuoi moi
            result += insert;

            // Phan con lai cua chuoi ban dau
            for (int i = position; i < s.Length; i++)
            {
                result += s[i];
            }

            Console.WriteLine("Chuoi sau khi chen: " + result);
        }
    }
}