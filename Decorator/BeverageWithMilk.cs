namespace DesignPattern.Decorator
{
    class BeverageWithMilk : BeverageWithAnAddition
    {
        public BeverageWithMilk(Beverage beverage)
            : base(beverage)
        {
            
        }

        public override decimal Price()
        {
            return beverage.Price() +1.0M;
        }

        public override string ToString()
        {
            return beverage.ToString() + " z mlekiem"; 
        }

        public override int Size()
        {
            return beverage.Size() + 70;
        }
    }
}
