using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_string1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string st = "chau tran";
            //string s1="";
           // string s5="chau tran quang"; 
            //string s1=              
            

            Console.ReadKey();
            //string st = "chaunghean tran quang ";            
            //string st1 = st.Substring(2,4);
            //int st2 = st.IndexOf(" ");
            //Console.WriteLine(st+'\n');
            //string st3 = st.Substring(0, st.IndexOf(" "));
            //Console.WriteLine(st1);
            //Console.WriteLine(st3);
            
            
        }
        private string daochuoi(string s1)
        {
            string s2 = "";
            for (int i1 = 0; i1 < s1.Length; i1++)
            {
                s2 = s2 + s1[s1.Length - i1 - 1].ToString();
            }
            return s2;

        }
    }
}
