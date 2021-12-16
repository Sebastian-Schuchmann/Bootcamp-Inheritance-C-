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