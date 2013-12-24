using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace giaitri
{
    class Program
    {
     
       private static string welcome="Nhap so nguyen Nhap c de tinh cong, t de tru, n de n, c1 de chia";
       private static string error = "Loi nhap lieu";
        static void Main(string[] args) // ham in ra cau gioi thieu va lua chon
        {
            byte[]  array=new byte[2];
            Random random = new Random();
            random.NextBytes(array);
            Display(array);
            int i = int.Parse(Console.ReadLine().Trim());
            if (i == phepcong(array))
            {
                Console.WriteLine("tuyet");
            }
            else
            {
                Console.WriteLine("tinh sai");
            }
            phepcongstr(array);
            Console.ReadKey();
            //random.NextBytes(array);
            //Display(array);
            //int i;            
            //while (i < 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //do
            //{
                //i = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Chau");
            //}
            //while (i < 1);
        }

        private static int phepcong(byte[] array)
        {
            int i = 0;
            foreach (byte value in array)
            {
                i = i + value;
            }
            return i;   
        }
        private static void phepcongstr(byte[] array)
        {
            int i = 0;
            foreach (byte value in array)
            {
                i = i + value;
            }
            Console.WriteLine(i);   
        }

        private static void Display(byte[] array)
        {
            foreach (byte value in array)
            {
                Console.WriteLine(value);
                
            }
            Console.WriteLine();
            Console.WriteLine(' ');
            Console.ReadKey();
        }
        
        public void switchtest()
        {
            Console.WriteLine(welcome);
            string str = Console.ReadLine();
            switch(str)
            {
                case "c":
                    Console.WriteLine("OK");
                    break;
                default:
                    Console.WriteLine(error);
                    break;
            }
            Console.ReadKey();
        }
    }
}
