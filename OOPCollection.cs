  
using System;
using System.Collections.Generic;

namespace OOPCollection
{
    abstract public class Karyawan
    {
        public int Nik { get; set; }
        public string Nama { get; set; }
        public abstract double Gaji();
    }
    class KaryawanTetap : Karyawan
    {
       public double JumlahGaji { get; set; }
       public override double Gaji() => JumlahGaji;

    }

    class KaryawanHarian : Karyawan
    {

        public double JumlahJamKerja { get; set; }
        public double UpahPerJam { get; set; }
        public override double Gaji() => JumlahJamKerja * UpahPerJam ;
    }

    class Sales : Karyawan
    {
        public double JumlahJamPenjualan { get; set; }
        public double Komisi { get; set; }
        public override double Gaji() => JumlahJamPenjualan * Komisi ;
    }

    class Program
    {
        static void Main(string[] args)
        {

            KaryawanTetap karyawantetap = new KaryawanTetap();
            karyawantetap.Nik = 111222333;
            karyawantetap.Nama = "Spider";
            karyawantetap.JumlahGaji = 20000000;

            KaryawanHarian karyawanharian = new KaryawanHarian();
            karyawanharian.Nik = 222333111;
            karyawanharian.Nama = "Wolf";
            karyawanharian.JumlahJamKerja = 8;
            karyawanharian.UpahPerJam = 500000;

            Sales sales  = new Sales ();
            sales.Nik = 333111222;
            sales.Nama = "Ant";
            sales.JumlahJamPenjualan = 50;
            sales.Komisi = 5000000;
            
            

            List<Karyawan> listKaryawan = new List<Karyawan>();
            listKaryawan.Add(karyawantetap);
            listKaryawan.Add(karyawanharian);
            listKaryawan.Add(sales);

            int i = 1;
            foreach (Karyawan karyawan in listKaryawan)
            {
                Console.WriteLine(" {0}.\tNIK: {1}\n\tNama: {2} \n\tGaji: {3:N0}\n",
                    i, karyawan.Nik, karyawan.Nama, karyawan.Gaji());
                i++;
            }

        }
    }
}