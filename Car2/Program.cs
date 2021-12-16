using System.Drawing;

// Auch sehr valide
var lambo = CarFactory.CreateLambo();
var ferrari = CarFactory.CreateFerrari();

public class Car
{
    public int Year;
    public int PS;
    public Color Color;

    public Car(int year, int ps, Color color)
    {
        Year = year;
        PS = ps;
        Color = color;
    }
    
    public Car(){}
}

public static class CarFactory
{
    public static Car CreateLambo() => new Car(1990, 420, Color.Yellow);
    public static Car CreateFerrari() => new Car(1992, 550, Color.Red);
    
}
