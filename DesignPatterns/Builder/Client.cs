using System;
using Builder.Step1_WithoutBuilder;
using Builder.Step2_BasicBuilder;
using Builder.Step3_FluentBuilder;
using Builder.Step4_ValidatedBuilder;
using Builder.Step5_RealWorld;

namespace Builder
{
    internal class Client
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║          BUILDER PATTERN - STEP-BY-STEP IMPROVEMENT          ║");
            Console.WriteLine("║                  From Basic to Production-Ready              ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════╝\n");

            // STEP 1: Without Builder Pattern (Problems & Anti-patterns)
            DemoWithoutBuilder.Demo();
            PauseAndContinue();

            // STEP 2: Basic Builder (No chaining yet)
            DemoBasicBuilder.Demo();
            PauseAndContinue();

            // STEP 3: Fluent Builder (Method chaining)
            DemoFluentBuilder.Demo();
            PauseAndContinue();

            // STEP 4: Validated Builder (With validation)
            DemoValidatedBuilder.Demo();
            PauseAndContinue();

            // STEP 5: Real-World Scenarios (Advanced patterns)
            DemoRealWorld.Demo();

            Console.WriteLine("\n╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                    SUMMARY OF ALL STEPS                      ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════╝\n");

            PrintSummary();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        /// <summary>
        /// Helper method to pause between steps
        /// </summary>
        private static void PauseAndContinue()
        {
            Console.WriteLine("\n" + new string('─', 70));
            Console.WriteLine("Press any key to continue to next step...");
            Console.ReadKey();
            Console.WriteLine("\n");
        }

        /// <summary>
        /// Print a comprehensive summary of all steps
        /// </summary>
        private static void PrintSummary()
        {
            Console.WriteLine("┌─ STEP 1: WITHOUT BUILDER ─────────────────────────────────────┐");
            Console.WriteLine("│ Problem: Constructor Telescoping (multiple overloaded ctors)   │");
            Console.WriteLine("│ Issues:  - Hard to read                                        │");
            Console.WriteLine("│          - Code duplication                                   │");
            Console.WriteLine("│          - Unclear intent of parameters                       │");
            Console.WriteLine("└────────────────────────────────────────────────────────────────┘\n");

            Console.WriteLine("┌─ STEP 2: BASIC BUILDER ───────────────────────────────────────┐");
            Console.WriteLine("│ Improvement: Separate builder class for construction          │");
            Console.WriteLine("│ Features: - Set properties one by one                         │");
            Console.WriteLine("│           - Build() method to create object                  │");
            Console.WriteLine("│           - Clear which fields are being set                 │");
            Console.WriteLine("│ Problem:  - Still verbose, not fluent                        │");
            Console.WriteLine("└────────────────────────────────────────────────────────────────┘\n");

            Console.WriteLine("┌─ STEP 3: FLUENT BUILDER ──────────────────────────────────────┐");
            Console.WriteLine("│ Improvement: Method chaining (return 'this' from setters)    │");
            Console.WriteLine("│ Features: - Fluent interface for readability                 │");
            Console.WriteLine("│           - Single chain expression                          │");
            Console.WriteLine("│           - Professional, elegant syntax                     │");
            Console.WriteLine("│ Example:  builder.WithName(...).WithAge(...).Build()        │");
            Console.WriteLine("└────────────────────────────────────────────────────────────────┘\n");

            Console.WriteLine("┌─ STEP 4: VALIDATED BUILDER ──────────────────────────────────┐");
            Console.WriteLine("│ Improvement: Add validation for data integrity               │");
            Console.WriteLine("│ Features: - Input validation in setters                      │");
            Console.WriteLine("│           - Business rule validation in constructor          │");
            Console.WriteLine("│           - Meaningful error messages                        │");
            Console.WriteLine("│           - Production-ready robustness                      │");
            Console.WriteLine("└────────────────────────────────────────────────────────────────┘\n");

            Console.WriteLine("┌─ STEP 5: REAL-WORLD SCENARIOS ────────────────────────────────┐");
            Console.WriteLine("│ Advanced Patterns:                                            │");
            Console.WriteLine("│ 1. Default/Preset configurations                             │");
            Console.WriteLine("│ 2. Builder reuse and cloning                                │");
            Console.WriteLine("│ 3. Copy constructor pattern (CopyFrom method)               │");
            Console.WriteLine("│ 4. Immutability benefits (thread-safe, no side effects)     │");
            Console.WriteLine("│ 5. Building collections with loops/LINQ                    │");
            Console.WriteLine("└────────────────────────────────────────────────────────────────┘\n");

            Console.WriteLine("KEY TAKEAWAYS:");
            Console.WriteLine("  ✓ Builder solves constructor telescoping problem");
            Console.WriteLine("  ✓ Fluent interface makes code more readable");
            Console.WriteLine("  ✓ Validation ensures data integrity");
            Console.WriteLine("  ✓ Immutable objects are thread-safe and predictable");
            Console.WriteLine("  ✓ Builder pattern is perfect for complex object creation\n");
        }
    }
}
