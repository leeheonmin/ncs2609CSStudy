using System.Data;
using System.Data.Common;
using System.Data.SqlTypes;
using System.Threading.Tasks.Dataflow;

public interface IComparable
{
    int CompareTo(object obj);
}

public class MyClass5 : IComparable
{
    int key;
    int value;
    public int CompareTo(object obj)
    {
        MyClass5 target = (MyClass5)obj;
        return this.key.CompareTo(target.key);
    }

    public IDbConnection GetDbConnection()
    {
        IDbConnection dbConn = null;
        string cn = "Connection";
        switch (cn)
        {
            case "SQLServer":
                // dbConn = new SqlConnection();
                break;
            case "Oracle":
                break;
            case "OleDB":
                break;
        }
        return dbConn;
    }
}