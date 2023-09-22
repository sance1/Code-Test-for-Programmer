using System;
using System.Collections.Generic;

public class Tagihan
{
    public string? NomorTagihan { get; set; }
    public DateTime DueDate { get; set; }
    public decimal JumlahTagihan { get; set; }
    public decimal JumlahDibayar { get; set; }
}

public class Program
{
    public static void Main()
    {
        List<Tagihan> daftarTagihan = new List<Tagihan>
        {
            new Tagihan { NomorTagihan = "Tagihan#1", DueDate = new DateTime(2023, 1, 10), JumlahTagihan = 165000 },
            new Tagihan { NomorTagihan = "Tagihan#2", DueDate = new DateTime(2023, 2, 15), JumlahTagihan = 80000 },
            new Tagihan { NomorTagihan = "Tagihan#3", DueDate = new DateTime(2023, 1, 20), JumlahTagihan = 130000 },
            new Tagihan { NomorTagihan = "Tagihan#4", DueDate = new DateTime(2023, 3, 25), JumlahTagihan = 416000 },
            new Tagihan { NomorTagihan = "Tagihan#5", DueDate = new DateTime(2023, 2, 10), JumlahTagihan = 95500 },
            new Tagihan { NomorTagihan = "Tagihan#6", DueDate = new DateTime(2023, 8, 17), JumlahTagihan = 523000 }
        };

        Console.Write("Input Payment = ");
        decimal payment;

        if (decimal.TryParse(Console.ReadLine(), out payment))
        {
            if (payment < 0)
            {
                Console.WriteLine("Payment tidak boleh kurang dari 0.");
                return;
            }

            AlokasiPembayaran(daftarTagihan, payment);

            Console.WriteLine("Hasil Alokasi Pembayaran:");
            foreach (var tagihan in daftarTagihan)
            {
                Console.WriteLine($"{tagihan.NomorTagihan}\tDue: {tagihan.DueDate:dd MMM yy}\t{tagihan.JumlahTagihan:C}\t{tagihan.JumlahDibayar:C}");
            }
        }
        else
        {
            Console.WriteLine("Input tidak valid. Masukkan jumlah pembayaran yang valid.");
        }
    }

    public static void AlokasiPembayaran(List<Tagihan> tagihanList, decimal payment)
    {
        tagihanList.Sort((t1, t2) => t1.DueDate.CompareTo(t2.DueDate));

        foreach (var tagihan in tagihanList)
        {
            if (payment > 0)
            {
                if (payment >= tagihan.JumlahTagihan)
                {
                    tagihan.JumlahDibayar = tagihan.JumlahTagihan;
                    payment -= tagihan.JumlahTagihan;
                }
                else
                {
                    tagihan.JumlahDibayar = payment;
                    payment = 0;
                }
            }
            else
            {
                tagihan.JumlahDibayar = 0;
            }
        }
    }
}



