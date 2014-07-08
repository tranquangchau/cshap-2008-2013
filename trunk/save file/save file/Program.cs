using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace save_file
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"d:\test\test.txt";
            // This text is added only once to the file. 
            if (!File.Exists(path))
            {
                // Create a file to write to. 
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Hello1");
                    sw.WriteLine("And1");
                    sw.WriteLine("Welcome1");
                }
            }

            // This text is always added, making the file longer over time 
            // if it is not deleted. 
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("This1");
                sw.WriteLine("is Extra1");
                sw.WriteLine("Text1");
            }

            // Open the file to read from. 
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }

        }
    }
}
