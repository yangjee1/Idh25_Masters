using System;

class Student
{
    public string Name;
    public double Score;

    public Student(string name, double score)
    {
        Name = name;
        Score = score;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student[] students = new Student[5]
        {
            new Student("김민재", 87.5),
            new Student("이지은", 92.3),
            new Student("유재석", 55.0),
            new Student("정해인", 75.4),
            new Student("장원영", 98.5)
        };

        double total = 0;
        int passCount = 0;

        foreach (var s in students)
        {
            total += s.Score;
            if (s.Score >= 60)
                passCount++;
        }

        Console.WriteLine($"총점: {total}점");
        Console.WriteLine($"평균: {total / students.Length}점");
        Console.WriteLine($"합격자 수: {passCount}명");
    }
}
