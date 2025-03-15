using System;
using System.Collections.Generic;
using System.Linq;

namespace BaiTap_1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Le Duc Thien - 22115053122138");

            List<string> DsSinhVien_138 = new List<string>
            {
                "Thien", "Nhung", "Huyen", "Anh", "Quoc", "Yen", "Hoa", "Ha", "Nguyen", "Dinh",
                "Hoa", "Ngoc", "Hoang", "Hien", "Oan", "Phan", "Quyet", "trac", "Sang", "Tien"
            };

            int kichThuocTrang_138 = 5; 
            while (true)
            {
                Console.Write("Nhap so trang (1 - " + (DsSinhVien_138.Count / kichThuocTrang_138 + 1) + "): ");
                if (int.TryParse(Console.ReadLine(), out int pageNumber) && pageNumber > 0)
                {
                    var trangSinhVien_138 = DsSinhVien_138.Skip((pageNumber - 1) * kichThuocTrang_138).Take(kichThuocTrang_138).ToList();

                    if (trangSinhVien_138.Count == 0)
                    {
                        Console.WriteLine("Trang khong hop le.");
                    }
                    else
                    {
                        Console.WriteLine($"Danh sach sinh vien trang {pageNumber}:");
                        foreach (var student in trangSinhVien_138)
                        {
                            Console.WriteLine(student); 
                        }
                    }
                }
                else
                {
                    Console.WriteLine("So trang khong hop le. Vui long nhap lai.");
                }
            }
        }
    }
}
