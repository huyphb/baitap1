using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap tong so sinh vien N =");
            int n = int.Parse(Console.ReadLine());
           

            List<SinhVien> listStudent = new List<SinhVien>();
            Console.WriteLine("\n ===NHAP DS SINH VIEN====");
            for (int i = 0; i < n; i++)
            {
                SinhVien temp = new SinhVien();
                temp.Input();
                listStudent.Add(temp);
            }

            Console.WriteLine("\n ===XUAT DS SINH VIEN===");
            foreach (SinhVien sv in listStudent)
            {
                sv.Show();
            }
        }
    }
}
