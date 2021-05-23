using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        
        static void SendMessage(object sender,PropertyEventArgs e)
        {
            Console.WriteLine($"In the object of myclass with name { (sender as MyClass).Name}: ");
            Console.WriteLine(e.Message);
        }
        static void Main(string[] args)
        {
            //List<int> ages = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };

            //var val =(from a in ages where a>4 orderby a ascending
            //    select a).ToList();
            // var val2 = ages.Select(x => x > 4);


            //var val3 = ages.Count(x => x > 6);
            //Console.WriteLine(val3) ;
            //foreach (var item in val2)
            //{
            //    Console.WriteLine(item);
            //}
            //ages[0] = 15;
            //ages.Add(8);
            //foreach (var item in val)
            //{
            //    Console.WriteLine(item) ;
            //}
            MyClass myClass = new MyClass(18, "Kanan", 2);
            myClass.PropertyChanged += SendMessage;
            myClass.Id = 3;
            myClass.Age=5;
        }
    }
}
