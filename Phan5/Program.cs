namespace Phan5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int x = 5;
            int y = 10;
            Console.WriteLine(DemoParameters(x, ref y));
            Console.WriteLine($"Main.x = {x}");
            Console.WriteLine($"Main.y = {y}");
        }
        //Method
        public static int DemoParameters (int x,ref int y) //ref thay đổi ref của biến đó luôn thay vì tạo ra bản copy
        {
            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y}");
            x = 100;
            y = 200;
            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y}");
            return x + y;
        }
        //Không trả về gì hết:
        //tên hàm thường bắt đầu bằng động từ
        private void LocalMethod()
        {

        }
    }
}
