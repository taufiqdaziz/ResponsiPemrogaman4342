using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace responsi4342
{
    class Program
    {
        static void Main(string[] args)
        {
            karyawan Karyawan = new karyawan();


            Console.WriteLine("Nik = ") ; Karyawan.nik = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nama = "); Karyawan.nama = Console.ReadLine();
            Console.WriteLine("jumlah gaji = ") ; Karyawan.gaji = Convert.ToInt32(Console.ReadLine());

            Karyawan.Nama();
            Karyawan.Nik();
            Karyawan.GajiBulanan();

            Console.WriteLine("naik gaji 10%");

            Karyawan.Nama();
            Karyawan.Nik();
            Karyawan.GajiBulananNaik();

            Console.ReadKey();
        }
    }
}
