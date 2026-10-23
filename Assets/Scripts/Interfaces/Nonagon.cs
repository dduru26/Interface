using UnityEngine;

public class Nonagon : IShape
{
    private int numberOfSides;
    private float sideLength;

    public Nonagon()
    {
        numberOfSides = 9;
        sideLength = 6f;
    }

    public int CalculateNumberOfSides()
    {
        Debug.Log("[Nonagon] Number of sides = " + numberOfSides);
        return numberOfSides;
    }

    public void CalculateArea()
    {
        float area = (numberOfSides / 4f) * (sideLength * sideLength) / Mathf.Tan(Mathf.PI / numberOfSides);
        Debug.Log("[Nonagon] Area = " + area);
    }

    public void CalculatePerimeter()
    {
        float perimeter = numberOfSides * sideLength;
        Debug.Log("[Nonagon] Perimeter = " + perimeter);
    }
}
