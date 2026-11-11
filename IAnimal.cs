using System.Runtime.InteropServices;

interface IAnimal
{
    void Speak();
}

class Dog1 : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("멍멍");
    }
}

class Cat : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("야옹");
    }
}

class InterSample
{
    IAnimal dog1 = new Dog1();
    // dog1.Speak();
    IAnimal cat1 = new Cat();
    // cat1.Speak();
    IAnimal[] animnals = {new Dog1(), new Cat()};
}