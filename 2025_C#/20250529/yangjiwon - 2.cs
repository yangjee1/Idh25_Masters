using System;

namespace MyCompiler {

    class Student{
        public string Name;
        public double Score;
        
        public Student(string str, double num){
            this.Name = str;
            this.Score = num;    
        }
    }
    
    class Program {
        public static void Main(string[] args) {
            Student[] students = new Student[5];

            double total = 0;
            double avg = 0;
            int count = 0;
        
            students[0] = new Student("김민재", 87.5);
            students[1] = new Student("이지은", 92.3);
            students[2] = new Student("유재석", 55.0);
            students[3] = new Student("정해인", 75.4);
            students[4] = new Student("장원영", 98.5);

            for(int i = 0; i<5; i++){
                total += students[i].Score;
                avg = total/5;

                if(students[i].Score >= 60){
                    count++;
                }
            }
            Console.WriteLine("total: " + total);
            Console.WriteLine("avg: " + avg);
            Console.WriteLine("pass: " + count);
        }
    }
}