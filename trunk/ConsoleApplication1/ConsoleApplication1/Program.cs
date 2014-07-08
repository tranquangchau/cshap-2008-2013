// mo file want shortcut va doc file shortcut do @@ ok
using System;
using System.Collections.Generic;
using System.Diagnostics;  // thu vien Process.Start
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        //public string chau = "want"; 
        static void Main(string[] args)
        {
            Console.WindowHeight = 15;
            Console.WindowWidth = 17;
            int i = 1;
           
            while (i!=0)
            {
                dongfile();
                mofile();                                            
            }
            
        }

        private static void mofile()
        {
            try
            {
                //i = int.Parse(Console.ReadLine());                    
                //if (i == 1)
                //{
                Console.WriteLine(DateTime.Now.ToString());
                Process pro = new Process();
                pro.StartInfo.FileName = "want";
                pro.Start();
                System.Threading.Thread.Sleep(300000);
                
                //}
                //if (i==2)
                {


                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }    
        }

        private static void dongfile()
        {
            try
            {
                foreach (Process proc in Process.GetProcessesByName("want"))
                {
                    proc.Kill();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}