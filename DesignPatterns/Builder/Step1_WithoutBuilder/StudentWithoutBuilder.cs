using System;

namespace Builder.Step1_WithoutBuilder
{
    /// <summary>
    /// STEP 1: WITHOUT BUILDER PATTERN - Problems with Traditional Approach
    /// 
    /// This demonstrates the PROBLEM we're trying to solve:
    /// - Constructor Telescoping (multiple overloaded constructors)
    /// - Difficult to read and maintain
    /// - Hard to track which fields are required vs optional
    /// - Adding new fields requires creating new constructors
    /// 
    /// This is the ANTI-PATTERN that Builder solves!
    /// </summary>
    internal class StudentWithoutBuilder
    {
        public string? Name { get; private set; }
        public int Age { get; private set; }
        public string? Batch { get; private set; }
        public double Psp { get; private set; }
        public int GradYear { get; private set; } 

        // PROBLEM 1: Constructor with only required fields
        public StudentWithoutBuilder(string name, int age)
        {
            Name = name;
            Age = age;
            Batch = "";
            Psp = 0.0;
            GradYear = 0;
        }

        // PROBLEM 2: Another overload for additional field
        public StudentWithoutBuilder(string name, int age, string batch)
        {
            Name = name;
            Age = age;
            Batch = batch;
            Psp = 0.0;
            GradYear = 0;
        }

        // PROBLEM 3: Yet another overload for more fields
        public StudentWithoutBuilder(string name, int age, string batch, double psp)
        {
            Name = name;
            Age = age;
            Batch = batch;
            Psp = psp;
            GradYear = 0;
        }

        // PROBLEM 4: Even more overloads needed for complete info!
        public StudentWithoutBuilder(string name, int age, string batch, double psp, int gradYear)
        {
            Name = name;
            Age = age;
            Batch = batch;
            Psp = psp;
            GradYear = gradYear;
        }

        public override string ToString()
        {
            return $"Student [Name={Name}, Age={Age}, Batch={Batch}, Psp={Psp}, GradYear={GradYear}]";
        }
    }
}
