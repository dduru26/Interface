// =====================================================================
// SOLID PRINCIPLE USED: Single Responsibility Principle (SRP)
// "A class should have only one job, so it has only one reason to change."
//
// ShapeFactory has ONE job: creating the shape objects.
// InterfaceTestScript has ONE job: testing the shapes and printing results.
//
// Before, InterfaceTestScript created the shapes AND tested them (two jobs).
// Now creating is moved here. If the way a shape is built ever changes,
// we only edit this class - the test script does not need to change.
// =====================================================================
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
