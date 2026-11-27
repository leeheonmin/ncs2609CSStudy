using System.Data.Common;
using System.Dynamic;

class Dclass1
{
    public void Run()
    {
        dynamic t = new { Name = "kim", Age = 25};
        var c = new Dclass2();
        c.Run(t);
    }
}

class Dclass2
{
    public void Run(dynamic o)
    {
        Console.WriteLine(o.Name);
        Console.WriteLine(o.Age);
    } 
}

public class DMyClass
{
    public void M1()
    {
        dynamic person = new ExpandoObject();
        person.Name = "Kim";
        person.Age = 10;
        person.Display = (Action)(() => 
        {
           Console.WriteLine($"{person.Name} {person.Age}");
        });
        person.ChangeAge = (Action<int>) ((age) => 
        {
            person.Age = age;
            if (person.AgeChanged != null)
            {
                person.AgeChanged(this, EventArgs.Empty);
            }
        });

        person.AgeChanged = null;
        person.AgeChanged += new EventHandler(OnAgechanged);
    }
    void OnAgechanged (object s, EventArgs e)
    {
        Console.WriteLine("Age Changed");
    }

    public void M2(dynamic d)
    {
        d.Display();
        d.ChangeA(20);
        d.Display();
    }
}