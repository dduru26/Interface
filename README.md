# Interface Assignment - IShape

A Unity project that uses a C# interface (`IShape`) shared by three shape classes: `Trapezium`, `Circle` and `Nonagon`. The results print to the Unity Console with `Debug.Log()`.

## Folder structure

```
Assets/Scripts/Interfaces/
    IShape.cs               - the interface (shared methods only)
    Trapezium.cs            - implements IShape
    Circle.cs               - implements IShape
    Nonagon.cs              - implements IShape
    ShapeFactory.cs         - creates the shape objects
    InterfaceTestScript.cs  - tests the shapes in Start()
```

## The interface

`IShape` only has the two methods every shape uses:

- `CalculateArea()`
- `CalculatePerimeter()`

Methods that only one shape needs stay in that shape's own class:

- `Trapezium.CalculateUnknownSides()`
- `Circle.CalculateRadius()`
- `Nonagon.CalculateNumberOfSides()`

## SOLID principle used: Single Responsibility Principle (SRP)

**What it says:** a class should have only one job, so it has only one reason to change.

**How it is used here:**

- `ShapeFactory` has one job: creating the shape objects (`CreateTrapezium()`, `CreateCircle()`, `CreateNonagon()`).
- `InterfaceTestScript` has one job: testing the shapes and printing the results.
- Each shape class has one job: holding its own values and doing its own calculations.

Without the factory, `InterfaceTestScript` would create the shapes and test them, which is two jobs. Moving the creation into `ShapeFactory` means that if the way a shape is built ever changes, only `ShapeFactory` is edited and the test script stays the same.

## How to run

1. Open the project in Unity (6000.4.5f1).
2. Open `Assets/Scenes/SampleScene`.
3. The `ShapeTester` GameObject already has `InterfaceTestScript` attached.
4. Press Play and open the Console window (Window > General > Console).

## Expected console output

```
===== Shape Interface Test =====
--- Unique methods ---
[Trapezium] Unknown sides solved: legC = 4.272002, legD = 4.272002
[Circle] Radius = 5
[Nonagon] Number of sides = 9
--- Shared IShape methods ---
[Trapezium] Area = 26
[Trapezium] Perimeter = 21.544
[Circle] Area = 78.53982
[Circle] Perimeter (circumference) = 31.41593
[Nonagon] Area = 222.5457
[Nonagon] Perimeter = 54
===== Test complete =====
```
