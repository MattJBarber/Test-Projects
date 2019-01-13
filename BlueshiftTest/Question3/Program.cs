using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test 1:");
            var test1 = new Smoothing(new List<float> { 50, 60, 40, 30, 90, -5, 40, 50, 30, 40 }, 3, 0.4F);
            for (int i=0;i<test1.s.Count;i++)
                Console.WriteLine(test1.s.ElementAt(i));

            Console.WriteLine("Test 2:");
            var test2 = new Smoothing(new List<float> { 15, 20, 16, 90, -90, -5, 17, 19, 16, 18 }, 4, 0.5F);
            for (int i = 0; i < test2.s.Count; i++)
                Console.WriteLine(test2.s.ElementAt(i));

            Console.ReadLine();

        }
    }
}
