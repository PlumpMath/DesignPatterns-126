namespace Builder.Base
{
    public class Foreman
    {
        private readonly Builder _builder;

        public Foreman(Builder builder)
        {
            _builder = builder;
        }
        public House.House Build()
        {
            _builder.BuildBasement();
            _builder.BuilStorey();
            _builder.BuildRoof();
            return _builder.GetResult();
        }
    }
}
