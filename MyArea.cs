using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace CSStudy;

class MyArea : Form
{
    void button1_Click(object sender, EventArgs a)
    {
        MessageBox.Show("Button 1 Click");
    }

    public Label label = new Label();
    public MyArea()
    {
        // this.MouseClick += new EventHandler(button1_Click);

        this.MouseClick += delegate{ MyAreaClicked(); };
        label.Text = "";
        label.AutoSize = true;
        label.Location = new System.Drawing.Point(20, 20);
        Controls.Add(label);
    }

    public delegate void ClickDelegate(object sender);

    // public ClickDelegate MyClick;
    public event ClickDelegate MyClick;

    void MyAreaClicked()
    {
        if (MyClick != null)
        {
            MyClick(this);
        }
    }
}