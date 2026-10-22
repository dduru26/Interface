using UnityEngine;

// Circle implements IShape.
public class Circle : IShape
{
    // Arbitrary value to simulate a real circle.
    private float diameter;
    private float radius;

    // Constructor: sets the diameter and works out the radius straight away,
    // so area and perimeter are always correct.
    public Circle()
    {
        diameter = 10f;
        radius = diameter / 2f;
    }

    // Unique to Circle - NOT part of IShape.
    public void CalculateRadius()
    {
        radius = diameter / 2f;
        Debug.Log("[Circle] Radius = " + radius);
    }

    public void CalculateArea()
    {
        float area = Mathf.PI * radius * radius;
        Debug.Log("[Circle] Area = " + area);
    }

    public void CalculatePerimeter()
    {
        // A circle's perimeter is called its circumference.
        float circumference = 2f * Mathf.PI * radius;
        Debug.Log("[Circle] Perimeter (circumference) = " + circumference);
    }
}
