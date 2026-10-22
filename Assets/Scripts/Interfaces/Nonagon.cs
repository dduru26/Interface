using UnityEngine;

// Nonagon implements IShape.
public class Nonagon : IShape
{
    // Arbitrary values to simulate a regular nonagon.
    private int numberOfSides;
    private float sideLength;

    // Constructor: sets the values when the object is created.
    public Nonagon()
    {
        numberOfSides = 9;   // a nonagon always has 9 sides
        sideLength = 6f;
    }

    // Unique to Nonagon - NOT part of IShape.
    public int CalculateNumberOfSides()
    {
        Debug.Log("[Nonagon] Number of sides = " + numberOfSides);
        return numberOfSides;
    }

    public void CalculateArea()
    {
        // Area of a regular polygon = (n / 4) * s * s / tan(PI / n)
        float area = (numberOfSides / 4f) * (sideLength * sideLength) / Mathf.Tan(Mathf.PI / numberOfSides);
        Debug.Log("[Nonagon] Area = " + area);
    }

    public void CalculatePerimeter()
    {
        float perimeter = numberOfSides * sideLength;
        Debug.Log("[Nonagon] Perimeter = " + perimeter);
    }
}
