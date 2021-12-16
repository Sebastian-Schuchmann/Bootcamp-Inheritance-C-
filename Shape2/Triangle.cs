public class Triangle : Shape 
{
    protected float sideA, sideB, sideC;

    public Triangle(float sideA, float sideB, float sideC)
    {
        this.sideA = sideA;
        this.sideB = sideB;
        this.sideC = sideC;
    }

    public override float CalcArea()
    {
        float s = (sideA + sideB + sideC) / 2;
        return (float) Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
    }

    public override float CalcPerimeter()
    {
        return sideA + sideB + sideC;
    }
}