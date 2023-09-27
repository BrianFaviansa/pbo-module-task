using _1014vga;
using _1014processor;

class Program
{
    static void Main(string[] args)
    {
        Laptop laptop1 = new Vivobook();
        laptop1.vga = new NVIDIA();
        laptop1.processor = new CoreI5();

        Laptop laptop2 = new IdeaPad();
        laptop2.vga = new _1014vga.AMD();
        laptop2.processor = new Ryzen();

        Predator predator = new Predator();
        predator.vga = new _1014vga.AMD();
        predator.processor = new CoreI7();

        Console.WriteLine("========== SOAL 1 ==========");
        laptop2.LaptopDinyalakan();
        laptop2.LaptopDimatikan();

        Console.WriteLine("\n========== SOAL 2 ==========");
        // laptop1.Ngoding(); dijadikan komen karena menyebabkan error
        
        Console.WriteLine("\n========== SOAL 3 ==========");
        Console.WriteLine("Spesifikasi Laptop 1");
        Console.WriteLine("Merk\t\t: " + laptop1.merk);
        Console.WriteLine("Tipe\t\t: " + laptop1.tipe);
        Console.WriteLine("Processor\t: " + laptop1.processor.merk + " " + laptop1.processor.tipe);
        Console.WriteLine("VGA\t\t: " + laptop1.vga.merk);
        
        Console.WriteLine("\n========== SOAL 4 ==========");
        predator.BermainGame();

        Console.WriteLine("\n========== SOAL 5 ==========");
        ACER acer = new Predator();
        // acer.BermainGame(); dijadikan komen karena menyebabkan error
    }
}

namespace _1014processor
{
    class Processor
    {
        public string merk, tipe;
    }

    class Intel : Processor
    {
        public Intel()
        {
            base.merk = "Intel";
        }
    }

    class CoreI3 : Intel
    {
        public CoreI3()
        {
            base.tipe = "Core i3";
        }
    }
    class CoreI5 : Intel
    {
        public CoreI5()
        {
            base.tipe = "Core i5";
        }
    }
    class CoreI7 : Intel
    {
        public CoreI7()
        {
            base.tipe = "Core i7";
        }
    }

    class AMD : Processor
    {
        public AMD()
        {
            base.merk = "AMD";
        }
    }

    class Ryzen : AMD
    {
        public Ryzen()
        {
            base.tipe = "RAYZEN";
        }
    }

    class Athlon : AMD
    {
        public Athlon()
        {
            base.tipe = "ATHLON";
        }
    }
}

namespace _1014vga
{
    class Vga
    {
        public string merk;
    }

    class NVIDIA : Vga
    {
        public NVIDIA()
        {
            base.merk = "NVIDIA";
        }
    }

    class AMD : Vga
    {
        public AMD()
        {
            base.merk = "AMD";
        }
    }
}


class Laptop
{
    public string merk, tipe;
    public Vga vga { get; set; }
    public Processor processor { get; set; } 

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
        base.merk = "ASUS";
    }
}
class ROG : ASUS
{
    public ROG()
    {
        base.tipe = "ROG";
    }
}

class Vivobook : ASUS
{
    public Vivobook()
    {
        base.tipe = "Vivobook";
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
        base.merk = "ACER";
    }
}

class Swift : ACER
{
    public Swift()
    {
        base.tipe = "Swift";
    }
}

class Predator : ACER
{
    public Predator()
    {
        base.tipe = "Predator";
    }

    public void BermainGame()
    {
        Console.WriteLine($"Laptop {merk} {tipe} sedang memainkan game");
    }
}

class Lenovo : Laptop
{
    public Lenovo()
    {
        base.merk = "Lenovo";
    }
}

class IdeaPad : Lenovo
{
    public IdeaPad()
    {
        base.tipe = "IdeaPad";
    }
}

class Legion : Lenovo
{
    public Legion()
    {
        base.tipe = "Legion";
    }
}

