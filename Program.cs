using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

class Student
{
    public String Name  { get; set; }
    public int score {  get; set; }

}

class Programm_Student
{
    static void Main()
    {
        List<Student> Student_list = new List<Student>()        //creating the list of students
        {
            new Student{Name="Airen",score=88},
            new Student{Name="Jay",score=89},
            new Student{Name="Roy",score=80},
            new Student{Name="Raj",score=92},
            new Student{Name="Henry",score=75},
            new Student{Name="Lily",score=82},
            new Student{Name="Ryan",score=84},
            new Student{Name="James",score=77},
            new Student{Name="Emily",score=70},
            new Student{Name="Mike",score=97},
            new Student{Name="Mohit",score=97},
            new Student{Name="Sophia",score=86},
        };
                                                //filtering the top three students from the class 
        var topStudents=Student_list
            .Where(s=> s.score>=75)
            .OrderByDescending(s=>s.score)
            .Take(3)
            .Select(s=>s.Name + "-" + s.score)
            .ToList();
        Console.WriteLine("******Top 3 Students are:********");
        Console.WriteLine("---------------------------------");

        foreach (var student in topStudents)
        { 
            Console.WriteLine(student);
        }

        File.WriteAllLines("\nreport.txt",topStudents);
        Console.WriteLine("\nReport saved successfully!");
        Console.WriteLine("\nReading report.txt:");
        string[] report = File.ReadAllLines("report.txt");

        foreach(string line in report)
        {
            Console.WriteLine($"{line}");
        }

    }
}