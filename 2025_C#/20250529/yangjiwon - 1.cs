using System;

namespace MyCompiler {

    class Student{
        public string Name;
        public double Score;

        public Student(string str, double num){
            this.Name = str;
            this.Score = num;
        }

        public char GetGrade(double num){
            char Grade;
            
            if(num >= 90){
                Grade = 'A';
            }
            else if(num >= 80){
                Grade = 'B';
            }
            else if(num >= 70){
                Grade = 'C';
            }
            else if(num >= 60){
                Grade = 'D';
            }
            else {
                Grade = 'F';
            }
            return Grade;
        }
    }
    
    class Program {
        public static void Main(string[] args) {
            Student one = new Student("Charles", 87.5);
            
            Console.Write("Name: "+ one.Name+ ", ");
            Console.Write("Score: "+ one.Score+ ", ");
            Console.WriteLine("Grade: "+ one.GetGrade(one.Score));
        
        }
    }
}