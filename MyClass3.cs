class Myclass3
{
    private delegate void RunDelegate(int i);

    private void RunThis(int val)
    {
        Console.WriteLine("{0}", val);
    }

    private void RunThat(int value)
    {
        Console.WriteLine("0x{0:x}", value);
    }

    public void Perform()
    {
        RunDelegate run = new RunDelegate(RunThis);
        // RunDelegate run = RunThis;
        // var run = RunThis;
        
        run(1024); // run.Invoke(1024);

        // run = new RunDelegate(RunThat);
        run = RunThat;
        run(1024);
    }
}