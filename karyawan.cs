using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace responsi4342
{
    class karyawan
    {
        public int nik { get; set; }
        public string nama { get; set; }
        public double gaji { get; set; }

        public void Nik()
        {
            Console.WriteLine("NIK = {0}", Convert.ToInt32(nik));
        }

        public void Nama()
        {
            Console.WriteLine("Nama = {0}", nama);
        }

        public void GajiBulanan()
        {
            if(gaji <= 0)
            {
                gaji = 0;
                Console.WriteLine("Gaji = {0}", Convert.ToInt32(gaji));
            }
            else
            {
                Console.WriteLine("Gaji = {0}", Convert.ToInt32(gaji));
            }
            
        }

        public void GajiBulananNaik()
        {
            gaji = (gaji * 0.1) + gaji;
            Console.WriteLine("Gaji = {0}", gaji);
        }
    }
}
