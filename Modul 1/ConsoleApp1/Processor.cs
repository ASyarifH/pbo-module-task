namespace ProcessorLaptop 
{
    class Processor
    {
        public string merk;
        public string tipe;
    }
    class Intel : Processor
    {
        public Intel() 
        {
            merk = "Intel";
        }
    }
    class CoreI3 : Intel 
    { 
        public CoreI3() 
        {
            tipe = "Core I3";
        }
    }
    class CoreI5 : Intel 
    {
        public CoreI5() 
        {
            tipe = "Core I5";
        }
    }
    class CoreI7 : Intel
    {
        public CoreI7()
        {
            tipe = "Core I7";
        }
    }
    class AMD : Processor 
    {
        public AMD() 
        {
            merk = "AMD";
        }
    }
    class Ryzen : AMD
    { 
        public Ryzen() 
        {
            tipe = "Ryzen";
        }
    }
    class ATHLON : AMD 
    { 
        public ATHLON() 
        {
            tipe = "ATHLON";
        }
    }
}
