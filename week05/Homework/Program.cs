using System;
using System.ComponentModel;
using Homework;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This is the Homework Project.\n");

        // Create a base "Assignment" object
        Assignment a1 = new Assignment("Aquyles Maximus", "Multiplication");
        System.Console.WriteLine(a1.GetSummary());
        System.Console.WriteLine();

        // Create the derived class assignments
        System.Console.WriteLine("MathAssignment Class");
        MathAssignment a2 = new MathAssignment("Ulysses Maximus", "Fractions", "7.3", "8-19");
        System.Console.WriteLine(a2.GetSummary());
        System.Console.WriteLine(a2.GetHomeworkList());
        System.Console.WriteLine();

        System.Console.WriteLine("WritingAssignment Class");
        WritingAssignment a3 = new WritingAssignment("Sophya Loren", "European History", "The Causes of World War II");
        System.Console.WriteLine(a3.GetSummary());
        System.Console.WriteLine(a3.GetWritingInformation());

        // MathAssignment assignment1 = new MathAssignment("Edi Carlos", "Fractions", "7.3", "8-19");

        // WritingAssignment assignment2 = new WritingAssignment("Aline Cristina", "European History", "The Causes of World War II");

        // System.Console.WriteLine(assignment2.GetSummary());
        // System.Console.WriteLine(assignment2.GetWritingInformation());
    }
}