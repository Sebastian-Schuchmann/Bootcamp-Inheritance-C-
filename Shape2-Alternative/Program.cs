
DescribeShape(new Shape(ShapeType.Circle, circleRadius: 2f));
DescribeShape(new Shape(ShapeType.Rectangle, widthRect: 10f, heightRect: 10f));
DescribeShape(new Shape(ShapeType.Triangle, side1: 10f, side2: 10f, side3: 10f));

void DescribeShape(Shape shape)
{
    Console.WriteLine("Area: " + shape.CalcArea());
    Console.WriteLine("Perimeter: " + shape.CalcPerimeter());
}

/*
 * Da der die Art der Shape die Funktionalität fundamental verändert,
 * da die die Fläche und der Umfang anders berechnet werden und nicht nur andere Werte haben
 * Macht hier Vererbung Sinn.
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


    public Shape(ShapeType type = default, float circleRadius = default, float widthRect = default, float heightRect = default, float side1 = default, float side2 = default, float side3 = default, int posX = default, int posY = default)
    {
        this.type = type;
        this.circleRadius = circleRadius;
        this.widthRect = widthRect;
        this.heightRect = heightRect;
        this.side1 = side1;
        this.side2 = side2;
        this.side3 = side3;
        this.posX = posX;
        this.posY = posY;
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

