using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap_1_4_Bai_1_Trang_35
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Le Duc Thien - 22115053122138");

            List<string> DsSinhVien_138 = new List<string>
            { "An", "Binh", "Cuong", "Duong", "Hanh", "Huy", "Lan", "Linh", "Minh", "Nam" };

            // Chuyển List sang Array
            string[] arrSinhVien_138 = DsSinhVien_138.ToArray();
            Console.WriteLine("Mang sinh vien:");
            foreach (var sv_138 in arrSinhVien_138)
            {
                Console.WriteLine(sv_138);
            }

            // Chuyển Array về List
            List<string> listMoi = arrSinhVien_138.ToList();
            Console.WriteLine("\nDanh sach sinh vien tu mang:");
            foreach (var sv_138 in listMoi)
            {
                Console.WriteLine(sv_138);
            }

            Console.ReadLine();
        }
    }
}
