using System.Diagnostics.Contracts;

public class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }
    private bool Handsome = true;
    public void Walk(){}
}

public class Dog : Animal
{
    public void HowOld()
    {
        Console.WriteLine("나이 : {0}", Age);
    }
}

public class Bird : Animal
{
    public void Fly()
    {
        Console.WriteLine($"{Name}가 날다");
    }
}

public abstract class Pursure
{
    public abstract int GetFirst();
    public abstract int GetNext();
}

public class DericedA : Pursure
{
    int no = 1;
    public override int GetFirst()
    {
        return no;
    }
    public override int GetNext()
    {
        return no++;
    }
}

public class MyBase
{
    public string Name { get; set; }
    protected int Age { get; set; }
}

public class MyDericed : MyBase
{
    public void Run()
    {
        Console.WriteLine("나이 : {0}", Age);
    }
}