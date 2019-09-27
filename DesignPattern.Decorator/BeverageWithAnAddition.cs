namespace DesignPattern.Decorator
{
    /// <summary>
    /// Decorator
    /// </summary>
    public abstract class BeverageWithAnAddition : Beverage
    {
        protected Beverage beverage;

        public BeverageWithAnAddition(Beverage beverage)
        {
            this.beverage = beverage;
        }
    }
}
