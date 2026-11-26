using System.IO.Compression;

class MyStack<T> // where T : new() 와 같이 제약을 두고 사용하는 경우도 있다.
{
    // Genric의 지정 문자의 경우 직접 사용할때 그 형태가 결정이 된다.
    T[] _elements;
    int pos = 0;

    public MyStack()
    {
        _elements = new T[100];
    }

    public void Push(T element)
    {
        _elements[++pos] = element;
    }

    public T Pop()
    {
        return _elements[pos--];
    }
}