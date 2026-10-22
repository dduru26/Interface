using UnityEngine;

// Trapezium implements IShape.
public class Trapezium : IShape
{
    // Arbitrary values to simulate a real trapezium.
    private float parallelSideA;
    private float parallelSideB;
    private float height;
    private float legC;
    private float legD;

    // Constructor: runs when the object is created.
    // It sets the values and solves the legs straight away,
    // so area and perimeter are always correct.
    public Trapezium()
    {
        parallelSideA = 8f;
        parallelSideB = 5f;
        height = 4f;
        SolveLegs();
    }

    // Works out the two slanted sides using Pythagoras.
    // We treat it as an isosceles trapezium, so both legs are equal.
    private void SolveLegs()
    {
        float overhang = (parallelSideA - parallelSideB) / 2f;
        legC = Mathf.Sqrt((height * height) + (overhang * overhang));
        legD = legC;
    }

    // Unique to Trapezium - NOT part of IShape.
    public void CalculateUnknownSides()
    {
        SolveLegs();
        Debug.Log("[Trapezium] Unknown sides solved: legC = " + legC + ", legD = " + legD);
    }

    public void CalculateArea()
    {
        float area = ((parallelSideA + parallelSideB) / 2f) * height;
        Debug.Log("[Trapezium] Area = " + area);
    }

    public void CalculatePerimeter()
    {
        float perimeter = parallelSideA + parallelSideB + legC + legD;
        Debug.Log("[Trapezium] Perimeter = " + perimeter);
    }
}
