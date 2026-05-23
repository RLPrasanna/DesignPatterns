using System;
using System.Collections.Generic;

namespace Builder.Step5_RealWorld
{
    /// <summary>
    /// Demo showing Real-World Builder Patterns and Advanced Usage
    /// Practical scenarios you'll encounter in production code
    /// </summary>
    internal class DemoRealWorld
    {
        public static void Demo()
        {
            Console.WriteLine("===== STEP 5: REAL-WORLD SCENARIOS & ADVANCED PATTERNS =====\n");

            DemoScenario1_DefaultConfiguration();
            Console.WriteLine();
            DemoScenario2_BuilderReuse();
            Console.WriteLine();
            DemoScenario3_CopyConstructor();
            Console.WriteLine();
            DemoScenario4_Immutability();
            Console.WriteLine();
            DemoScenario5_ListCreation();
        }

        /// <summary>
        /// Scenario 1: Preset/Default Configurations
        /// In real projects, you often need standard configurations
        /// </summary>
        private static void DemoScenario1_DefaultConfiguration()
        {
            Console.WriteLine("SCENARIO 1: Preset Default Configurations");
            Console.WriteLine("Problem: Many students share common values");
            Console.WriteLine("Solution: Pre-configured builder\n");

            Console.WriteLine("// Create a base configuration for all 2024 batch students");
            var baseConfig = StudentProduction.GetBuilder()
                .WithBatch("General")
                .WithPsp(7.0)
                .WithGradYear(2024);
            Console.WriteLine("var baseConfig = StudentProduction.GetBuilder()");

            Console.WriteLine("// Use it as a starting point for individual students");
            var student1 = baseConfig.Clone()
                .WithName("Raj")
                .WithAge(20)
                .Build();
            Console.WriteLine($"Student 1: {student1}");

            var student2 = baseConfig.Clone()
                .WithName("Priya")
                .WithAge(21)
                .Build();
            Console.WriteLine($"Student 2: {student2}");

            var student3 = baseConfig.Clone()
                .WithName("Akshay")
                .WithAge(22)
                .WithPsp(8.5)  // Override one field
                .Build();
            Console.WriteLine($"Student 3: {student3}");

            Console.WriteLine("\n✓ Benefit: DRY principle - Don't repeat yourself");
            Console.WriteLine("✓ Reduces code duplication when creating similar objects");
        }

        /// <summary>
        /// Scenario 2: Builder Reuse Pattern
        /// Reusing builder state to create multiple similar objects
        /// </summary>
        private static void DemoScenario2_BuilderReuse()
        {
            Console.WriteLine("SCENARIO 2: Builder Reuse");
            Console.WriteLine("Problem: Creating many similar objects with small variations");
            Console.WriteLine("Solution: Reuse and modify builder state\n");

            Console.WriteLine("// Create base builder");
            var baseBuilder = StudentProduction.GetBuilder()
                .WithBatch("Computer Science")
                .WithPsp(9.0)
                .WithGradYear(2023);

            Console.WriteLine("Base builder configured with Batch='Computer Science', Psp=9.0, GradYear=2023\n");

            Console.WriteLine("// Create students by cloning and modifying");
            var students = new[]
            {
                baseBuilder.Clone().WithName("Raj").WithAge(20).Build(),
                baseBuilder.Clone().WithName("Priya").WithAge(21).Build(),
                baseBuilder.Clone().WithName("Akshay").WithAge(22).Build()
            };

            foreach (var student in students)
            {
                Console.WriteLine($"  {student}");
            }

            Console.WriteLine("\n✓ Benefit: Template pattern - define common structure once");
            Console.WriteLine("✓ Easier to maintain - change defaults in one place");
        }

