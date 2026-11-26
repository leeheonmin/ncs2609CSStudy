class Scores
{
    private int[] data = new int[5];

    // Property
    public int[] Data
    {
        get { return data; }
        set { data = value; }
    }

    // Indexer
    public int this[int index]
    {
        get 
        {
            if (index < 0 || index >= data.Length)
                return -1;
            return data[index]; 
        }
        set 
        {
            if (index >= 0 || index < data.Length)
                data[index] = value;
        }
    }
}