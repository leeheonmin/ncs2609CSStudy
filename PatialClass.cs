partial class Pclass
{
    public void Run() {}

}

partial class Pclass
{
    public void Get(int a) {}
}

partial class Pclass
{
    public void Put() {}
}

partial struct Pstruct
{
    public int ID;
}
partial struct Pstruct
{
    public string Name;
    public Pstruct(int id, string name)
    {
        this.ID = id;
        this.Name = name;
    }
}

partial interface IDoable
{
    string Name { get; set; }
}

partial interface IDoable
{
    void Do();
}

public class DoClass : IDoable
{
    public string Name { get; set; }
    public void Do()
    {
        
    }
}

public partial class Pclass2
{
    public void Run() 
    {
        DisplayNowTime();
    }

    partial void DisplayNowTime();
}

public partial class Pclass2
{
    partial void DisplayNowTime()
    {
        Console.WriteLine(DateTime.Now);
    }
}