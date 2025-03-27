using System;

public class Student{
    private string name;
    private int age;
    private double grade;

    public string Name{
        get {
            return name;
        }
        set {
            name = value;
        }
    }

    public int Age{
        get {
            return age;
        }
        set {
            age = value;
        }
    }

    public double Grade{
        get {
            return grade;
        }
        set {
            grade = value;
        }
    }

    public string CalculateLetterGrade(){
        if (grade >= 90) return "A";
        else if (grade >= 80) return "B";
        else if (grade >= 70) return "C";
        else if (grade >= 60) return "D";
        else return "F";
    }
}

public class Program{
    
    public static void Main(string[] args){
        
        Student student = new Student{
            Name = "John Doe",
            Age = 20,
            Grade = 85.5
        };
        
        Console.WriteLine($"Name: {student.Name}");
        Console.WriteLine($"Age: {student.Age}");
        Console.WriteLine($"Numeric Grade: {student.Grade}");
        Console.WriteLine($"Letter Grade: {student.CalculateLetterGrade()}");
    }
}