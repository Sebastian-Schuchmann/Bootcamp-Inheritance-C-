new A().Print();
new B().Print();
new C().Print();

public class A
{
    public virtual void Print()
    {
        Console.WriteLine("A");
    }
}

public class B : A
{
    public override void Print()
    {
        Console.WriteLine("B");
    }
}

public class C : A
{
    
}