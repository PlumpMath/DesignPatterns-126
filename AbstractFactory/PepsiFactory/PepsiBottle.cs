using System;
using AbstractFactory.BaseServices;

namespace AbstractFactory.PepsiFactory
{
    class PepsiBottle : AbstractBottle
    {
        public override void Interact(AbstractWater water, AbstractSticker sticker)
        {
            Console.WriteLine($"{nameof(PepsiBottle)} han been creater with {water.GetType()}, {sticker.GetType()}");
        }
    }
}
