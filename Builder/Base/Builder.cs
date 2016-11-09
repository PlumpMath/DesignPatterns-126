namespace Builder.Base
{
    public abstract class Builder
    {
        public abstract void BuildBasement();
        public abstract void BuilStorey();
        public abstract void BuildRoof();
        public abstract House.House GetResult();
    }
}
