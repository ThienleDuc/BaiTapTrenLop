using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap_1_4_bai_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Le Duc Thien - 22115053122138");

            int[] scores_138 = { 85, 90, 78, 92, 88, 76, 95, 89, 84, 91 };

            Console.WriteLine($"Max: {scores_138.Max()}");
            Console.WriteLine($"Min: {scores_138.Min()}");
            Console.WriteLine($"Sum: {scores_138.Sum()}");
            Console.WriteLine($"Average: {scores_138.Average():F2}");
            Console.ReadLine();
        }
    }
}
