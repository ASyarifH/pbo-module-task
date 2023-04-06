namespace VGALaptop 
{ 
    class VGA 
    {
        public string merk;
    }
    class Nvidia : VGA 
    { 
        public Nvidia() 
        {
            merk = "Nvidia";
        }
    }
    class AMD : VGA 
    { 
        public AMD() 
        {
            merk = "AMD";
        }
    }
}