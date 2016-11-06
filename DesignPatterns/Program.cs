using AbstractFactory;
using AbstractFactory.PepsiFactory;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client(new PepsiFactory());

            client.Run();
        }
    }
}
