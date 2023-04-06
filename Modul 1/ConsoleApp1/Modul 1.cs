using ProcessorLaptop;
using VGALaptop;

namespace Modul1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("[SYSTEM] Modul 1.cs Berhasil Membuat Objek Yang Tersimpan!");
            Console.ResetColor();

            Laptop laptop1 = new Vivobook();
            Laptop laptop2 = new IdeaPad();
            Predator predator = new Predator();

            laptop1.vga = new Nvidia();
            laptop1.processor = new CoreI5();
            laptop2.vga = new VGALaptop.AMD();
            laptop2.processor = new Ryzen();
            predator.vga = new VGALaptop.AMD();
            predator.processor = new CoreI7();

            ////soal nomer 1
            //Console.WriteLine();
            //Console.WriteLine("Soal Nomor 1");
            //Console.WriteLine();
            ////memanggil method
            //laptop2.LaptopDimatikan();
            //laptop2.LaptopDinyalakan();

            ////soal nomer 2
            //Console.WriteLine();
            //Console.WriteLine("Soal Nomor 2");
            //Console.WriteLine();
            ////memanggil method
            //laptop1.Ngoding();

            ////soal nomer 3
            //Console.WriteLine();
            //Console.WriteLine("Soal Nomor 3");
            //Console.WriteLine();
            //Console.WriteLine("merk vga: " + laptop1.vga.merk +
            //    "\n" + "merk processor: " + laptop1.processor.merk +
            //    "\n" + "tipe processor: " + laptop1.processor.tipe);

            ////soal nomer 4
            //Console.WriteLine();
            //Console.WriteLine("Soal Nomor 4");
            //Console.WriteLine();
            ////memanggil method
            //predator.BermainGame();

            ////soal nomer 5
            //Console.WriteLine();
            //Console.WriteLine("Soal Nomor 5");
            //Console.WriteLine();
            //ACER acer = new Predator();
            ////memanggil method
            //acer.BermainGame();
        }
    }
}