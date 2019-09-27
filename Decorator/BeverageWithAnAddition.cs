namespace DesignPattern.Decorator
{
    /// <summary>
    /// Decorator
    /// </summary>
    abstract class BeverageWithAnAddition : Beverage
    {
        protected Beverage beverage;

        public BeverageWithAnAddition(Beverage beverage)
        {
            this.beverage = beverage;
        }
    }
}
