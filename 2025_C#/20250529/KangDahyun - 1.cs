    class Student
    {
        public string Name;    //변수
        public double Score;

        public Student(string Name, double Score)   //생성자
        {
            this.Name = Name;
            this.Score = Score;
        }

        public char Grade = 'x';
        public char GetGrade()  //메소드 :뭔가의 출력 값이 나와야함 
        {
            if (Score >= 90)
            {
                Grade = 'A';
            }
            else if (Score >= 80)
            {
                Grade = 'B';
            }
            else if (Score >= 70)
            {
                Grade = 'C';
            }
            else if (Score >= 60)
            {
                Grade = 'D';
            }
            else
            {
                Grade = 'F';
            }
            return Grade;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("유희왕", 99.9);

            Console.WriteLine("이름: " + student.Name + ", 점수: " + student.Score + ", 등급: " + student.GetGrade());
        }
    }
