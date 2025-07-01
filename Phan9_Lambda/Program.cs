namespace Phan9_Lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //lambda
            //expression lambda: Phuong thuc tra ve ket qua
            Func<int,int,int> sum = (int a, int b) => a + b;
            Console.WriteLine(sum(3, 4));
            //Statement Lambda
            Action<string, string> upper = (s, t) => { Console.WriteLine(s.ToUpper()); Console.WriteLine(t.ToUpper()); };
            upper("hello","nam");
            //Example:
            var A = Object(int a, int b) => a > b ? 0 : "A";

            //Example 2:
            int a = 100;
            int b = 200;
            Call((a, b) => a + b, a, b);

            //Example 3:
            int[] arr = { 234, 567, 8900, 245, 678, 212 };
            Call2((x) => x % 2 != 0, arr);

        }
        static void Call(Func<int, int, int> f,int a, int b )
        {
            Console.WriteLine(f(a, b));
        }
        static void Call2(Func<int, bool>g,int[] arr)
        {
            foreach (int i in arr)
            {
                if(g(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
