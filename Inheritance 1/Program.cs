new A().Print();
new B().Print();
new C().Print();

public class A
{
    public void Print()
    {
        Console.WriteLine("Hallo");
    }
}

public class B : A {}
public class C : A {}


