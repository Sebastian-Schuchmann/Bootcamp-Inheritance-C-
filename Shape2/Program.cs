DescribeShape(new Circle(10f));
DescribeShape(new Rectangle(10f, 10f));
DescribeShape(new Triangle(1f,1f,1f));

void DescribeShape(Shape shape)
{
    Console.WriteLine("Area: " + shape.CalcArea());
    Console.WriteLine("Perimeter: " + shape.CalcPerimeter());
}