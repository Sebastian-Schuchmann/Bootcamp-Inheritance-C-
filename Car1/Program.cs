using System.Drawing;

// Why?
Car lambo = new Lambo();
Car ferrari = new Ferrari();

// We can just instantiate different objects
lambo = new Car(1990, 420, Color.Yellow);
ferrari = new Car(1992, 550, Color.Red);

/*
 * Wenn sich nur die Daten ändern und nicht die funktionalität
 * Dann braucht man keine neue Klasse
 */

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

public class Lambo : Car
{
    public Lambo()
    {
        Year = 1990;
        PS = 450;
        Color = Color.Yellow;
    }
}

public class Ferrari : Car
{
    public Ferrari()
    {
        Year = 1992;
        PS = 550;
        Color = Color.Red;
    }
}

