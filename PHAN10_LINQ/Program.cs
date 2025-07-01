namespace PHAN10_LINQ
{
    public class Program
    {

        //Tạo một collection:

        static void Main(string[] args)
        {
            var dataSource = GetIntNumbers();
            Print(dataSource);
            Console.WriteLine("Su dung LINQ ");
            //Su dung LINQ:
            //1. Querry syntax
            var ns = from n in dataSource 
                     where GreaterThan(n) && n%2 ==0
                     select n;
            Console.ReadLine();
            Print(ns);
            //2. Method syntax:
            /* var ms = dataSource.Where(n=>GreaterThan(n)&& n%2==0);
             Print(ms);*/
            Console.WriteLine("--------------------------");
            //Tinh Tong
            Console.WriteLine(ns.Count());
            

        }
        static bool GreaterThan(int n)
        {
            //Console.WriteLine($"{n}>0 =={n > 0}");
            return n > 0; 
        }
        static IEnumerable<int> GetIntNumbers()
        {
            var ms = new int[] { 267, 567, 290, 788, 124, 236, 456, 984567 };
            return ms;

        }
        //Viet ham in ket qua:
        static void Print(IEnumerable<int> values)
        {
            Console.WriteLine("--------------------------");
            foreach (var value in values)
            {
                Console.WriteLine($"{value}");
            }
        }
    }
}
