using UnityEngine;

public class Trapezium : IShape
{
    private float parallelSideA;
    private float parallelSideB;
    private float height;
    private float legC;
    private float legD;

    public Trapezium()
    {
        parallelSideA = 8f;
        parallelSideB = 5f;
        height = 4f;
        SolveLegs();
    }

    private void SolveLegs()
    {
        float overhang = (parallelSideA - parallelSideB) / 2f;
        legC = Mathf.Sqrt((height * height) + (overhang * overhang));
        legD = legC;
    }

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
