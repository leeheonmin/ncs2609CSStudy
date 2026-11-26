using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
namespace MyClass;


public class MyCustomer
{
    // 필드/field : private은 생략하는 추세
    // 필드 초기값 생략 가능
    string name = string.Empty;
    int age = 0;
    public bool isMen = false;

    // 이벤트/Event
    public event EventHandler NameChanged;

    // 생성자/Constructor : class의 이름과 같고, 반환값은 없다
    public MyCustomer() // 생성자 내부에서는 필드들의 값들을 초기화 한다.
    {
        name = "홍길동";
        age = -1;
        isMen = true;
    }

    // 또 다른 생성자 (overload 사용)
    public MyCustomer (string name, int age, bool isMen)
    {
        this.name = name;
        this.age = age;
        this.isMen = isMen;
    }
    
    // 소멸자/Destructor : 있긴하다

    // 속성/property
    public string Name
    {
        get { return this.name; }
        set
        {
            if (this.name != value)
            {
                this.name = value;
                if (NameChanged != null)
                {
                    NameChanged(this, EventArgs.Empty);
                }
            }
        }
    }

    public int Age
    {
        get { return this.age; }
        set { this.age = value;
            
        }
    }

    // 메서드/method
    public string GetCustomerData()
    {
        string sex = this.isMen ? "남" : "여";
        // string data = string.Format("이름 : {0}, 나이 : {1}, 성별 : {2}", this.name, this.age, sex);
        string data = $"이름 : {name}, 나이 : {age}, 성별 : {sex}";
        return data;
    }

}