using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_trang34
{
    class Program
    {
        abstract class Figure
        {
            public abstract double CalculateArea();
        }

        // Lớp Circle kế thừa từ Figure
        class Circle : Figure
        {
            public double Radius { get; set; }

            public Circle(double radius)
            {
                Radius = radius;
            }

            public override double CalculateArea()
            {
                return Math.PI * Radius * Radius;
            }
        }

        // Lớp Square kế thừa từ Figure
        class Square : Figure
        {
            public double Side { get; set; }

            public Square(double side)
            {
                Side = side;
            }

            public override double CalculateArea()
            {
                return Side * Side;
            }
        }
        static void Main(string[] args)
        {
            // Khởi tạo các đối tượng hình học
            Figure circle = new Circle(5);
            Figure square = new Square(4);

            // Hiển thị kết quả
            Console.WriteLine($"Dien tich hinh tron: {circle.CalculateArea():F2}");
            Console.WriteLine($"Dien tich hinh vuong: {square.CalculateArea():F2}");
            Console.ReadLine();
        }
    }
}
