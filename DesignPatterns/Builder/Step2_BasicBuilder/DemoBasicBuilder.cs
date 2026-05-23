using Builder.Step3_FluentBuilder;
using System;

namespace Builder.Step2_BasicBuilder
{
    /// <summary>
    /// Demo showing Basic Builder Pattern (without method chaining yet)
    /// This is still an improvement over Step 1, but we'll improve it further in Step 3
    /// </summary>
    internal class DemoBasicBuilder
    {
        public static void Demo()
        {
            Console.WriteLine("===== STEP 2: BASIC BUILDER PATTERN (Without Method Chaining) =====\n");

            var builder= new Builder2();

            builder.Name = "Raj";
            builder.Age = 20;
            builder.Batch = "A";
            builder.Psp = 9.5;
            builder.GradYear = 2025;

            Student2 student1 = new Student2(builder);

            //But this will enable creating Builder object directly while Student should be responsible for creating its builder object.
            //So we will create a static method in Student class to return the builder object.

            var builder2 = Student2.GetBuilder();
            builder2.Name = "Priya";
            builder2.Age = 21;
            builder2.Batch = "B";
            builder2.Psp = 8.8;
            builder2.GradYear = 2026;

            Student2 student2 = new Student2(builder);
            Console.WriteLine($"   {student2}\n");


            // But now we have to restrict the user to create Builder object directly while Student should be responsible for creating its builder object.
            // So we can make Builder constructor private
            // But then how will the user create Builder object? We can move the Builder class inside Student class and make it a nested class.
            // This is implemented in step 3.


            // IMPROVEMENTS over Step 1
            Console.WriteLine("IMPROVEMENTS over Step 1 (Without Builder):");
            Console.WriteLine("  ✓ No constructor telescoping (no need for 5+ overloaded ctors)");
            Console.WriteLine("  ✓ Clear property names (Name, Age, Batch, etc. explicit)");
            Console.WriteLine("  ✓ Easy to add new properties (no changing constructors)");
            Console.WriteLine("  ✓ Flexible (set only what you need, rest use defaults)");
            Console.WriteLine("  ✓ No position parameter confusion");
            Console.WriteLine("  ✓ Factory method provides some control over Builder creation\n");

            // DRAWBACK
            Console.WriteLine("DRAWBACK:");
            Console.WriteLine("  ❌ Still verbose - lots of separate assignment lines");
            Console.WriteLine("  ❌ Not fluent/readable - would be better with chaining");
            Console.WriteLine("  ❌ Builder can be created directly (bypassing factory)");
            Console.WriteLine("  ❌ No validation at setter level");
            Console.WriteLine("  ❌ Properties are mutable after assignment\n");

            Console.WriteLine("NEXT IMPROVEMENT: Add method chaining (fluent interface) ➜ STEP 3\n");
            Console.WriteLine("  → Add method chaining (fluent interface)");
            Console.WriteLine("  → Nest Builder class inside Student");
            Console.WriteLine("  → Make Builder constructor private");
            Console.WriteLine("  → Add validation at setter level");
            Console.WriteLine("  ➜ STEP 3\n");
            Console.WriteLine("└────────────────────────────────────────────────────────────────┘");
        }
    }
}
