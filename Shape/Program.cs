
DescribeShape(new Circle(10f));
DescribeShape(new Rectangle(10f, 10f));

void DescribeShape(Shape shape)
{
    Console.WriteLine("Area: " + shape.CalcArea());
    Console.WriteLine("Perimeter: " + shape.CalcPerimeter());
}

public abstract class Shape
{
    protected int posX, posY;
    public abstract float CalcArea(); //Fläche
    public abstract float CalcPerimeter(); //Umfang
}

public class Circle : Shape
{
    protected float radius;

    public Circle(float radius)
    {
        this.radius = radius;
    }

    public override float CalcArea()
    {
        return (float) (Math.PI * radius * radius);
    }

    public override float CalcPerimeter()
    {
        return (float) (2 * Math.PI * radius);
    }
}

public class Rectangle : Shape 
{
    protected float width, height;

    public Rectangle(float width, float height)
    {
        this.width = width;
        this.height = height;
    }

    public override float CalcArea()
    {
        return width * height;
    }

    public override float CalcPerimeter()
    {
        return 2 * (width + height);
    }
}






