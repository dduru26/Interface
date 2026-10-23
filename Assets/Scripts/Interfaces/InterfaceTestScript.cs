using System.Collections.Generic;
using UnityEngine;

public class InterfaceTestScript : MonoBehaviour
{
    void Start()
    {
        Debug.Log("===== Shape Interface Test =====");

        ShapeFactory factory = new ShapeFactory();
        Trapezium trapezium = factory.CreateTrapezium();
        Circle circle = factory.CreateCircle();
        Nonagon nonagon = factory.CreateNonagon();

        Debug.Log("--- Unique methods ---");
        trapezium.CalculateUnknownSides();
        circle.CalculateRadius();
        nonagon.CalculateNumberOfSides();

        Debug.Log("--- Shared IShape methods ---");
        List<IShape> shapes = new List<IShape>();
        shapes.Add(trapezium);
        shapes.Add(circle);
        shapes.Add(nonagon);

        foreach (IShape shape in shapes)
        {
            shape.CalculateArea();
            shape.CalculatePerimeter();
        }

        Debug.Log("===== Test complete =====");
    }
}
