using System;
using System.Collections.Generic;
using System.Data;

class Program
{
    static void Main()
    {
        // Data Table Tagihan
        DataTable tagihanTable = new DataTable();
        tagihanTable.Columns.Add("No Tagihan", typeof(string));
        tagihanTable.Columns.Add("Due Date", typeof(DateTime));
        tagihanTable.Columns.Add("Total Tagihan", typeof(decimal));

        tagihanTable.Rows.Add("Tagihan#1", new DateTime(2023, 1, 10), 165000);
        tagihanTable.Rows.Add("Tagihan#3", new DateTime(2023, 1, 20), 130000);
        tagihanTable.Rows.Add("Tagihan#5", new DateTime(2023, 2, 10), 95500);
        tagihanTable.Rows.Add("Tagihan#2", new DateTime(2023, 2, 15), 80000);
        tagihanTable.Rows.Add("Tagihan#4", new DateTime(2023, 3, 30), 416000);

        // Data Table Pembayaran
        DataTable pembayaranTable = new DataTable();
        pembayaranTable.Columns.Add("No Payment", typeof(string));
        pembayaranTable.Columns.Add("No Tagihan", typeof(string));
        pembayaranTable.Columns.Add("Pmt Date", typeof(DateTime));
        pembayaranTable.Columns.Add("Pmt Amount", typeof(decimal));

        pembayaranTable.Rows.Add("Payment#1", "Tagihan#1", new DateTime(2023, 1, 10), 165000);
        pembayaranTable.Rows.Add("Payment#2", "Tagihan#3", new DateTime(2023, 2, 20), 130000);
        pembayaranTable.Rows.Add("Payment#2", "Tagihan#5", new DateTime(2023, 2, 20), 95500);
        pembayaranTable.Rows.Add("Payment#3", "Tagihan#2", new DateTime(2023, 2, 25), 30000);
        pembayaranTable.Rows.Add("Payment#4", "Tagihan#2", new DateTime(2023, 3, 30), 50000);
        pembayaranTable.Rows.Add("Payment#4", "Tagihan#4", new DateTime(2023, 3, 30), 50000);

        // Tanggal hari ini
        DateTime today = new DateTime(2023, 4, 29);

        // Membuat dataset hasil
        DataTable hasilTable = new DataTable();
        hasilTable.Columns.Add("No Tagihan", typeof(string));
        hasilTable.Columns.Add("No Penalty", typeof(int));
        hasilTable.Columns.Add("Tagihan Overdue", typeof(decimal));
        hasilTable.Columns.Add("Hari Keterlambatan", typeof(int));
        hasilTable.Columns.Add("Amount Penalty", typeof(decimal));

        var tagianMinPembyrn = 0;
        DateTime pmtDate;
        int hariKeterlambatan;
        string checkPenalty;

        List<string> addPenalty = new List<string>();
        List<string> tagihan = new List<string>();

        foreach (DataRow tagihanRow in tagihanTable.Rows)
        {
            string noTagihan = tagihanRow["No Tagihan"].ToString() ?? "";

            DateTime dueDate = Convert.ToDateTime(tagihanRow["Due Date"]);

            decimal totalTagihan = Convert.ToDecimal(tagihanRow["Total Tagihan"]);

            decimal totalPembayaran = 0;

            DateTime latestPaymentDate = DateTime.MinValue;
            
            foreach (DataRow pembayaranRow in pembayaranTable.Rows)
            {
                pmtDate = Convert.ToDateTime(pembayaranRow["Pmt Date"]);
                totalPembayaran = Convert.ToDecimal(pembayaranRow["Pmt Amount"]);
                if (noTagihan == pembayaranRow["No Tagihan"].ToString())
                {

                    var noFinalty = 1;
                    tagianMinPembyrn = (int)(Convert.ToDecimal(tagihanRow["Total Tagihan"]) - Convert.ToDecimal(pembayaranRow["Pmt Amount"]));
                    checkPenalty = addPenalty.Find(x => x == pembayaranRow["No Tagihan"].ToString());

                    if (!String.IsNullOrEmpty(checkPenalty)) noFinalty += 1;

                    if (dueDate == pmtDate)
                    {
                        totalPembayaran = totalTagihan - totalPembayaran;
                    }

                    hariKeterlambatan = (pmtDate - dueDate).Days;

                    decimal selisihTotal = totalTagihan - Convert.ToDecimal(pembayaranRow["Pmt Amount"]);

                    if (hariKeterlambatan == 0 && selisihTotal > 0)
                    {
                        hariKeterlambatan = int.Parse((dueDate.Day).ToString());
                    }

                    if (noFinalty > 1)
                    {
                        hariKeterlambatan = int.Parse((dueDate.Day).ToString());

                    }

                    decimal amountPenalty = totalPembayaran * 2m / 1000m * hariKeterlambatan;

                    addPenalty.Add(pembayaranRow["No Tagihan"].ToString());

                    hasilTable.Rows.Add(noTagihan, noFinalty, totalPembayaran, hariKeterlambatan, amountPenalty);

                }

            }

        }

        Console.WriteLine("No Tagihan\tNo Penalty\tTagihan Overdue\tHari Keterlambatan\tAmount Penalty");
        foreach (DataRow row in hasilTable.Rows)
        {
            Console.WriteLine($"{row["No Tagihan"],-12}\t{row["No Penalty"],-11}\t{row["Tagihan Overdue"],-15}\t{row["Hari Keterlambatan"],-19}\t{row["Amount Penalty"],-15}");
        }

    }
}
