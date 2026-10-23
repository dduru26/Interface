public class ShapeFactory
{
    public Trapezium CreateTrapezium()
    {
        Trapezium trapezium = new Trapezium();
        return trapezium;
    }

    public Circle CreateCircle()
    {
        Circle circle = new Circle();
        return circle;
    }

    public Nonagon CreateNonagon()
    {
        Nonagon nonagon = new Nonagon();
        return nonagon;
    }
}
