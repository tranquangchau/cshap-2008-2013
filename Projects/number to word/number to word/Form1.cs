using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        //private string ChuyenSo(string number)
    //    {
    //    string[] dv = { "", "mươi", "trăm", "nghìn", "triệu", "tỉ"};
    //    string[] cs = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
    //    string doc;
    //    int i, j, k, n, len, found, ddv, rd;

    //    len = number.Length;
    //    number += "ss";
    //    doc = "";
    //    found=0;
    //    ddv=0;
    //    rd=0;

    //    i = 0;
    //    while (i < len)
    //    {
    //        //So chu so o hang dang duyet
    //        n = (len - i + 2) % 3 + 1;

    //        //Kiem tra so 0
    //        found = 0;
    //        for (j = 0; j < n; j++)
    //        {
    //            if (number[i + j] != '0')
    //            {
    //                found = 1;
    //                break;
    //            }
    //        }

    //        //Duyet n chu so
    //        if (found == 1)
    //        {
    //            rd = 1;
    //            for (j = 0; j < n; j++)
    //            {
    //                ddv=1;
    //                switch(number[i+j])
    //                {
    //                    case '0':
    //                        if (n-j==3) doc+=cs[0]+" ";
    //                        if (n-j==2)
    //                        {
    //                            if (number[i+j+1]!='0') doc+="lẻ ";
    //                            ddv=0;
    //                        }
    //                        break;
    //                    case '1':
    //                        if (n-j==3) doc+=cs[1] + " ";
    //                        if (n-j==2)
    //                        {
    //                            doc+="mười ";
    //                            ddv=0;
    //                        }
    //                        if (n-j==1)
    //                        {
    //                            if (i + j == 0) k = 0;
    //                            else k = i + j - 1;

    //                            if (number[k]!='1' && number[k]!='0')
    //                                doc += "mốt ";
    //                            else
    //                                doc+=cs[1]+" ";
    //                        }
    //                        break;
    //                    case '5':
    //                        if (i+j==len-1)
    //                            doc+="lăm ";
    //                        else
    //                            doc+=cs[5]+" ";
    //                        break;
    //                    default:
    //                        doc+=cs[(int)number[i+j]-48]+" ";
    //                        break;
    //                }

    //                 //Doc don vi nho
    //                if (ddv==1)
    //                {
    //                    doc+=dv[n-j-1]+" ";
    //                }
    //            }
    //        }
            

    //        //Doc don vi lon
    //        if (len-i-n>0)
    //        {
    //            if ((len - i - n ) % 9 == 0)
    //            {
    //                if (rd==1)
    //                    for (k = 0; k < (len - i - n) / 9; k++)
    //                        doc += "tỉ ";
    //                rd=0;
    //            }
    //            else
    //                if (found!=0) doc+=dv[((len-i-n+1)%9)/3+2]+" ";
    //        }

    //        i+=n;
    //    }

    //    if (len == 1)
    //        if (number[0] == '0' || number[0] == '5') return cs[(int)number[0] - 48];

    //    return doc;
    //}

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = NumberToWords(Convert.ToInt32(textBox1.Text));
            //int i = Convert.ToInt32(textBox1.Text);
            //label1.Text=ChuyenSo(textBox1.Text.ToString().Trim());
            //label1.Text=replace_special_word(join_unit(label1.Text)).ToUpper().Trim();

        }
        //private string join_unit(string n)
        //{
        //    int sokytu = n.Length;
        //    int sodonvi = (sokytu % 3 > 0) ? (sokytu / 3 + 1) : (sokytu / 3);
        //    n = n.PadLeft(sodonvi * 3, '0');
        //    sokytu = n.Length;
        //    string chuoi = "";
        //    int i = 1;
        //    while (i <= sodonvi)
        //    {
        //        if (i == sodonvi) chuoi = join_number((int.Parse(n.Substring(sokytu - (i * 3), 3))).ToString()) + unit(i) + chuoi;
        //        else chuoi = join_number(n.Substring(sokytu - (i * 3), 3)) + unit(i) + chuoi;
        //        i += 1;
        //    }
        //    return chuoi;
        //}


        //private string unit(int n)
        //{
        //    string chuoi = "";
        //    if (n == 1) chuoi = " đồng ";
        //    else if (n == 2) chuoi = " nghìn ";
        //    else if (n == 3) chuoi = " triệu ";
        //    else if (n == 4) chuoi = " tỷ ";
        //    else if (n == 5) chuoi = " nghìn tỷ ";
        //    else if (n == 6) chuoi = " triệu tỷ ";
        //    else if (n == 7) chuoi = " tỷ tỷ ";
        //    return chuoi;
        //}


        //private string convert_number(string n)
        //{
        //    string chuoi = "";
        //    if (n == "0") chuoi = "không";
        //    else if (n == "1") chuoi = "một";
        //    else if (n == "2") chuoi = "hai";
        //    else if (n == "3") chuoi = "ba";
        //    else if (n == "4") chuoi = "bốn";
        //    else if (n == "5") chuoi = "năm";
        //    else if (n == "6") chuoi = "sáu";
        //    else if (n == "7") chuoi = "bảy";
        //    else if (n == "8") chuoi = "tám";
        //    else if (n == "9") chuoi = "chín";
        //    return chuoi;
        //}


        //private string join_number(string n)
        //{
        //    string chuoi = "";
        //    int i = 1, j = n.Length;
        //    while (i <= j)
        //    {
        //        if (i == 1) chuoi = convert_number(n.Substring(j - i, 1)) + chuoi;
        //        else if (i == 2) chuoi = convert_number(n.Substring(j - i, 1)) + " mươi " + chuoi;
        //        else if (i == 3) chuoi = convert_number(n.Substring(j - i, 1)) + " trăm " + chuoi;
        //        i += 1;
        //    }
        //    return chuoi;
        //}


        //private string replace_special_word(string chuoi)
        //{
        //    chuoi = chuoi.Replace("không mươi không ", "");
        //    chuoi = chuoi.Replace("không mươi", "lẻ");
        //    chuoi = chuoi.Replace("i không", "i");
        //    chuoi = chuoi.Replace("i năm", "i lăm");
        //    chuoi = chuoi.Replace("một mươi", "mười");
        //    chuoi = chuoi.Replace("mươi một", "mươi mốt");
        //    return chuoi;
        //}

        //code moi
        public static string NumberToWords(int number)
        {
           
            if (number == 0)
                return "zero";
            if (number < 0)
                return "minus " + NumberToWords(Math.Abs(number));
            string words = "";
            if ((number / 1000000) > 0)
            {
                words += NumberToWords(number / 1000000) + " million ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += NumberToWords(number / 1000) + " thousand ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += NumberToWords(number / 100) + " hundred ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "")
                    words += "and ";

                var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                if (number < 20)
                    words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                        words += "-" + unitsMap[number % 10];
                }
            }

            return words;
        }

    }
}
