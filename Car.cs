using System;
namespace ConsoleUI // Note: actual namespace depends on the project name.
{


    public class Car
    {
        protected string Merk = "CAR";
        protected string Model = "MODEL";
        public void getMerk()
        {
            Console.WriteLine(this.Merk);
        }
    }

    public class Toyota : Car
    {

        public Toyota()
        {
            this.Merk = "Toyota";
            this.Model = "ToyotaModel";
        }


    }

    public class Hyundai : Car
    {

        public void otomatis()
        {
            Console.WriteLine("NGENg");
        }
        public Hyundai()
        {
            this.Merk = "Hyundai";
            this.Model = "HyundaiModel";
        }
        

    }
}