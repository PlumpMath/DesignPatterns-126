using System;
using AbstractFactory.BaseServices;

namespace AbstractFactory.CocaColaFactory
{
    class CocaColaBottle : AbstractBottle
    {
        public override void Interact(AbstractWater water, AbstractSticker sticker)
        {
            Console.WriteLine($"{nameof(CocaColaBottle)} has been created with {water.GetType()}, {sticker.GetType()}");
        }
    }
}
