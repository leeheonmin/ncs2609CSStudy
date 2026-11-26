using System.ComponentModel;
using System.Runtime.CompilerServices;

public class MyClass2
{
    public int val = 1;
    public static int _id;
    public static string name { get; set; }
    public int InstRun() 
    {
        _id = 0;
         return val; 
    }
    public static int Run() 
    {
        _id++;
        // val++;_
        return 1; 
    }
}

public class Client()
{
    public void Test()
    {
        MyClass2 myc = new MyClass2();
        int i = myc.InstRun();
        myc.val = 3;

        int j = MyClass2.Run();

        MyClass2._id = 6;

        MyClass2 myc2 = new MyClass2();
        int k = myc2.InstRun();
        myc2.val = 10;

        MyClass2._id = 10;
    }
}