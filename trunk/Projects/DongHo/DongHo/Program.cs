using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace DongHo
//from video http://www.youtube.com/watch?v=jPJ9zf1u8r4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Casio!!");
            int n = 0;
            while (n == 0)
            {
                DateTime now = DateTime.Now;
                Console.WriteLine(now);
                Console.WriteLine(now.ToLongDateString());
                Console.WriteLine(now.Year);
                Console.WriteLine(now.Second);
                Thread.Sleep(1000);
                Console.Clear();
            }
            
            Console.ReadLine();
        }
    }
}
