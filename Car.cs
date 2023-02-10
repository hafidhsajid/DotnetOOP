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

}