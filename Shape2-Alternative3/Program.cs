DescribeShape(new Circle(10f));
DescribeShape(new Rectangle(10f, 10f));

void DescribeShape(IShape shape)
{
    Console.WriteLine("Area: " + shape.CalcArea());
    Console.WriteLine("Perimeter: " + shape.CalcPerimeter());
}

/*
 * Die Verwendung eines Interface ist auch möglich und eventuell auch zu bevorzugen.
 * Interfaces modellieren typischerweise eine "Can do" Relationship und vererbungen eine "Is a"
 * "Is a" fühlt sich hier nach dem natürlicheren Modell an,
 * aber falls Shape wirklich nur abstrakte Methoden braucht ohne Attribute dann kann auch ein Interface prinzipiell genutzt werden.
 *
 * Klar ist, sowhohl Vererbung als auch Interfaces sind in diesem Fall einer "Master" Klasse vorzuziehen.
 * Diese Entscheidung gegen die "Master" Klasse ist das wichtigste.
 */

public interface IShape
{
    public float CalcArea();
    public float CalcPerimeter();
}

public class Circle : IShape
{
    protected float radius;

    public Circle(float radius)
    {
        this.radius = radius;
    }

    public float CalcArea()
    {
        return (float) (Math.PI * radius * radius);
    }

    public float CalcPerimeter()
    {
        return (float) (2 * Math.PI * radius);
    }
}

public class Rectangle : IShape 
{
    protected float width, height;

    public Rectangle(float width, float height)
    {
        this.width = width;
        this.height = height;
    }

    public float CalcArea()
    {
        return width * height;
    }

    public float CalcPerimeter()
    {
        return 2 * (width + height);
    }
}