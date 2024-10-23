namespace Generic_Example
{
    class StructArray<T> where T : struct
    {
        public T[] Array { get; set; }
        public StructArray(int size)
        {
            Array = new T[size];
        }
    }

    class classTest
    {
        private int _value { get; set; } = 0;
    }

    class RefArray<T> where T : class
    {
        public T[] Array { get; set; }
        public RefArray(int size)
        {
            Array = new T[size];
        }
    }

    class Base { }
    class Derived : Base { }
    class BaseArray<U> where U : Base
    {
        public U[] Array { get; set; }
        public BaseArray(int size)
        {
            Array = new U[size];
        }

        public void CopyArray<T>(T[] source) where T : U
        {
            source.CopyTo(Array, 0);
        }
    }

    interface IBase
    {
        void Print();
    }
    class DerivedFromInterface : IBase
    {
        public void Print()
        {
            Console.WriteLine("Hello World");
        }
    }
    class BaseArrayFromInterface<T> where T : IBase
    {
        public T[] Array { get; set; }
        public BaseArrayFromInterface(int size)
        {
            Array = new T[size];
        }
    }

    class Program
    {
        // Generic Method
        static void CopyArray<T>(T[] source, T[] target)
        {
            for (int i = 0; i < source.Length; i++)
            {
                target[i] = source[i];
            }
        }

        static string ArrayToString<T>(T[] target)
        {
            string result = "";
            foreach (T item in target)
            {
                if (item == null)
                {
                    result += "null ";
                    continue;
                }
                result += item.ToString() + " ";
            }
            return result;
        }

        // 기본 생성자가 있는 클래스만 생성 가능
        public static T CreateInstance<T>() where T : new()
        {
            return new T();
        }

        static void Main(string[] args)
        {
            int[] sourceInt = { 1, 2, 3, 4, 5 };
            string[] sourceString = { "one", "two", "three", "four", "five" };

            int[] targetInt = new int[5];
            string[] targetString = new string[5];

            CopyArray(sourceInt, targetInt);
            CopyArray(sourceString, targetString);

            Console.WriteLine(ArrayToString(targetInt));
            Console.WriteLine(ArrayToString(targetString));

            StructArray<int> intArray = new StructArray<int>(5);
            List<int> intList = new List<int>();
            // where T : struct 하면 null값이 올 수 있는 것들은 허용하지 않음.
            // 값형식만 올 수 있다고 하는데 이건 참조하는 방식이 아닌 애들을 말함.
            // Java의 Primitive Type이라고 생각하면 편할듯
            // StructArray<classTest> testArray = new StructArray<classTest>(5);

            RefArray<StructArray<double>> b = new RefArray<StructArray<double>>(5);
            b.Array[0] = new StructArray<double>(5);
            b.Array[1] = new StructArray<double>(10);
            b.Array[2] = new StructArray<double>(1005);

            BaseArray<Base> c = new BaseArray<Base>(3);
            c.Array[0] = new Base();
            c.Array[1] = new Derived();
            c.Array[2] = CreateInstance<Base>();

            BaseArray<Derived> d = new BaseArray<Derived>(3);
            d.Array[0] = new Derived();
            // d.Array[0] = new Base(); // Base는 Derived의 부모이기 때문에 에러가 발생함
            d.Array[1] = CreateInstance<Derived>();
            d.Array[2] = CreateInstance<Derived>();

            BaseArrayFromInterface<IBase> e = new BaseArrayFromInterface<IBase>(3);
            e.Array[0] = new DerivedFromInterface();
            e.Array[1] = CreateInstance<DerivedFromInterface>();

            MyList<string> str_list = new MyList<string>();
            str_list[0] = "abc";
            str_list[1] = "def";
            str_list[2] = "ghi";
            str_list[3] = "jkl";
            str_list[4] = "mno";

            foreach (string str in str_list)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine();
        }
    }
}