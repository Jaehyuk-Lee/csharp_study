namespace ObjectMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // 객체 생성
            A a = new A();
            B b = new B();

            // 메서드 호출
            Console.Write("%x\n", a.GetHashCode()); // hashcode를 16진수로 표현
            Console.WriteLine(a.ToString());
            Console.WriteLine(b.ToString());

            E e = E.GetInstance();
            E e2 = E.GetInstance();
            Console.WriteLine(e.GetHashCode());
            Console.WriteLine(e2.GetHashCode());
            if (e == e2)
            {
                Console.WriteLine("같은 객체입니다.");
            }
        }
    }

    class A
    {
        int a = 3;
        int b = 4;
    }

    class B
    {
        int a = 3;
        int b = 4;

        public override String ToString()
        {
            return "필드값(a, b) = " + a + " " + b;
        }
    }

    abstract class C
    {
        public abstract void Abc();
    }

    class D : C
    {
        public override void Abc()
        {
            Console.WriteLine("D.Abc");
        }
    }

    class E
    {
        private static readonly E e = new E();

        private E()
        {

        }

        public static E GetInstance()
        {
            return e;
        }
    }
}