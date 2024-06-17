class Program
{
    static void Main(string[] args)
    {
        Mutex mutex = new Mutex(false, "MyMutex", out bool isOne);

        if (isOne)
        {
            Console.WriteLine("All good");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Application is already running");
            Console.ReadLine();
        }
    }
}