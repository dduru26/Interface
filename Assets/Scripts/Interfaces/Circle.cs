using UnityEngine;

public class Circle : IShape
{
    private float diameter;
    private float radius;

    public Circle()
    {
        diameter = 10f;
        radius = diameter / 2f;
    }

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
        float circumference = 2f * Mathf.PI * radius;
        Debug.Log("[Circle] Perimeter (circumference) = " + circumference);
    }
}
