// IShape is the shared contract for every shape.
// It only contains the methods that ALL three shapes use.
// Methods that only one shape needs stay inside that shape's own class.
public interface IShape
{
    void CalculateArea();
    void CalculatePerimeter();
}
