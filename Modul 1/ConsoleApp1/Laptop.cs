using ProcessorLaptop;
using VGALaptop;

class Laptop 
{
    public string merk;
    public string tipe;
    public VGA vga;
    public Processor processor;
    public void LaptopDinyalakan()
    {
        Console.WriteLine($"Laptop {merk} {tipe} menyala");
    }
    public void LaptopDimatikan()
    {
        Console.WriteLine($"Laptop {merk} {tipe} mati");
    }
}
class ASUS : Laptop 
{ 
    public ASUS()
    {
        merk = "ASUS";
    }
}
class ROG : ASUS 
{ 
    public ROG() 
    {
        tipe = "ROG";
    }
}
class Vivobook : ASUS
{
    public Vivobook()
    {
        tipe = "Vivobook";
    }
    public void Ngoding() 
    { 
        Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
    }
    
}
class ACER : Laptop 
{ 
    public ACER() 
    {
        merk = "ACER";
    }
}
class Swift : ACER 
{ 
    public Swift() 
    {
        tipe = "swift";
    }
}
class Predator : ACER 
{ 
    public Predator()
    {
        tipe = "Predator";
    }
    public void BermainGame() 
    { 
        Console.WriteLine($"Laptop {this.merk} {this.tipe} sedang memainkan game");
    }
}
class Lenovo : Laptop 
{
    public Lenovo() 
    {
        merk = "Lenovo";
    }
}
class IdeaPad : Lenovo 
{ 
    public IdeaPad() 
    {
        tipe = "IdePad";
    }
}
class Legion : Lenovo 
{ 
    public Legion() 
    {
        tipe = "Legion";
    }
}