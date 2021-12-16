new A("A").PrintName();
new B("A").PrintName();
new C("A").PrintName();

public class A
{
    protected string name;

    public A(string name)
    {
        this.name = name;
    }

    public void PrintName()
    {
        Console.WriteLine(name);
    }
}

public class B : A
{
    public B(string name) : base(name)
    {
        this.name = name + "B";
    }
}
public class C : A
{
    public C(string name) : base(name)
    {
        this.name = name + "C";
    }
}