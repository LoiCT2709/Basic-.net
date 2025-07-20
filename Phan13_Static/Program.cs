namespace Phan13_Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tom tat:
            /**
             * 1. Biến static gắn liền với class chứa nó và được tạo duy nhất 1 lần tồn tại đến khi kết thúc chương trình. Biến không phải static nó sẽ gắn liền với object
             * 2. Khi khai báo hàm là static, chỉ có thể truy cập vào biến static (vì hàm static gắn liền với class, không gắn liền với một object cụ thể, trong khi biến bình thường gắn liền với object cụ thể.
             * 3. Bất kì khi nào đặt được hàm là static thì hãy đặt static vì nó vừa tối ưu bộ nhớ
             * 4. Constructor static được gọi tự động khi class được sử dụng lần đầu tiên
             * 5.  Class static chỉ chứa các thành phần là static (hạn chế dùng, thường dùng khi viết extension method - là các method làm việc trên kiểu dữ liệu nào đó)
             * 6 Tạo extension method bằng cách: tạo một lớp static, tạo 1 hàm static, tham số nhận vào là this + kiểu dữ liệu + tên biến
             * 7.Vấn đề khi sử dụng static: khó kiểm soát vì có thể truy cập từ bất kì đâu trong chương trình, nếu thay đổi giá trị của nó sẽ ảnh hưởng đến tất cả những nơi sử dụng biến static này, dùng singleton pattern để khắc phục
             * 
             **/
            //Hàm khởi tạo:

            /*  var c1 = new C() { };
              var c2 = new C() { };

              Console.WriteLine(C.x);

              C.x = 999;
              Console.WriteLine(C.x);
              F1();
              Console.WriteLine(C.x);
              C.F();
              Console.WriteLine(C.x);*/

            //Phan2 
/*
            Person person = new Person() { Id = 1, Name = "Test" };

            person.Print();*/

            //Phan 3: Singleton
            for(int i = 0;i<5;i++)
            {
                Console.WriteLine(AccessCounter.GetInstance().Inc());
                
            }
        }
        /* static void F1()
         {
             C.x = 1234;
         }*/

       
    }
}
