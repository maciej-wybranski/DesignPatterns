namespace DesignPattern.Decorator
{
    /// <summary>
    /// Component
    /// </summary>
    abstract class Beverage
    {
        public abstract decimal Price();
        
        public virtual int Size()
        {
            return 330;
        }
    }
}
