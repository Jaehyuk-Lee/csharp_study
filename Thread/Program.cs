namespace ThreadExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t_start = new Thread(Func);
            Thread t_join = new Thread(Func);
            t_start.Start();
            t_start.Join();
            Console.WriteLine("t_start ended");
            t_join.Start();
            Console.WriteLine("t_join ended");

            Thread t_abort = new Thread(DoWork);
            t_abort.Start();

            Thread.Sleep(3000);

            if (t_abort.IsAlive)
            {
                Console.WriteLine("강제 종료");
                t_abort.Abort(); // 쓰레드 강제 종료 : .Net 5부터는 Obsolete, 사용하면 안됨
            }
            else
            {
                Console.WriteLine("정상 종료");
            }
        }

        static void Func()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Hello from thread! " + i);
                Thread.Sleep(1000);
            }
        }
        static void DoWork()
        {
            try
            {
                while (true)
                {
                    Console.WriteLine("쓰레드 실행 중...");
                    Thread.Sleep(1000); // 1초 대기
                }
            }
            catch (ThreadAbortException ex)
            {
                Console.WriteLine("쓰레드 종료 예외 발생");
                Console.WriteLine(ex.Message);
            }
        }
    }
}