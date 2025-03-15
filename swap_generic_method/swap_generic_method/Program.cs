using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swap_generic_method
{
    class Program
    {
        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public override string ToString()
            {
                return $"Name: {Name}, Age: {Age}";
            }
        }

        static void Main(string[] args)
        {
            int x = 10, y = 20;
            Console.WriteLine($"Truoc khi swap: x = {x}, y = {y}");
            Swap(ref x, ref y);
            Console.WriteLine($"Sau khi swap: x = {x}, y = {y}\n");

            Person person1 = new Person { Name = "Duc Thien", Age = 21 };
            Person person2 = new Person { Name = "Duc Luong", Age = 15 };

            Console.WriteLine($"Truoc khi swap:\nPerson1: {person1}\nPerson2: {person2}");
            Swap(ref person1, ref person2);
            Console.WriteLine($"Sau khi swap:\nPerson1: {person1}\nPerson2: {person2}");

            Console.ReadLine();
        }
    }
}
