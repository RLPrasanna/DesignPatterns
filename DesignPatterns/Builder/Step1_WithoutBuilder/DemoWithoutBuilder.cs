using System;

namespace Builder.Step1_WithoutBuilder
{
    /// <summary>
    /// Demo showing problems WITHOUT Builder Pattern
    /// Demonstrates the Constructor Telescoping Anti-Pattern
    /// </summary>
    internal class DemoWithoutBuilder
    {
        public static void Demo()
        {
            Console.WriteLine("===== STEP 1: WITHOUT BUILDER PATTERN (Constructor Telescoping Problem) =====\n");

            // Problem: Which constructor should I use? Hard to remember!
            Console.WriteLine("Creating students WITHOUT Builder Pattern:\n");

            // Using constructor with just name and age
            Console.WriteLine("1. Using constructor(name, age):");
            var student1 = new StudentWithoutBuilder("Raj", 20);
            Console.WriteLine($"   {student1}");
            Console.WriteLine("   ❌ Issue: Batch, PSP, and GradYear are all default values\n");

            // Using constructor with name, age, and batch
            Console.WriteLine("2. Using constructor(name, age, batch):");
            var student2 = new StudentWithoutBuilder("Priya", 21, "A");
            Console.WriteLine($"   {student2}");
            Console.WriteLine("   ❌ Issue: PSP and GradYear are still default values\n");

            // Using constructor with name, age, batch, and psp
            Console.WriteLine("3. Using constructor(name, age, batch, psp):");
            var student3 = new StudentWithoutBuilder("Akshay", 22, "B", 9.5);
            Console.WriteLine($"   {student3}");
            Console.WriteLine("   ❌ Issue: GradYear is still default value\n");

            // Using the full constructor
            Console.WriteLine("4. Using constructor(name, age, batch, psp, gradYear):");
            var student4 = new StudentWithoutBuilder("Sneha", 21, "C", 9.2, 2023);
            Console.WriteLine($"   {student4}");
            Console.WriteLine("   ✓ All values set, but...\n");

        }
    }
}
