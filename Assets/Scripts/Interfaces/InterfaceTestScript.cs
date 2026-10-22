using System.Collections.Generic;
using UnityEngine;

// This script tests the IShape interface.
// Its only job is to test the shapes and print the results (Single Responsibility).
// It does NOT build the shapes itself - it asks ShapeFactory to do that.
public class InterfaceTestScript : MonoBehaviour
{
    void Start()
    {
        Debug.Log("===== Shape Interface Test =====");

        // 1) Ask the factory to create one object of each shape.
        ShapeFactory factory = new ShapeFactory();
        Trapezium trapezium = factory.CreateTrapezium();
        Circle circle = factory.CreateCircle();
        Nonagon nonagon = factory.CreateNonagon();

        // 2) Call the method that is unique to each shape.
        Debug.Log("--- Unique methods ---");
        trapezium.CalculateUnknownSides();
        circle.CalculateRadius();
        nonagon.CalculateNumberOfSides();

        // 3) Put all three shapes in one list of IShape
        //    and call the shared interface methods on each one.
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
