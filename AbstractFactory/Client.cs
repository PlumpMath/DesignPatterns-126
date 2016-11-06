using AbstractFactory.BaseServices;

namespace AbstractFactory
{
    public class Client
    {
        private readonly AbstractWater _water;
        private readonly AbstractBottle _bottle;
        private readonly AbstractSticker _sticker;

        public Client(BaseServices.AbstractFactory factory)
        {
            _water = factory.CreateWater();
            _sticker = factory.CreateSticker();
            _bottle = factory.CreateBottle();
        }

        public void Run()
        {
            _bottle.Interact(_water, _sticker);
        }
    }
}
