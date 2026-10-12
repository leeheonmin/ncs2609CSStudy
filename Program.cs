using System.Collections;
using System.Diagnostics.Contracts;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace CSStudy;

class Program
{
    static void Main(string[] args)
    {
        // ArraySample();
        // ListSample();
        // QueueSample();
        // StackSample();
        // HashTableSample();
        DicSample();
    }
    static void DicSample()
    {
        Dictionary<int, string> emp = new Dictionary<int, string>();   
        emp.Add(1001, "Jane");
        emp.Add(1002,"Tom" );
        emp.Add(1003, "Cindy");
        string name = emp[1002];
        // Console.WriteLine(name);

        Dictionary<string, int> scores = new Dictionary<string, int>();
        scores.Add("철수", 98);
        scores.Add("영희", 95);
        // scores.Add("철수", 60);
        int score = scores["철수"];
        foreach (KeyValuePair<string, int> kv in scores)
        {
            Console.WriteLine("{0} : {1}", kv.Key, kv.Value);
        }
        if (scores.ContainsKey("철수"))
            Console.WriteLine(score);

        // sorted dictionary
        SortedDictionary<int, string> tmap = new SortedDictionary<int, string>();
        tmap.Add(1001, "Tom");
        tmap.Add(1003, "John");
        tmap.Add(1010, "Irina");

        string name1010 = tmap[1010];

        foreach (KeyValuePair<int, string> kv in tmap)
        {
            Console.WriteLine("{0}:{1}", kv.Key, kv.Value);
        }
    }
    static void HashTableSample()
    {
        Hashtable ht = new Hashtable();
        ht.Add("irina", "Irina SP");
        ht.Add("tom", "Tom Cr");

        // if(ht.Contains("tom"))
        // {
        //     Console.WriteLine(ht["tom"]);
        // }

        Hashtable scores = new Hashtable();
        scores.Add("철수", 98);
        scores.Add("영희", "95");
        int score = (int) scores["철수"];
        Console.WriteLine(score);
    }

    static void StackSample()
    {
        Stack<int> s = new Stack<int>();
        s.Push(10);
        s.Push(8);
        s.Push(16);
        Console.WriteLine("Peek : " + s.Peek()); 
        Console.WriteLine(s.Pop());
        Console.WriteLine(s.Pop());
        

    }
    static void QueueSample()
    {
        Queue<int> q = new Queue<int>();
        q.Enqueue(120);
        q.Enqueue(130);
        q.Enqueue(150);
        Console.WriteLine("Peek : " + q.Peek()); // 간보기
        Console.WriteLine(q.Dequeue());
        Console.WriteLine(q.Dequeue());
        Console.WriteLine(q.Dequeue());
        // int next = q.Dequeue();
        
    }
    static void ListSample()
    {
        List<int> myList = new List<int>();
        myList.Add(88);
        myList.Add(90);
        myList.Add(75);
        myList.Sort();
        // Console.WriteLine(myList[0]);       
        // Console.WriteLine(myList[1]);    
        // Console.WriteLine(myList[2]);    
        for (int i = 0; i < myList.Count; i++)
        {
            Console.WriteLine(myList[i]);
        }
    }
    static void ArraySample() {
        int[] scores = new int[100];
        scores[0] = 90;
        int val = scores[0];
        float[] fs = new float[10];
        fs[0] = 12.3f;
        Console.WriteLine(fs[2]);

        int sum = 0;
        int[] nums = new int[10];

        Random rand = new Random();

        for(int i = 0; i < nums.Length; i++)
        {
            nums[i] = rand.Next() % 100;
        }
        for(int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
        }
        Console.WriteLine(sum);
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
        static  int globalVar = 7;
    static void Varialbe()
    {
        int localVar = 5;
        const int MAX_VAL = 100;
        Console.WriteLine(localVar);
        Console.WriteLine(globalVar);
        Console.WriteLine(MAX_VAL);
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
