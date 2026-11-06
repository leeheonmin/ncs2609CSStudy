class Customer // VIP 개념이 겉으로 보이지 않음
{
    public string Name;
    protected bool isVIP;

    public Customer(string name, bool isVIP)
    {
        Name = name;
        this.isVIP = isVIP;
    }

    public void ShowPublicInfo()
    {
        Console.WriteLine($"고객명: {Name}");
    }
}

// 회사 내부용 클래스
class CustomerManager : Customer
{
    public CustomerManager(string name, bool isVIP) : base(name, isVIP){}

    public void ShowInternalInfo()
    {
        string grade = isVIP ? "VIP" : "일반";
        Console.WriteLine($"[내부용] {Name} 고객 등급: {grade}");
    }
}