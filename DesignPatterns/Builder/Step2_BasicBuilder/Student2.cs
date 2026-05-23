using System;

namespace Builder.Step2_BasicBuilder
{
    /// <summary>
    /// STEP 2: BASIC BUILDER PATTERN - First Improvement
    /// 
    /// This demonstrates the basic Builder Pattern:
    /// - Separate builder class for object construction
    /// - Set properties one by one (no method chaining yet)
    /// - Build() method to create the final object
    /// - Static factory method to get builder instance
    /// </summary>
    internal class Student2
    {
        public string? Name { get; private set; }
        public int Age { get; private set; }
        public string? Batch { get; private set; }
        public double Psp { get; private set; }
        public int GradYear { get; private set; }

        // Private constructor - only Builder can create instances
        public Student2(Builder2 builder)
        {
            // Validations
            if (builder.Age < 18)
            {
                throw new InvalidOperationException("❌ Validation Error: Age must be at least 18");
            }

            if (builder.GradYear > 2025)
            {
                throw new InvalidOperationException("❌ Validation Error: Graduation year must be 2025 or earlier");
            }

            Name = builder.Name;
            Age = builder.Age;
            Batch = builder.Batch;
            Psp = builder.Psp;
            GradYear = builder.GradYear;
        }

        /// <summary>
        /// Static factory method to get a new builder instance
        /// </summary>
        public static Builder2 GetBuilder()
        {
            return new Builder2();
        }

        public override string ToString()
        {
            return $"Student [Name={Name}, Age={Age}, Batch={Batch}, Psp={Psp}, GradYear={GradYear}]";
        }
    }
}
