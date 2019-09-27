namespace DesignPattern.Decorator
{
    /// <summary>
    /// Concrete component
    /// </summary>
    public class Tea : Beverage
    {
        public override decimal Price()
        {
            return 2.5M;
        }

        public override string ToString()
        {
            return "Herbata";
        }
    }
}
