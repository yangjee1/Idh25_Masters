using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studiy
{
    class Student
    {
        public string Name;
        public double Score;

        public Student(string name, double score)
        {
            Name = name;
            Score = score;
        }

        public void GetGrade()
        {
            string grade;

            if (Score >= 90)
            {
                grade = "A";
            }
            else if (Score >= 80)
            {
                grade = "B";
            }
            else if (Score >= 70)
            {
                grade = "C";
            }
            else if (Score >= 60)
            {
                grade = "D";
            }
            else
            {
                grade = "F";
            }
            Console.WriteLine($"이름: {Name},점수: {Score}, 등급: {grade}");
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Student student = new Student("김민재", 87.5);

            student.GetGrade();
        }
    }
}
