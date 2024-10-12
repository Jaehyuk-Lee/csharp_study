namespace ThreadExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread myThread = new Thread(Func);
            myThread.Start();
        }

        static void Func()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Hello from thread! " + i);
                Thread.Sleep(1000);
            }
        }
    }
}