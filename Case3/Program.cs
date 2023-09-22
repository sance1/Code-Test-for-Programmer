using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Masukkan array bilangan bulat misalnya : 1,2,3,4,5 (pisahkan dengan koma) = ");
            string? inputString = Console.ReadLine();
            int totalScore = 0;
            bool msg = false;
            string notValid = "";
            // Memisahkan input menjadi array bilangan bulat
            string[] inputArray = inputString.Split(',');
            int[] numbers = new int[inputArray.Length];

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (int.TryParse(inputArray[i], out int num))
                {
                    numbers[i] = num;
                    msg = true;
                }
                else
                {
                    notValid = "Input tidak valid.";
                    //return;
                }
            }

            totalScore = CalculateScore(numbers);
            if (!msg) {
                totalScore = 0;
                Console.WriteLine(notValid);
            }
            
            Console.WriteLine("Output : " + totalScore);

            Console.WriteLine("Exit : yes/no");
            string? exit = Console.ReadLine();

            if (exit?.ToLower() == "yes")
            {
                Console.WriteLine("Proses telah dihentikan.");
                break;
            }

        }
    }

    static int CalculateScore(int[] arr)
    {
        int score = 0;
        string? msg = null;
        foreach (int num in arr)
        {
            if (num % 2 == 0) // bilangan genap
            {
                score += 1;
            }
            else // bilangan ganjil
            {
                score += 3;
            }

            if (num == 8)
            {
                score += 5; // Mengakumulasi 5 poin untuk setiap angka 8
                msg = "Dengan kode ini, input 8,8 sesuai dengan " +
                    "aturan yang telah Anda tentukan, yaitu mengakumulasi 5 poin untuk setiap angka 8 mendapat nilai = 10 " +
                    "dan menambah dengan menambah 1 poin dengan bilangan genap mendapat nilai = 2 " +
                    "sedangkan di document anda menghasilkan nilai 10 nilai yang benar adalah ";
            }
        }

        if (!String.IsNullOrEmpty(msg)) Console.WriteLine(msg);
        return score;
    }


}
