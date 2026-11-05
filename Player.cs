using System.Dynamic;
using System.Security.Authentication;
using System.Security.Cryptography;

class Player
{
    int score = 100;
    // int Age;
    public string Name { get; set; } // 자동 구현
    public int Age { get; private set; } = 10;
    public string City { get; } = "Seoul";
    public int GoalScore { get; } = 100;
    public int Score 
    { 
        get { return score; } 
        set 
        { 
            if (value < 0) score = 0;
            else score = value;
        }
    }

    public int ResultScore { get; set; }


    public void Something()
    {
        // score = 0;
        // Name = "ABC";
        // Age = 10;
        
        // Console.WriteLine("{0}의 점수는 {1}", Name, Score);
        Console.WriteLine($"{Name}의 점수는 {Score}, {score}");
    }
 }