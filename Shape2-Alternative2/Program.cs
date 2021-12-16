DescribeShape(Shape.CreateCircle(2f));
DescribeShape(Shape.CreateRectangle(10f, 10f));
DescribeShape(Shape.CreateTriangle(10f,10f,10f));

void DescribeShape(Shape shape)
{
    Console.WriteLine("Area: " + shape.CalcArea());
    Console.WriteLine("Perimeter: " + shape.CalcPerimeter());
}

/*
 * Mit statische Factory Functions kann man dem ganzen ein passables Interface verpassen
 * Finde die Vererbungsvariante trotzdem besser.
 * Wenn eine neue Shape hinzukommt muss die BaseClass nämlich nicht verändert werden sondern nur eine neue Hinzugefügt
 * Erweitern ist verändern immer zu bevorzugen weil Verändern die Gefahr mit bringt neue Bugs einzuführen
 */

public enum ShapeType
{
    Circle,
    Rectangle,
    Triangle
}

public class Shape
{
    private ShapeType type;
    
    private float circleRadius;
    private float widthRect, heightRect;
    private float side1, side2, side3;
    
    int posX, posY;
    
    private Shape () {}
    
    public static Shape CreateCircle(float radius)
    {
        return new Shape()
        {
            type = ShapeType.Circle,
            circleRadius = radius,
        };
    }
    
    public static Shape CreateRectangle(float width, float height)
    {
        return new Shape()
        {
            type = ShapeType.Rectangle,
            widthRect = width,
            heightRect = height,
        };
    }
    
    public static Shape CreateTriangle(float side1, float side2, float side3)
    {
        return new Shape()
        {
            type = ShapeType.Triangle,
            side1 = side1,
            side2 = side2,
            side3 = side3,
        };
    }
    
    public float CalcArea()
    {
        switch (type)
        {
            case ShapeType.Circle:
                return (float)Math.PI * circleRadius * circleRadius;
            case ShapeType.Rectangle:
                return widthRect * heightRect;
            case ShapeType.Triangle:
                return side1 * side2 / 2;
            default:
                return 0;
        }
    }

    public float CalcPerimeter()
    {
        switch (type)
        {
            case ShapeType.Rectangle:
                return 2 * (widthRect + heightRect);
            case ShapeType.Circle:
                return (float)Math.PI * circleRadius * 2;
            case ShapeType.Triangle:
                return side1 + side2 + side3;
            default:
                return 0;
        }
    }
}