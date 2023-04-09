using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimGTLN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n,s=0,t=0;
            Console.WriteLine("Nhập số phần tử của mảng(1-20):");
            n=int.Parse(Console.ReadLine());
            while (n<1 || n > 20)
            {
                Console.WriteLine("Mời nhập lại:");
                n = int.Parse(Console.ReadLine());
            }
            int[] so;
            so = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Phần tử thứ {i+1}");
                so[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Mảng bạn nhập:");
            for (int i = 0; i < n; i++)
            {
             Console.WriteLine(so[i]);
            }
            for(int i = 0; i < n; i++)
            {
                if (s < so[i])
                {
                    s = so[i];
                    t = i+1;
                }
            }
            Console.Write($"Số lớn nhất trong mảng là {s} vị trí {t}");
            Console.ReadLine();
        }
    }
}
