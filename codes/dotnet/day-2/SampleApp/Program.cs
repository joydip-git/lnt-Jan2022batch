class Program
{
    static void Main()
    {
        System.Console.WriteLine("welcome to C#");
        int a = 10;
        int b = 20;
        int res = Add(a, b);
        System.Console.WriteLine(res);
        string message = Messenger.SendMessage();
        System.Console.WriteLine(message);
    }
    //one function must do one job
    static int Add(int a, int b)
    {
        int addRes = 0;
        addRes = a + b;
        return addRes;
    }
}
