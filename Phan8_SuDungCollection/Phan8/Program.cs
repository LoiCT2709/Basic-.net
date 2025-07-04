﻿
namespace Phan8
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //Viet chuong trinh nhap vao danh sach cac string roi in ra
           var list = new List<string>();
            ReadString(list);
            Print(list);
            Sort(list);
            Print(list);
        }

        private static void Sort(List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i; j < list.Count; j++)
                {
                    if (list[i].CompareTo(list[j])>0)
                    {
                        var s = list[i];
                        list[i] = list[j];
                        list[j] = s;
                    }
                }
            }
        }

        private static void Print(List<string> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        private static void ReadString(List<string> list)
        {
            string? s;
            do
            {
                s = Console.ReadLine();
                if (!string.IsNullOrEmpty(s))
                {
                    list.Add(s);
                }
            }while (!string.IsNullOrEmpty(s));
        }
    }
}
