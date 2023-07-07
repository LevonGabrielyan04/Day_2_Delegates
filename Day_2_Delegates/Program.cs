class Task2Event
{
    public static event Action OnClicked;
    public static Task WatchKeysTask = new Task(WatchKeys);
    static void WatchKeys()
    {
        Console.ReadKey();
        OnClicked();
    }

}



class Task5Event
{
    public static event Action<object,Task5EventArgs> BalanceRefillEvent;
    public void BalanceRefill(Task5EventArgs args)
    {
        BalanceRefillEvent(this, args);
    }
}
class Task5EventArgs : EventArgs
{
    public int RefillAmount;
    public string PhoneNumber;
    public Task5EventArgs(int refill, string phone)
    {
        RefillAmount = refill;
        PhoneNumber = phone;
    }
}



class Program
{
    
    static void Main()
    {
        //Task1
        //Action<string> del1 = (a) => { Console.WriteLine(a); };
        //del1("Hello");

        //Task2
        //Task2Event.OnClicked += () => { Console.WriteLine("An event happened"); };//AddHandler
        //Task2Event.WatchKeysTask.Start();
        //Thread.Sleep(10000);

        //Task3
        //Func<int,int,int> OperationDelegate = delegate(int x,int y) { return x + y; };
        //Console.WriteLine(OperationDelegate(1,2));
        //OperationDelegate = delegate(int x, int y) { return x - y; };
        //Console.WriteLine(OperationDelegate(1,2));

        //Task4
        //Func<int,int,int> Comparation = (x, y) =>
        //{
        //    if(x > y) return 1;
        //    else if(x == y) return 0;
        //    else if(x < y) return -1;
        //    return 404;
        //};

        //Task5
        //Task5Event.BalanceRefillEvent += (obj, args) => { Console.WriteLine(args.PhoneNumber + " refilled " + args.RefillAmount) ; };
        //Task5Event ts = new Task5Event();
        //ts.BalanceRefill(new Task5EventArgs(60000,"096420414"));
    }
}