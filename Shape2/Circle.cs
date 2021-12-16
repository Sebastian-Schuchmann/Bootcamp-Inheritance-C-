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