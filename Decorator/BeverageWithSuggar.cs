namespace DesignPattern.Decorator
{
    class BeverageWithSuggar : BeverageWithAnAddition
    {
        private readonly bool _brownSuggar;

        public BeverageWithSuggar(Beverage beverage, bool brownSuggar = false)
            : base(beverage)
        {
            _brownSuggar = brownSuggar;
        }

        public override decimal Price()
        {
            return beverage.Price() + 0.5M;
        }

        public override int Size()
        {
            return beverage.Size();
        }

        public override string ToString()
        {
            return beverage.ToString() + " z cukrem" + (_brownSuggar ? " brązowym" : null); 
        }
    }
}
