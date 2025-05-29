using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace 코딩스터디_1
{
    class Student
    {
        public string name;
        public double score;

        public Student(string name, double score)
        {
            this.name = name;
            this.score = score;
        }
    }
    

    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[5];
            students[0] = new Student("김민재", 87.5); //배열인데 Student형 값만 넣을 수 있음
            students[1] = new Student("이지은", 92.3);
            students[2] = new Student("유재석", 55.0);
            students[3] = new Student("정해인", 75.4);
            students[4] = new Student("장원영", 98.5);

            double total = 0;
            double average = 0;
            int pass = 0;

            //총점 구하기
            for (int i = 0; i < 5; i++)
            {
                total += students[i].score;
            }

            //평균 점수 구하기
            average = total / 5;

            //합격자 수 구하기
            for (int i = 0; i < 5; i++)
            {
                if (students[i].score >= 60)
                    pass ++;

            }

            //출력
            Console.WriteLine("총점: " + total + "점");
            Console.WriteLine("평균: " + average + "점");
            Console.WriteLine("합격자 수: " + pass + "명");
        }
    }
}
 
