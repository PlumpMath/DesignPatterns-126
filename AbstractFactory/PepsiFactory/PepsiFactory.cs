using AbstractFactory.BaseServices;

namespace AbstractFactory.PepsiFactory
{
    public class PepsiFactory : BaseServices.AbstractFactory

    {
        public override AbstractWater CreateWater()
        {
            return new PepsiWater();
        }

        public override AbstractSticker CreateSticker()
        {
            return new PepsiSticker();
        }

        public override AbstractBottle CreateBottle()
        {
            return new PepsiBottle();
        }
    }
}
