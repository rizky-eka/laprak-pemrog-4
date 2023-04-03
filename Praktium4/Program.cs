using System;
using Praktium4;

namespace Praktium4
{
    internal class Program
    {
        static void Main(String[] args)
        {
            mobil mobill = new mobil();


            mobill.warna = "silver";
            mobill.jumlah_pintu = 2;
            mobill.merek = "Avanza";
            mobill.model = "MPV";
            mobill.tahun_keluaran = 2019;

            mobill.Gas(300);
            mobill.klakson("Klakson udara");
            mobill.TampilkanInfo();
        }
    }
}
