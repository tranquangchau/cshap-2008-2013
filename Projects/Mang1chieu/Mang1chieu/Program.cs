using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mang
// ban luan  ve mang http://www.youtube.com/watch?v=pszp02wxjRs
    /*
        viết hàm xuất mảng 1 chiều các số thực
        viết hàm xuất mảng 1 chiều các số nguyên
        viết hàm liệt kê các giá trị chẵn trng 1 mảng 1 chiều các số nguyên
        viết hàm liệt kê các vị trí mà giá trị tại đó là giá trị âm trng mảng 1 chiều
        viết hàm tìm giá trị lớn nhat trong mang 1 chieu cac so thuc
        Tim gia tri duoc dau tien trong mang 1 chieu cac so thuc
        Tim so chan chuoi cung trong mang 1 chieu cac so nguyen
        Tim 1 vi tri ma gia tri tai do la gia tri nho nhat trong mang 1 chieu cac so thuc
        Tim vi tri cua gia tri chan dau tien trong mang 1 chieu cac so nguyen
        Tim vi tri so hoan thi cuoi cung trong mang 1 chieu cac so nguyen
        Hay tim gia tri duoi nho nhat trong mang cac so thuc
        Hay tim vi tri duong nho nhat trong mang 1 chieu cac so thc doan [0, n-1]
    */

{
    class Program
    {
        static void Main(string[] args)
        {            
            string[] mang = { "-1.53","3.6","6","-8"};
            kiemtranmang(mang);
            Console.ReadLine();
        }

        private static void kiemtranmang(string[] mang)
        {
            for (int n = 0; n < mang.Length; n++)
            {
                if (mang[n].Length >2)
                    Console.WriteLine(mang[n]+"\t");
            }
        }
    }
}
