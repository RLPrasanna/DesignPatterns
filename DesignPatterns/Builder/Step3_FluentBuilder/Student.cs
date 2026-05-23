using System;

namespace Builder.Step3_FluentBuilder
{
    /// <summary>
    /// STEP 3: FLUENT BUILDER PATTERN - Method Chaining
    /// 
    /// This is the most common implementation:
    /// - Each setter returns 'this' (the Builder instance)
    /// - Allows METHOD CHAINING
    /// - Much more readable and concise
    /// - Follows fluent interface pattern
    /// 
    /// Improvements over Step 2:
    /// ✓ Method chaining makes code more readable
    /// ✓ Single chain expression instead of multiple lines
    /// ✓ Professional and elegant syntax
    /// ✓ Easier to scan and understand intent
    /// </summary>
    internal class Student
    {
        public string? Name { get; private set; }
        public int Age { get; private set; }
        public string? Batch { get; private set; }
        public double Psp { get; private set; }
        public int GradYear { get; private set; }

        // Private constructor - only Builder can create instances
        private Student(Builder builder)
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

        public override string ToString()
        {
            return $"Student [Name={Name}, Age={Age}, Batch={Batch}, Psp={Psp}, GradYear={GradYear}]";
        }

        public static Builder GetBuilder()
        {
            return new Builder();
        }

        /// <summary>
        /// Fluent Builder Implementation
        /// Each setter returns 'this' to enable method chaining
        /// </summary>
        public class Builder
        {
            private string? _name;
            private int _age;
            private string? _batch = "";
            private double _psp = 0.0;
            private int _gradYear = 0;

            public string? Name { get => _name; }
            public int Age { get => _age; }
            public string? Batch { get => _batch; }
            public double Psp { get => _psp; }
            public int GradYear { get => _gradYear; }

            // Fluent setter methods - each returns 'this' for chaining
            public Builder WithName(string name)
            {
                _name = name;
                return this;  // ← This enables chaining!
            }

            public Builder WithAge(int age)
            {
                _age = age;
                return this; 
            }

            public Builder WithBatch(string batch)
            {
                _batch = batch;
                return this;
            }

            public Builder WithPsp(double psp)
            {
                _psp = psp;
                return this;
            }

            public Builder WithGradYear(int gradYear)
            {
                _gradYear = gradYear;
                return this;
            }

            // Build method creates the Student object
            public Student Build()
            {
                return new Student(this);
            }

            internal Builder()
            {

            }

            public override string ToString()
            {
                return $"Building: Name={_name}, Age={_age}, Batch={_batch}, Psp={_psp}, GradYear={_gradYear}";
            }
        }
    }
}
