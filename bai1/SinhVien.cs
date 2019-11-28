using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    class SinhVien
    {
        private string studentID;
        private string fullName;
        private float averageScore;
        private string faculty;

        public string StudentID { get; set; }
        public string FullName { get; set; }
        public float AverageScor { get; set; }
        public string Faculty { get; set; }

        public SinhVien()
        {

        }

        public SinhVien(string id, string name, float score, string faculty)
        {
            studentID = id;
            fullName = name;
            averageScore = score;
            faculty = faculty; 
        }
        
        public void Input()
        {
            Console.Write("Nhap MSSV: ");
            StudentID = Console.ReadLine();

            Console.Write("Nhap Diem: ");
            AverageScor = float.Parse(Console.ReadLine());

        }
        public void Show()
        {
            Console.WriteLine("MSSV: {0} Ho Ten:{1} Khoa:{2} DiemTB:{3}", this.StudentID, this.FullName, this.Faculty, this.AverageScor);
        }
            
        
    }


}
