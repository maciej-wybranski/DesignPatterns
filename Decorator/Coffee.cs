namespace DesignPattern.Decorator
{
    /// <summary>
    /// Concrete component
    /// </summary>
    class Coffee : Beverage
    {
        public override decimal Price()
        {
            return 3.5M;
        }

        public override string ToString()
        {
            return "Kawa";
        }
    }
}
