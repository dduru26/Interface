using System.Collections.Generic;
using UnityEngine;

// This script demonstrates the use of interfaces in C#.
public class InterfaceTestScript : MonoBehaviour
{
    void Start()
    {
        Debug.Log("===== Shape Interface Test =====");

        // 1) Create instances of the three shapes and call their unique methods.
        Trapezium trapezium = new Trapezium();
        trapezium.CalculateUnknownSides();

        Circle circle = new Circle();
        circle.CalculateRadius();

        Nonagon nonagon = new Nonagon();
        nonagon.CalculateNumberOfSides();

        // 2) Create a list of IShape and add the three shapes to it.
        List<IShape> shapes = new List<IShape> { trapezium, circle, nonagon };

        foreach (IShape shape in shapes)
        {
            shape.CalculateArea();
            shape.CalculatePerimeter();
        }

        Debug.Log("===== Test complete =====");
    }

    void Update()
    {
        // Not needed for this assignment.
    }
}

/// The IShape interface defines the contract for shapes.
public interface IShape
{
    void CalculateArea();
    void CalculatePerimeter();
}

public class Trapezium : IShape
{
    // Arbitrary values to simulate a real trapezium.
    private float parallelSideA = 8f;
    private float parallelSideB = 5f;
    private float height = 4f;
    private float legC = 0f;
    private float legD = 0f;

    // Unique to Trapezium — NOT part of IShape.
    public void CalculateUnknownSides()
    {
        // For simplicity, let's assume legC and legD are equal and can be calculated using the Pythagorean theorem.
        legC = 4.5f;
        legD = 4.5f;
        Debug.Log($"[Trapezium] Unknown sides solved: legC = {legC}, legD = {legD}");
    }

    public void CalculateArea()
    {
        float area = ((parallelSideA + parallelSideB) / 2f) * height;
        Debug.Log($"[Trapezium] Area = {area}");
    }

    public void CalculatePerimeter()
    {
        float perimeter = parallelSideA + parallelSideB + legC + legD;
        Debug.Log($"[Trapezium] Perimeter = {perimeter}");
    }
}

public class Circle : IShape
{
    private float radius = 0f;

    // Unique to Circle — NOT part of IShape.
    public void CalculateRadius()
    {
        float diameter = 10f;
        radius = diameter / 2f;
        Debug.Log($"[Circle] Radius = {radius}");
    }

    public void CalculateArea()
    {
        float area = Mathf.PI * radius * radius;
        Debug.Log($"[Circle] Area = {area}");
    }

    public void CalculatePerimeter()
    {
        // A circle's perimeter is its circumference.
        float circumference = 2f * Mathf.PI * radius;
        Debug.Log($"[Circle] Perimeter (circumference) = {circumference}");
    }
}

public class Nonagon : IShape
{
    private int numberOfSides = 9;   // a nonagon has 9 sides
    private float sideLength = 6f;

    // Unique to Nonagon — NOT part of IShape.
    public int CalculateNumberOfSides()
    {
        Debug.Log($"[Nonagon] Number of sides = {numberOfSides}");
        return numberOfSides;
    }

    public void CalculateArea()
    {
        // Area of a regular polygon = (n / 4) * s^2 * cot(PI / n)
        float area = (numberOfSides / 4f) * (sideLength * sideLength)
                     / Mathf.Tan(Mathf.PI / numberOfSides);
        Debug.Log($"[Nonagon] Area = {area}");
    }

    public void CalculatePerimeter()
    {
        float perimeter = numberOfSides * sideLength;
        Debug.Log($"[Nonagon] Perimeter = {perimeter}");
    }
}