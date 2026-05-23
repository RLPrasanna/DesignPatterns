using System;

namespace Builder.Step4_ValidatedBuilder
{
    /// <summary>
    /// Demo showing Validated Builder Pattern
    /// Demonstrates validation at both setter and constructor level
    /// </summary>
    internal class DemoValidatedBuilder
    {
        public static void Demo()
        {
            Console.WriteLine("===== STEP 4: VALIDATED BUILDER PATTERN =====\n");

            Console.WriteLine("Improvement: Add validation to ensure data integrity\n");

            // Example 1: Valid student
            Console.WriteLine("1. Creating a VALID student:");
            try
            {
                var validStudent = StudentValidated.GetBuilder()
                    .WithName("Raj")
                    .WithAge(20)
                    .WithBatch("A")
                    .WithPsp(9.5)
                    .WithGradYear(2024)
                    .Build();

                Console.WriteLine($"   ✓ Success: {validStudent}\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"   ✗ Error: {ex.Message}\n");
            }

            // Example 2: Invalid - Age validation in setter
            Console.WriteLine("2. Invalid INPUT - Age is negative (caught in setter):");
            try
            {
                var invalidStudent = StudentValidated.GetBuilder()
                    .WithName("John")
                    .WithAge(-5)  // ← Invalid!
                    .Build();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"   ✗ Error: {ex.Message}\n");
            }

            // Example 3: Invalid - Empty name
            Console.WriteLine("3. Invalid INPUT - Empty name (caught in setter):");
            try
            {
                var invalidStudent = new StudentValidated.Builder()
                    .WithName("")  // ← Invalid!
                    .WithAge(20)
                    .Build();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"   ✗ Error: {ex.Message}\n");
            }

            // Example 4: Invalid - PSP out of range
            Console.WriteLine("4. Invalid INPUT - PSP > 10.0 (caught in setter):");
            try
            {
                var invalidStudent = new StudentValidated.Builder()
                    .WithName("Jane")
                    .WithAge(20)
                    .WithPsp(11.0)  // ← Invalid! Must be 0-10
                    .Build();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"   ✗ Error: {ex.Message}\n");
            }

            // Example 5: Invalid - Age too young (caught in constructor)
            Console.WriteLine("5. Invalid BUSINESS RULE - Age < 18 (caught in constructor):");
            try
            {
                var invalidStudent = new StudentValidated.Builder()
                    .WithName("Bob")
                    .WithAge(16)  // ← Business rule violation!
                    .WithBatch("B")
                    .WithPsp(8.5)
                    .WithGradYear(2025)
                    .Build();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"   ✗ Error: {ex.Message}\n");
            }

            // Example 6: Invalid - Grad year in future
            Console.WriteLine("6. Invalid BUSINESS RULE - GradYear > 2025 (caught in constructor):");
            try
            {
                var invalidStudent = StudentValidated.GetBuilder()
                    .WithName("Alice")
                    .WithAge(20)
                    .WithBatch("C")
                    .WithPsp(9.0)
                    .WithGradYear(2026)  // ← Business rule violation!
                    .Build();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"   ✗ Error: {ex.Message}\n");
            }

            // Example 7: Multiple valid students
            Console.WriteLine("7. Multiple VALID students:");
            try
            {
                var students = new[]
                {
                    StudentValidated.GetBuilder()
                        .WithName("Priya")
                        .WithAge(21)
                        .WithBatch("A")
                        .WithPsp(9.2)
                        .WithGradYear(2023)
                        .Build(),

                    StudentValidated.GetBuilder()
                        .WithName("Akshay")
                        .WithAge(22)
                        .WithBatch("B")
                        .WithPsp(8.8)
                        .WithGradYear(2022)
                        .Build(),

                    StudentValidated.GetBuilder()
                        .WithName("Sneha")
                        .WithAge(20)
                        .WithBatch("C")
                        .WithPsp(9.5)
                        .WithGradYear(2024)
                        .Build()
                };

                foreach (var student in students)
                {
                    Console.WriteLine($"   ✓ {student}");
                }
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"   ✗ Error: {ex.Message}\n");
            }

            // Validation strategy explanation
            Console.WriteLine("VALIDATION STRATEGY:");
            Console.WriteLine("  1. Input Validation (in setters):");
            Console.WriteLine("     - Checks immediate/obvious errors");
            Console.WriteLine("     - Prevents invalid states early");
            Console.WriteLine("     - Throws ArgumentException");
            Console.WriteLine();
            Console.WriteLine("  2. Business Rule Validation (in constructor):");
            Console.WriteLine("     - Checks cross-field constraints");
            Console.WriteLine("     - Enforces domain logic");
            Console.WriteLine("     - Throws InvalidOperationException");
            Console.WriteLine();

            Console.WriteLine("BENEFITS OF VALIDATED BUILDER:");
            Console.WriteLine("  ✓ Data Integrity: No invalid Student objects can exist");
            Console.WriteLine("  ✓ Fail-Fast: Errors caught as early as possible");
            Console.WriteLine("  ✓ Clear Errors: Meaningful error messages guide users");
            Console.WriteLine("  ✓ Production-Ready: Enterprise-level robustness\n");

            Console.WriteLine("NEXT STEP: Real-world scenarios and advanced patterns ➜ STEP 5\n");
        }
    }
}
