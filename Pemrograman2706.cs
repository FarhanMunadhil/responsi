using System;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
namespace karyawan
{
	public class Karyawan
	{
		public int Nik;
		public string nama;
		public int gaji;
		public Karyawan(int nik, string name, int gajiBulanan)
		{

			Nik = nik;
			nama = name;
			gaji = gajiBulanan;
		}

		public static void Main(string[] args)
		{
			Console.WriteLine("No      Nik/Nama                    Gaji Bulanan");
			Karyawan karyawan1 = new Karyawan(19112706, "Farhan Munadhil", 3000000);
			Karyawan karyawan2 = new Karyawan(11112706, "Anko", 2000000);
			Console.WriteLine("------------------------------------------------");
			Console.WriteLine("1.      " + karyawan1.Nik + " " + karyawan1.nama + "    " + karyawan1.gaji);
			Console.WriteLine("1.      " + karyawan2.Nik + " " + karyawan2.nama + "               " + karyawan2.gaji);
			Console.WriteLine("------------------------------------------------");
			if (karyawan1.gaji <= 0 || karyawan2.gaji <= 0)
			{
				Console.WriteLine("Anda memasukkan gaji minus");
				karyawan1.gaji = 0;
				karyawan2.gaji = 0;
				Console.WriteLine("1." + karyawan1.Nik + " " + karyawan1.nama + "     " + karyawan1.gaji);
				Console.WriteLine("2." + karyawan2.Nik + " " + karyawan2.nama + "    " + karyawan2.gaji);
			}
			else
			{

				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("Asyiiiiik Kenaikan gaji 10%;");
				Console.WriteLine("");
				Console.WriteLine("No      Nik/Nama                    Gaji Bulanan");
				Console.WriteLine("------------------------------------------------");
				int tambah = karyawan1.gaji * 10 / 100;
				karyawan1.gaji += tambah;
				int tambah1 = karyawan2.gaji * 10 / 100;
				karyawan2.gaji += tambah1;
				Console.WriteLine("1.      " + karyawan1.Nik + " " + karyawan1.nama + "    " + karyawan1.gaji);
				Console.WriteLine("1.      " + karyawan2.Nik + " " + karyawan2.nama + "               " + karyawan2.gaji);
				Console.WriteLine("------------------------------------------------");
			}
		}

	}
}
