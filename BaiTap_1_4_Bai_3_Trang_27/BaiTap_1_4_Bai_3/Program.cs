using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap_1_4_Bai_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Le Duc Thien - 22115053122138");

            int[] daySo_138 = { 10, 20, 30, 40, 50 };

            bool lonHon25_138 = daySo_138.Any(n => n > 25);
            bool tatCaLonHon5_138 = daySo_138.All(n => n > 5);

            Console.WriteLine($"Co so nao lơn hơn 25 khong? {lonHon25_138}");
            Console.WriteLine($"Tat ca cac so co lon hon 5 khong? {tatCaLonHon5_138}");

            Console.ReadLine();
        }
    }
}
