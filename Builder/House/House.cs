using System.Collections.Generic;

namespace Builder.House
{
    public class House
    {
        public List<House> _house = new List<House>();

        public void Add(House house)
        {
            _house.Add(house);
        }
    }
}
