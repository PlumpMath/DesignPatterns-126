using Builder.Base;
namespace Builder
{
    public class BuilderClient
    {
        public House.House BuildHome(Foreman foreman)
        {
            return foreman.Build();
        }

    }
}
