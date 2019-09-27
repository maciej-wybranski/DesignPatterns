namespace DesignPattern.Adapter
{
    /// <summary>
    /// Target, interface used by client
    /// </summary>
    interface IRegularPolygon
    {
        Point Center { get; }
        int NumberOfSides { get; }
        float SidesLength { get; }

        void DisplayParameters();
        void DisplayShapeName();
        float CalculateTheCircuit();
        float CalculateTheField();
    }
}
