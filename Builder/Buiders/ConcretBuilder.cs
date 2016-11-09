using Builder.House;

namespace Builder.Buiders
{
    public class ConcretBuilder : Base.Builder
    {
        private readonly House.House _house;

        public ConcretBuilder()
        {
            _house = new House.House();
        }

        public override void BuildBasement()
        {
            _house.Add(new Basement());
        }

        public override void BuilStorey()
        {
            _house.Add(new Storey());
        }

        public override void BuildRoof()
        {
            _house.Add(new Roof());
        }

        public override House.House GetResult()
        {
            return _house;
        }
    }
}
