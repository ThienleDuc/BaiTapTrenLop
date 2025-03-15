using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list_138 = new ArrayList();
            list_138.Add(10);            
            list_138.Add(3.14);          
            list_138.Add("Xin chao");       
            list_138.Add(true);          
            list_138.Add(DateTime.Now);  

            foreach (var item in list_138)
            {
                Console.WriteLine($"Gia tri: {item}, Kieu du lieu: {item.GetType()}");
            }

            Console.ReadLine();
        }
    }
}