        /// <summary>
        /// Scenario 3: Copy Constructor Pattern
        /// Create a new student by copying and modifying existing student
        /// </summary>
        private static void DemoScenario3_CopyConstructor()
        {
            Console.WriteLine("SCENARIO 3: Copy/Clone Pattern");
            Console.WriteLine("Problem: Need to create a variant of existing student");
            Console.WriteLine("Solution: Copy from existing and modify\n");

            // Original student
            var originalStudent = StudentProduction.GetBuilder()
                .WithName("Original")
                .WithAge(20)
                .WithBatch("A")
                .WithPsp(9.0)
                .WithGradYear(2024)
                .Build();

            Console.WriteLine($"Original Student: {originalStudent}\n");

            // Create variant by copying and modifying
            Console.WriteLine("Creating variant with updated info (promoting to next batch):");
            var promotedStudent = StudentProduction.GetBuilder()
                .CopyFrom(originalStudent)
                .WithBatch("B")
                .WithGradYear(2023)
                .Build();

            Console.WriteLine($"Promoted Student:  {promotedStudent}\n");

            // Another variant
            var retakenStudent = StudentProduction.GetBuilder()
                .CopyFrom(originalStudent)
                .WithPsp(8.0)
                .Build();

            Console.WriteLine($"With Updated PSP:  {retakenStudent}\n");

            Console.WriteLine("✓ Benefit: Immutability pattern - create new objects instead of modifying");
            Console.WriteLine("✓ Prevents side effects - original student unchanged");
            Console.WriteLine("✓ Clear intent - obvious that we're creating a variant");
        }

        /// <summary>
        /// Scenario 4: Immutability Benefits
        /// Demonstrates why immutable objects are valuable
        /// </summary>
        private static void DemoScenario4_Immutability()
        {
            Console.WriteLine("SCENARIO 4: Immutability Benefits");
            Console.WriteLine("Problem: Object data should not change after creation");
            Console.WriteLine("Solution: Read-only properties + Builder pattern\n");

            var student = new StudentProduction.Builder()
                .WithName("Immutable Student")
                .WithAge(20)
                .WithBatch("A")
                .WithPsp(9.5)
                .WithGradYear(2024)
                .Build();

            Console.WriteLine($"Created Student: {student}\n");

            Console.WriteLine("Attempting to modify properties:");
            Console.WriteLine("  student.Name = \"NewName\"  // ✗ Compile error: property is read-only");
            Console.WriteLine("  student.Age = 21          // ✗ Compile error: property is read-only\n");

            Console.WriteLine("✓ Benefit: Thread-safe by default");
            Console.WriteLine("✓ No accidental modifications");
            Console.WriteLine("✓ Predictable behavior - object never changes after creation");
            Console.WriteLine("✓ Easier to reason about - no side effects");
        }

        /// <summary>
        /// Scenario 5: Creating Collections
        /// Real-world scenario - building a list of objects
        /// </summary>
        private static void DemoScenario5_ListCreation()
        {
            Console.WriteLine("SCENARIO 5: Building Collections");
            Console.WriteLine("Problem: Need to create multiple objects programmatically");
            Console.WriteLine("Solution: Use builder in loops and LINQ\n");

            Console.WriteLine("Method 1: Traditional loop");
            var students = new List<StudentProduction>();

            var studentData = new[]
            {
                ("Raj", 20, "A", 9.5, 2024),
                ("Priya", 21, "B", 8.8, 2023),
                ("Akshay", 22, "C", 9.0, 2022),
                ("Sneha", 20, "A", 9.2, 2024)
            };

            foreach (var (name, age, batch, psp, year) in studentData)
            {
                var student = StudentProduction.GetBuilder()
                    .WithName(name)
                    .WithAge(age)
                    .WithBatch(batch)
                    .WithPsp(psp)
                    .WithGradYear(year)
                    .Build();

                students.Add(student);
            }

            Console.WriteLine("Created students:");
            foreach (var student in students)
            {
                Console.WriteLine($"  {student}");
            }

            Console.WriteLine("\nMethod 2: LINQ approach (functional style)");
            var batchAStudents = students
                .FindAll(s => s.Batch == "A");

            Console.WriteLine($"Students in Batch A: {batchAStudents.Count}");
            foreach (var student in batchAStudents)
            {
                Console.WriteLine($"  {student}");
            }

            Console.WriteLine("\n✓ Benefit: Builder works well with loops and collections");
            Console.WriteLine("✓ Readable code even when creating many objects");
            Console.WriteLine("✓ Easy to filter and process collections afterward");
        }
    }
}
