

using Builder;
using Builder.Base;
using Builder.Buiders;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //var client = new Client(new PepsiFactory());

            //client.Run();

            var builder = new ConcretBuilder();
            var foreman = new Foreman(builder);
            var home = foreman.Build();
        }
    }
}
