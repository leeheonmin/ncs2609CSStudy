using System.Runtime.CompilerServices;

class MyButton
{
    public string Text;
    private EventHandler _click;

    public event EventHandler Click
    {
        add
        {
            _click += value;
        }
        remove
        {
            _click -= value;
        }
    }

    public void MouseButtonDown()
    {
        if (this._click != null)
        {
            _click(this, EventArgs.Empty);
        }
    }

    // public void MouseButtonDown()
    // {
    //     if (this.Click != null)
    //     {
    //         Click(this, EventArgs.Empty);
    //     }
    // }
}



