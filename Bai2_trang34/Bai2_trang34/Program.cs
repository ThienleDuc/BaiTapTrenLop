using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_trang34
{
    // Lớp Human
    class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Human(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }

    // Lớp Student kế thừa từ Human
    class Student : Human
    {
        public int Grade { get; set; }

        public Student(string firstName, string lastName, int grade)
            : base(firstName, lastName)
        {
            Grade = grade;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Grade: {Grade}");
        }
    }

    // Lớp Worker kế thừa từ Human
    class Worker : Human
    {
        public double WeekSalary { get; set; }
        public int WorkHoursPerDay { get; set; }

        public Worker(string firstName, string lastName, double weekSalary, int workHoursPerDay)
            : base(firstName, lastName)
        {
            WeekSalary = weekSalary;
            WorkHoursPerDay = workHoursPerDay;
        }

        public double MoneyPerHour()
        {
            return WeekSalary / (WorkHoursPerDay * 5); // Giả sử làm 5 ngày/tuần
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Luong tuan: {WeekSalary}, gio lam/ ngay: {WorkHoursPerDay}, tien/gio: {MoneyPerHour():F2}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Khởi tạo mảng gồm 10 đối tượng Human (5 Student, 5 Worker)
            Human[] humans = new Human[2]
            {
                new Student("Thien", "Le", 9),
                new Worker("Thien", "Le", 750, 8)
            };

            // Hiển thị thông tin từng đối tượng
            foreach (var human in humans)
            {
                human.DisplayInfo();
                Console.WriteLine("--------------------");
            }

            Console.ReadLine();
        }
    }
}
