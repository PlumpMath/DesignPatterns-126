using AbstractFactory.BaseServices;


namespace AbstractFactory.CocaColaFactory
{
    public class CocaColaFactory : BaseServices.AbstractFactory
    {
        public override AbstractWater CreateWater()
        {
            return new CocaColaWater();
        }

        public override AbstractSticker CreateSticker()
        {
            return new CocaColaSticker();
        }

        public override AbstractBottle CreateBottle()
        {
            return new CocaColaBottle();
        }
    }
}
