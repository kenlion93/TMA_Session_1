using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSession1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------Caculator----------");
            Console.Write("Moi nhap so a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Moi nhap so b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            
            
            Console.WriteLine("1. Tinh tong");
            Console.WriteLine("2. Tinh hieu");
            Console.WriteLine("3. Tinh tich");
            Console.WriteLine("4. Tinh thuong");
            Console.Write("Moi ban chon phep tinh: ");
            int menu = Convert.ToInt32(Console.ReadLine());
            switch(menu)
            {
                case 1:
                    Console.WriteLine("Tong = "+ (a+b));
                    break;
                case 2:
                    Console.WriteLine("Hieu = "+ (a-b));
                    break;
                case 3:
                    Console.WriteLine("Tich = " + (a*b));
                    break;
                case 4:
                    Console.WriteLine("Thuong = " + (a / b));
                    break;
                default:
                    Console.WriteLine("Tuy chon khong hop le");
                    break;
            }

            /*
            Console.WriteLine("Tinh diem trung binh mon hoc");
            Console.Write("Nhap dien Toan: ");
            double toan = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap dien Ly: ");
            double ly = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap dien Hoa: ");
            double hoa = Convert.ToDouble(Console.ReadLine());

            double dtb = (toan * 3 + ly * 2 + hoa) / 6;
            Console.WriteLine("Diem trung binh mon hoc la: " + (toan * 3 + ly * 2 + hoa) +":6 = " + dtb);

            if (dtb >= 8)
            {
                Console.WriteLine("Gioi");
            }
             else if (dtb >= 7)
            {
                Console.WriteLine("Kha Gioi");
            }
            else if (dtb >=6)
            {
                Console.WriteLine("Kha");
            }
            else if (dtb >= 5)
            {
                Console.WriteLine("Trung Binh");
            }
            else
            {
                Console.WriteLine("Ren luyen them");
            }
            */
 
            /*
             Console.Write("Moi nhap thu: ");
            int thu = Convert.ToInt32(Console.ReadLine());
            if (thu == 2)
            {
                Console.WriteLine("Thu 2");
            }
            else if (thu == 3)
            {
                Console.WriteLine("Thu 3");
            }
            else if (thu == 4)
            {
                Console.WriteLine("Thu 4");
            }
            else
            {
                Console.WriteLine("Khong hop le");
            }
            */

            //int a = 4;
            //if(a>3 && a%2 == 0)
            //{
            //    Console.WriteLine("Valid");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid");
            //}

            //conditions ? result1: result2
            ////string result = (a > 3 && a % 2 == 0) ? "valid" : "invalid";
            ////Console.WriteLine(result);

            /*Console.Write("Nhap user name: ");
            string user = Console.ReadLine();
            Console.Write("Nhap password: ");
            string pwd = Console.ReadLine();

            if (user =="abc"&& pwd =="123")
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            Console.WriteLine();
            Console.WriteLine("---------Kiem tra diem toan hop le hay khong-----");
            Console.Write("Moi nhap dien toan: ");
            int diem =Convert.ToInt32(Console.ReadLine());

            string result2 = (diem >= 0 && diem <= 10) ? "hop le" : "khong hop le";
            Console.WriteLine("Diem " + diem + " la " + result2);
            */


            Console.WriteLine();
            Console.WriteLine("Done");
            /*
            Console.WriteLine("Tinh dien tich va chi vi hinh chu nhat");
            Console.Write("Nhap chieu dai: ");
            double a =Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap chieu rong: ");
            double b = Convert.ToDouble(Console.ReadLine());
            double dt = a * b;
            double cv = (a + b) * 2;
            Console.WriteLine("Dien tich = " + dt);
            Console.WriteLine("Chu vi = " + cv);
            //----------------------
            Console.WriteLine("----------------------");
            Console.WriteLine("Tinh diem trung binh mon hoc");
            Console.Write("Nhap dien Toan: ");
            double toan =Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap dien Ly: ");
            double ly = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap dien Hoa: ");
            double hoa = Convert.ToDouble(Console.ReadLine());

            double dtb = (toan * 3 + ly * 2 + hoa) / 6;
            Console.WriteLine("Diem trung binh mon hoc la: " + dtb);
            */
            
        
            /*string fullName;
            Console.Write("Input full name: ");
            fullName = Console.ReadLine();
            Console.WriteLine("Hello "+fullName);

            Console.Write("Input your age: ");
            int age =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(fullName+"'s age: "+age);

            Console.Write("Input price: ");
            double price =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Price: "+price);

            Console.Write("Input status: ");
            bool status =Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Status: " + status);*/


            Console.ReadLine();

            /*
            int a = 10;
            int b = 4;
            //and
            bool rs1 = a > 5 && b > 2;
            Console.WriteLine("Result 1: " + rs1);
            //or
            bool rs2 = a > 5 || b > 2;
            Console.WriteLine("Result 1: " + rs2);
            //not
            bool rs3 = !rs2;
            Console.WriteLine("Result 3: " + rs3);
            */
            /*
            bool rs1 = a > b;
            Console.WriteLine("Result 1: "+rs1);
            bool rs2 = a >= b;
            Console.WriteLine("Result 2: " + rs2);
            bool rs3 = a < b;
            Console.WriteLine("Result 3: " + rs3);
            bool rs4 = a <= b;
            Console.WriteLine("Result 4: " + rs4);
            bool rs5 = a == b;
            Console.WriteLine("Result 5: " + rs5);
            bool rs6 = a != b;
            Console.WriteLine("Result 6: " + rs6);
            */
            /*
            int result1 = a + b;
            int result2 = a - b;
            int result3 = a * b;
            Console.WriteLine("Result 1 = " + result1);
            Console.WriteLine("Result 2 = " + result2);
            Console.WriteLine("Result 3 = " + result3);
            double result4 = (float)a / b;
            int result5 = a % b;
            Console.WriteLine("Result 4 = " + result4);
            Console.WriteLine("Result 5 = " + result5);
            Console.WriteLine("----------------");
            a++;
            Console.WriteLine("A = " + a);
            b--;
            Console.WriteLine("B = " + b);
            Console.WriteLine("----------------");*/

            //int age = 20;
            //double price = 4.5;
            //bool status = true; // false
            //string fullName = "ABC";
            //char ch = 'a';
            //Console.WriteLine("Age: "+ age);
            //Console.WriteLine("Price: " + price);
            //Console.WriteLine("Status: " + status);
            //Console.WriteLine("Status: "+fullName);
            //Console.WriteLine("Hot key: "+ch);
        }
    }
}
