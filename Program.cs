using System.Collections;
using System.Data;
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
        // DicSample();
        ArraySample2();
    }
    static void ArraySample2()
    {
        string[] players = new string[10];
        // string[] Regions = new string[3]{"서울", "경기", "부산"};
        string[] Regions = {"서울", "경기", "부산"};

        Console.WriteLine("{0}, {1}", players.Length, Regions.Length);

        string[,] Depts = {{"김", "경리"}, {"이", "총무"}};
        int[,] dsum = new int[3 ,2];
        // dsum[0, 0] = 0;
        // dsum[0, 1] = 1;
        // dsum[0, 2] = 2;
        

        // int[,] dsum2 = new int[3, 2]{{0, 1}, {2, 3}, {4, 5}};
        int[,] dsum2 = {{0, 1}, {2, 3}, {4, 5}};
        string[,,] Cubes;

        int[][] A = new int[3][];
        A[0] = new int[2];
        A[1] = new int[3]{1, 2, 3};
        A[2] = new int[4]{1, 2, 3, 4};

        A[0][0] = 1;
        A[0][1] = 2;

        int total = 0;
        int[] scores = {80, 78, 60, 90, 100};
        total = CalculateSum(scores);
        // for (int i = 0; i < scores.Length; i++)
        // {    
        //     total += scores[i];
        // }

        Console.WriteLine("{0}", total);

    }

    static int CalculateSum(int[] scoresArray)
    {
        int sum = 0;
        for (int i = 0; i < scoresArray.Length; i++)
        {
            sum += scoresArray[i];
        }
        return sum;
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
