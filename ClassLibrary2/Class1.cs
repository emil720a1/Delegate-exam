namespace ClassLibrary2;

public delegate void Notify(string message);

class Notifer
{
    public event Notify? _Notify;
    public void Send(string message)
    {
        _Notify?.Invoke(message);
    }
}

class Program
{

    static void Main(string[] args)
    {
        var notify = new Notifer();
        notify._Notify += (msg) => Console.WriteLine($"Log: {msg}");
        notify.Send("Hello");
        notify._Notify += (msg) => Console.WriteLine($"Email: {msg}");
        notify.Send("@gmail.com");
        
        
        
    }

    static void ShowMsg(string s)
    {
        Console.WriteLine(s);
    }

}