using System;

class Program
{
    static void Main()
    {
        while (true) {

            Console.WriteLine("Pilih pola A,B,C,D");
            var type = Console.ReadLine()?.ToLower();
            
            switch (type) {
                case "a" :
                    A();
                    break;
                case "b" :
                    B();
                    break;
                case "c" :
                    C();
                    break;
                case "d" :
                    D();
                    break;
                default:
                    Console.WriteLine("Type tidak ditemukan");
                    break;
            }

            Console.WriteLine("Exit : yes/no");
            var ext = Console.ReadLine()?.ToLower();
            if (ext == "yes") {
                Console.WriteLine("Proses telah dihentikan.");
                break;
            }
        }
        
    }
    public static void A()
    {
        Console.Write("Masukkan nilai n: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }

    }

    public static void B()
    {
        Console.Write("Masukkan nilai n: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            for (int j = i; j >= 1; j--)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }

    }
    public static void C()
    {
        Console.Write("Masukkan nilai n: ");
        int n = int.Parse(Console.ReadLine());

        int currentNumber = 1;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(currentNumber);
            currentNumber = GenerateNextNumber(currentNumber);
        }
    }

    public static void D()
    {
        Console.Write("Masukkan nilai n: ");
        int n = int.Parse(Console.ReadLine());

        int[][] matrix = new int[n][];
        int current = 1;

        // Inisialisasi matriks
        for (int i = 0; i < n; i++)
        {
            matrix[i] = new int[n];
        }

        // Mengisi matriks sesuai pola yang diinginkan
        for (int i = 0; i < n; i++)
        {
            if (i % 2 == 0)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[j][i] = current++;
                }
            }
            else
            {
                for (int j = n - 1; j >= 0; j--)
                {
                    matrix[j][i] = current++;
                }
            }
        }

        // Menampilkan matriks hasil
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i][j].ToString().PadLeft(2) + " ");
            }
            Console.WriteLine();
        }
    }

    public static int GenerateNextNumber(int currentNumber)
    {
        if (currentNumber == 1)
        {
            return 23;
        }
        else if (currentNumber == 23)
        {
            return 454;
        }
        else if (currentNumber == 454)
        {
            return 3212;
        }
        else if (currentNumber == 3212)
        {
            return 34543;
        }
        else
        {
            return 0; 
        }
    }

}
