using System.Text;

namespace Phan2
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*Khai báo một biến*//*
            int x, y, z;
            *//*Để dùng một biến ta cần có giá trị cơ bản cho biến*//*
            x = 0;
            Console.WriteLine(x);
            //String interpolation using $
            string s = $"hello {DateTime.Now}";
            Console.WriteLine(s);
            //Dùng stringBuilder để tối ưu tiết kiệm bộ nhớ ở phép cộng chuỗi
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(s);
            stringBuilder.Append(" ahhahah");
            Console.WriteLine(stringBuilder);
            //Sử dụng var để tự động thiết lập kiểu dữ liệu theo giá trị biến
            var t = 2;
            Console.WriteLine(t.GetType());
            //Nullable
            int? a;
            a = null; //dùng dấu hỏi để có thể gán null cho a.
            //Các giá trị cụ thể cũng chính là những object
            Console.WriteLine("abc2efdidjjeoijoiejeemeoefk".ToUpper()); */

            //Bài tập 1:Tạo một chương trình dạng Console, sử dụng .NET 8, cho phép nhập vào 5 số nguyên và in ra số lớn nhất trong 5 số (sử dụng cấu trúc if ()).
            int n;
            int max = int.MinValue;
            Console.WriteLine("So 1: ");
            n = int.Parse(Console.ReadLine());
            if (n > max)
            {
                max = n;
            }
            Console.WriteLine("So 2: ");
            n = int.Parse(Console.ReadLine());
            if (n > max)
            {
                max = n;
            }
            Console.WriteLine("So 3: ");
            n = int.Parse(Console.ReadLine());
            if (n > max)
            {
                max = n;
            }
            Console.WriteLine("So 4: ");
            n = int.Parse(Console.ReadLine());
            if (n > max)
            {
                max = n;
            }
            Console.WriteLine("So 5: ");
            n = int.Parse(Console.ReadLine());
            if (n > max)
            {
                max = n;
            }

            Console.WriteLine($"So lon nhat la: {max.ToString()}");
            //Hoàn toàn đặt tên biến bằng tiếng việt
            int mã = 2;
            Console.WriteLine(mã);
        }
    }
}
