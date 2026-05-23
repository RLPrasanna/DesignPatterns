using System;

namespace Builder.Step3_FluentBuilder
{
    /// <summary>
    /// Demo showing Fluent Builder Pattern with Method Chaining
    /// This is the most elegant and commonly used implementation
    /// </summary>
    internal class DemoFluentBuilder
    {
        public static void Demo()
        {
            Console.WriteLine("===== STEP 3: FLUENT BUILDER PATTERN (With Method Chaining) =====\n");

            Console.WriteLine("Improvement: Each setter returns 'this' to enable method CHAINING\n");

            var student1 = Student.GetBuilder()
                .WithName("Raj")
                .WithAge(20)
                .WithBatch("A")
                .WithPsp(9.5)
                .WithGradYear(2024)
                .Build();

            Console.WriteLine($"   Result: {student1}\n");

            // Example 2: More fluent examples
            Console.WriteLine("2. Creating multiple students with fluent syntax:");

            var student2 = Student.GetBuilder()
                .WithName("Priya")
                .WithAge(21)
                .WithBatch("B")
                .WithPsp(8.8)
                .WithGradYear(2023)
                .Build();
            Console.WriteLine($"   Student 2: {student2}");

            var student3 = Student.GetBuilder()
                .WithName("Akshay")
                .WithAge(22)
                .WithBatch("C")
                .WithPsp(9.0)
                .WithGradYear(2022)
                .Build();
            Console.WriteLine($"   Student 3: {student3}\n");

            // Example 3: Partial information (using defaults)
            Console.WriteLine("3. Partial information (some fields use defaults):");
            var student4 = Student.GetBuilder()
                .WithName("Sneha")
                .WithAge(19)
                .Build();
            Console.WriteLine($"   {student4}");
            Console.WriteLine("   ✓ Batch='N/A', Psp=0.0, GradYear=0 (default values)\n");

            // Example 4: Showing how chaining works internally
            Console.WriteLine("4. How chaining works - step by step:");
            Console.WriteLine("   Step 1: Student.GetBuilder() → returns Builder instance");

            var builder = Student.GetBuilder();
            Console.WriteLine("   Step 2: .WithName(\"John\") → returns SAME Builder instance");

            builder = builder.WithName("John");
            Console.WriteLine($"   Step 3: .WithAge(20) → returns SAME Builder instance");

            builder = builder.WithAge(20);
            Console.WriteLine($"   Step 4: .WithBatch(\"A\") → returns SAME Builder instance");

            builder = builder.WithBatch("A");
            Console.WriteLine($"   Step 5: .Build() → creates and returns Student object");

            var student5 = builder.Build();
            Console.WriteLine($"   Result: {student5}\n");

            // Benefits
            Console.WriteLine("WHY FLUENT BUILDER IS BETTER:");
            Console.WriteLine("  ✓ Readable: Reads like natural language");
            Console.WriteLine("  ✓ Chainable: All in one continuous expression");
            Console.WriteLine("  ✓ Concise: Fewer lines, better formatting");
            Console.WriteLine("  ✓ Elegant: Professional, modern syntax");
            Console.WriteLine("  ✓ Flexible: Set any combination of fields\n");

            Console.WriteLine("NEXT IMPROVEMENT: Add VALIDATION ➜ STEP 4\n");
        }
    }
}
