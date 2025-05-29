using System;

namespace MyCompiler {

    class Student{
        public string Name;
        int Age;
        public double Score;
        
        public Student(string name, int age, double score){
            this.Name = name;
            this.Age = age;
            this.Score = score;    
        }

        public void Print(){
            Console.Write("Name: "+Name+", ");
            Console.Write("Age: "+Age+", ");
            Console.WriteLine("Score: "+Score);
        }
    }
    
    class Classroom{
        Student[] students = new Student[3];

        int count = 0;
        public double max = 0;
        string top;
        
        public void AddStudent(Student student){
            students[count] = student;
            count++;
        }

        public void PrintAllStudents(){
            for(int i=0; i<students.Length; i++){
                students[i].Print();
            }
        }

        public double GetAverageScore(){
            double avg = 0;
            
            for(int i=0; i<students.Length; i++){
                avg += students[i].Score;
            }

            return avg/3;
        }

        public string GetTopStudent() {
            for(int i=0; i<students.Length; i++){
                if(students[i].Score > max){
                    max = students[i].Score;
                    top = students[i].Name;
                }
            }
            
            return top;
        }
    }
    class Program {
        public static void Main(string[] args) {
            Classroom cl = new Classroom();
            
            Student st1 = new Student("KimYuna",21,95.5);
            Student st2 = new Student("YooJaeseok",17,88.0);     
            Student st3 = new Student("JangWonyoung",20,92.3); 
            
            cl.AddStudent(st1);
            cl.AddStudent(st2);
            cl.AddStudent(st3);

            cl.PrintAllStudents();
            Console.WriteLine("Total Average Score: " + cl.GetAverageScore());
            Console.WriteLine("Best Score Student: "+ cl.GetTopStudent()+"("+cl.max+")");
            
        }
    }
}