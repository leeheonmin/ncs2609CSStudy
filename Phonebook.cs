class Phonebook
{
    Dictionary<string, string> numbers = new();
    
    public string this[string name]
    {   
        get { return numbers[name]; }
        set { numbers[name] = value; }
    }
}