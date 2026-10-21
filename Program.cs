using System.Collections;
using System.Data;
using System.Diagnostics.Contracts;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml.Serialization;

namespace CSStudy;

class Program
{
    static void Main(string[] args)
    {
        
        foreach (int num in Getnumber())
        {
            Console.WriteLine(num);
        }
    }
    static IEnumerable<int> Getnumber()
    {
        yield return 10;    
        yield return 20;
        yield return 30;
    }

    static int SampleMethod()
    {
        return 0;
    }
    static void RepeatSample()
    {
        // for (int i = 0; i < 100; i++)
        // {
        //     if (i % 2 == 0) continue;
        //     Console.WriteLine(i);
        //     if (i >= 10) break;
        // }

        // string[] array = ["AB", "CD", "EF"];
        // foreach (string s in array)
        // {
        //     Console.WriteLine("string : {0}", s);
        //     foreach (char c in s)
        //     {
        //         Console.WriteLine("char : {0}", c);
        //     }
        // }

        // // foreach
        // foreach (var item in array)
        // {
            
        // }

        // int a = 0, aa = 1;
        // var b = 0; // , bb = 1;

        // // Dictionary<int, char> dic = new Dictionary<int, char>();
        // var dic = new Dictionary<int, char>();
        // dic.Add(3, 'a');
        // dic.Add(5, 'z');
        // foreach (var key in dic)
        // {
        //     Console.WriteLine("key : {0}, value : {1}", key.Key, key.Value);
        // }

        // string[,,] arr = {
        //     {{"1", "2"}, {"11", "22"}},
        //     {{"3", "4"}, {"33", "44"}}
        // };

        // for (int i = 0; i < arr.GetLength(0); i++)
        // {
        //     for (int j = 0; j < arr.GetLength(1); j++)
        //     {
        //         for (int k = 0; k < arr.GetLength(2); k++)
        //         {
        //             Console.WriteLine(arr[i, j, k]);
        //         }
        //     }
        // }

        // foreach (var item in arr)
        // {
        //     Console.WriteLine(item[0]);
        // } 

        int i2 = 1;
        // while (i2 <= 10)
        // {
        //     Console.WriteLine(i2);
        //     i2++;
        // }
        // i2 = 10;
        // while (i2 < 10)
        // {
        //     Console.WriteLine(i2);
        //     i2++;
        // }

        // List<char> keyList = new List<char>();
        var keyList = new List<char>();
        ConsoleKeyInfo key;
        do
        {
            key = Console.ReadKey();
            keyList.Add(key.KeyChar);
        } while (key.Key != ConsoleKey.Q);
        Console.WriteLine();
        foreach (var item in keyList)
        {
            Console.Write(item);
        }
        
    }

    static void SwitchSample()
    {
        // int a = -11;
        // int val = 0;

        // if (a >= 0)
        // {
        //     val = a;
        // }
        // else
        // {
        //     val = -a;
        // }
        // val = (a > 0) ? a : -a;

        string category = "사과";
        int price = 0;

        // switch (category)
        // {
        //     case "사과":
        //         price = 1000;
        //         break;
        //     case "딸기":
        //         price = 1100;
        //         break;
        //     case "포도":
        //         price = 900;
        //         break;
        //     case "키위":
        //         price = 1200;
        //         break;
        //     default:
        //         price = 0;
        //         break;
        // }
        // if (category == "사과" && category == "키위")
        // {
        //     price = 1000;
        // }
        // else if (category == "딸기")
        // {
        //     price = 1100;
        // }
        // else if (category == "포도")
        // {
        //     price = 900;
        // }
        // else if (category == "키위")
        // {
        //     price = 1200;
        // }
        price = category switch
        {
            "딸기" => 1100,
            "포도" => 900,
            "사과" or "키위" => 1000,
            _ => 0
        };
        Console.WriteLine("price : {0}", price);
    }
    static void OperatorSample()
    {
        int a = (1 + 2 - 3) * 4 / 5 % 6;
        a += 3; // a = a + 3;
        a = 10;

        Console.WriteLine(a);
        Console.WriteLine(a++);
        Console.WriteLine(--a); 

        byte bb = 7;
        Console.WriteLine(bb);
        byte c1 = 3, c2 = 4;
        byte cc = (byte) ((bb & 3) | 4);
        Console.WriteLine(cc);
        // int val = (a > b) ? a : b;

        int? i = null;
        i = i ?? 0;
        // Console.WriteLine(i);
        int? i2 = 22;
        i2 = i ?? 0;
        // Console.WriteLine(i2);

        string s = null;
        string s2;
        s2 = s ?? string.Empty;
    }
    public enum Category
    {
        Cake = 100,
        IceCream = 13,
        Bread
    }

