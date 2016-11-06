namespace AbstractFactory.BaseServices
{
    public abstract class AbstractFactory
    {
        public abstract AbstractWater CreateWater();
        public abstract AbstractSticker CreateSticker();
        public abstract AbstractBottle CreateBottle();
    }
}
