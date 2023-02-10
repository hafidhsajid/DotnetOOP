
namespace ConsoleUI // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<Car> listcar = new List<Car>();
            listcar.Add(new Toyota());
            listcar.Add(new Hyundai());
            foreach (var item in listcar)
            {
                item.getMerk();
            }

        }
    }
}
