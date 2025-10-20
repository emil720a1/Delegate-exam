namespace ClassLibrary2;

public delegate void Notify(string message);

// class Notifer
// {
//     public event Notify? _Notify;
//     public void Send(string message)
//     {
//         _Notify?.Invoke(message);
//     }
// }

class Program
{

    static void Main(string[] args)
    {
        // var notify = new Notifer();
        // notify._Notify += (msg) => Console.WriteLine($"Log: {msg}");
        // notify.Send("Hello");
        // notify._Notify += (msg) => Console.WriteLine($"Email: {msg}");
        // notify.Send("@gmail.com");
        
        Action<int> print = (y) => Console.WriteLine(y);
        List<int> numbers = new() {1, 2 ,3, 4, 5, 6, 7, 8, 9, 10};
        
        numbers.Sort((a, b) => b.CompareTo(a));
        numbers.ForEach(print);
    }

    // static void ShowMsg(string s)
    // {
    //     Console.WriteLine(s);
    // }

}