    enum City
    {
        Seoul,
        Deajun,
        Busan = 5,
        Jeju = 10
    }
    enum EnglishDay
    {
        Sunday, Monday, Tuesday, Wednesay, Thusday, Friday, Saturday
    }
    [Flags]
    enum Border
    {
        None = 0,
        Top = 1,
        Right = 2,
        Bottom = 4,
        Left = 8
    }
    static void EnumSample()
    {
        City myCity = City.Jeju;
        myCity = City.Seoul;
        int cityValue = (int)myCity;

        if (myCity == City.Seoul)
        {
            Console.WriteLine("조선의 궁궐에 당도한것을 환영하오 낯선이여. 난 이나라를 굽어살피는 깨우친 임금 세종이오.");
        }
        if (cityValue == 10)
        {
            Console.WriteLine("제주도");
        }
        EnglishDay englishDay = EnglishDay.Thusday;
        if (englishDay == EnglishDay.Saturday || englishDay == EnglishDay.Sunday)
        {
            Console.WriteLine("하루죙일 놀아라"); 
        }

        Border b = Border.Top | Border.Bottom;
        if ((b & Border.Top) != 0)
        {
            if (b.HasFlag(Border.Bottom))
            {
                Console.WriteLine(b.ToString());
            }
        }
        b = Border.Top | Border.Left | Border.Bottom | Border.Right;
    }
    static async Task StringSample()
    {
        string s1 = "C#";
        string s2 = "Programing";

        string s3 = s1 + " " + s2;
        // Console.WriteLine("String : {0} {1}", s1, s2);
        // Console.WriteLine($"String : {s1} {s2}");

        string s3sub = s3.Substring(1, 5);
        // Console.WriteLine("Sub : {0}", s3sub);

        string s = "C# Studies";
        // for (int i = 0; i < s.Length; i++)
        // {
        //     Console.WriteLine("{0} : {1}", 1, s[i]);
        // }

        string str = "Hello";
        char[] charArray = str.ToCharArray();
        for (int i = 0; i < charArray.Length; i++)
        {
            // Console.WriteLine(charArray[i]);
        }
        
        char[] charArr2 = ['A', 'B', 'C', 'D'];
        s = new string(charArr2);
        // Console.WriteLine(s);

        char c1 = 'A';
        char c2 = (char)(c1 + 3);
        // Console.WriteLine(c2);

        StringBuilder sb = new StringBuilder();
        string s6 = "";
        for (int i = 1; i <= 26; i++)
        {
            // sb.Append(i.ToString());
            // sb.Append(System.Environment.NewLine);
            s6 += i.ToString();
            s6 += System.Environment.NewLine;
        }
        // string s5 = sb.ToString();

        Console.WriteLine(s6);
    }
    static void CodingGuide()
    {
        /*
        int sum = 0;
        bool condition = false;
        if (condition)
        {
            sum++;
        } 
        else
        {
            sum--; 
        }
        for (int i = 0; i < 100; i++)
        {
            ArraySample2();
            ArraySample();
        }

        int category = 1;

        switch (category)
        {
            case 0: 
                ArraySample();
                break;
            case 1:
                {
                    int n = 1;
                    ArraySample2();
                }
                break;
        }
        */

        bool isValid = false;
        int a = 0, b = 0;
        // if (isValid == true) a = 2;
        if (isValid) a = 2;

        // if (isValid == false) b = 2;
        if (!isValid) b = 2;

        Console.WriteLine("a : {0}, b : {1}", a, b);
            
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
