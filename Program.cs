using System.Reflection.Metadata;

namespace CSStudy;

class Program
{
    static void Main(string[] args)
    {
        DataType();
    }
    static void HelloWorld() {
        // writeline은 내용을 콘솔에 표시하고 다음줄로 간다.

        /* //여러줄 주석을 한번에 묶는 법
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Hello, World!");
        */

        int a = 0; // a에 0을 할당한다.
        Console.WriteLine("Hello, World!");
    }
    static void DataType() {
        bool isRight = true;
        Console.WriteLine(isRight);

        int age = 30;
        Console.WriteLine("age : " + age);
        Console.WriteLine( sizeof(int));

        float size = 10.5f;
        Console.WriteLine(sizeof(float));

        // byte abc = 0;
        // sbyte sabc = 0;
        // Console.WriteLine("Byte : " + sizeof(byte) + "byte");

        char chr = 'A';
        Console.WriteLine(sizeof(char));

        string str = "aaa";
        Console.WriteLine(str.Length);

        DateTime dt = new DateTime(2026, 10, 02, 11, 44, 00);
        Console.WriteLine(dt);

        // max/min value
        Console.WriteLine(int.MaxValue);
        Console.WriteLine(decimal.MaxValue);

        // Nullable
        int? i = null;
        bool? bi = null;
        // if (bi == true) i = 1;
        if (bi == true)
        {
            i = 1;
        } else if (bi == false)
        {
                i = 0;
        } else
        {
            i = -1;
        }
       
        Console.WriteLine(i);
    }
}
