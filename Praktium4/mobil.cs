using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    
namespace Praktium4
{
	internal class mobil
	{
        // Field
        private string _warna { get; set; }
        private int _jumlah_pintu { get; set; }
        private string _merek { get; set; }
        private string _model { get; set; }
        private int _tahun_keluaran { get; set; }

        // properties
        public string warna
        {
            get
            {
                return _warna;
            }
            set
            {
                _warna = value;
            }
        }
        public int jumlah_pintu
        {
            get
            {
                return _jumlah_pintu;
            }
            set
            {
                jumlah_pintu = value;
            }
        }
        public string merek
        {
            get
            {
                return _merek;
            }
            set
            {
                _merek = value;
            }
        }
        public string model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
            }
        }
        public int tahun_keluaran
        {
            get
            {
                return _tahun_keluaran;

            }
            set
            {
                _tahun_keluaran = value;
            }
        }
        // method
        public void Gas(int kecepatan)
        {
            Console.WriteLine("Mobil {0} berjalan dengan kecepatan {1} km/jam", model, kecepatan);
            Console.ReadKey();
        }
        public void klakson(string suara)
        {
            Console.WriteLine("0", suara);
            Console.ReadKey();
        }
        public void TampilkanInfo()
        {
            Console.WriteLine("Mobil saya berwarna {0}, merek {1}, model {2} keluaran tahun {3) dengan jumlah pintu sebanyak {4}", warna, merek, model, tahun_keluaran, jumlah_pintu);
            Console.ReadKey();
        }
    }

}
}

