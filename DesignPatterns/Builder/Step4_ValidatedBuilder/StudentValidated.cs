using System;

namespace Builder.Step4_ValidatedBuilder
{
    /// <summary>
    /// STEP 4: FLUENT BUILDER WITH VALIDATION
    /// 
    /// This is enterprise-grade Builder:
    /// - Validates data during Build()
    /// - Enforces business rules
    /// - Provides meaningful error messages
    /// - Throws appropriate exceptions
    /// 
    /// Improvements over Step 3:
    /// ✓ Data integrity guaranteed
    /// ✓ Business rules enforced
    /// ✓ Clear error messages
    /// ✓ Fail-fast approach (errors caught early)
    /// ✓ Production-ready code
    /// </summary>
    internal class StudentValidated
    {
        public string? Name { get; private set; }
        public int Age { get; private set; }
        public string? Batch { get; private set; }
        public double Psp { get; private set; }
        public int GradYear { get; private set; }

        // Private constructor - only Builder can create instances
        private StudentValidated(Builder builder)
        {
            // Validation happens here in the constructor
            // This ensures no invalid Student objects can ever be created

            if (builder.Age < 18)
            {
                throw new InvalidOperationException("❌ Validation Error: Age must be at least 18");
            }

            if (builder.GradYear > 2025)
            {
                throw new InvalidOperationException("❌ Validation Error: Graduation year must be 2025 or earlier");
            }

            if (string.IsNullOrWhiteSpace(builder.Name))
            {
                throw new InvalidOperationException("❌ Validation Error: Name cannot be empty");
            }

            // All validations passed - assign properties
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

        /// <summary>
        /// Static factory method to get a new Builder instance
        /// </summary>
        public static Builder GetBuilder()
        {
            return new Builder();
        }

        /// <summary>
        /// Fluent Builder with Validation
        /// Validates constraints during Build()
        /// </summary>
        public class Builder
        {
            private string? _name;
            private int _age;
            private string? _batch = "N/A";
            private double _psp = 0.0;
            private int _gradYear = 0;

            // C# Properties (idiomatic C#)
            public string? Name { get => _name; }
            public int Age { get => _age; }
            public string? Batch { get => _batch; }
            public double Psp { get => _psp; }
            public int GradYear { get => _gradYear; }

            // Fluent setters with optional validation
            public Builder WithName(string name)
            {
                if (string.IsNullOrWhiteSpace(name))
                {
                    throw new ArgumentException("Name cannot be null or empty");
                }
                _name = name;
                return this;
            }

            public Builder WithAge(int age)
            {
                if (age < 0)
                {
                    throw new ArgumentException("Age cannot be negative");
                }
                _age = age;
                return this;
            }

            public Builder WithBatch(string batch)
            {
                if (!string.IsNullOrWhiteSpace(batch))
                {
                    _batch = batch;
                }
                return this;
            }

            public Builder WithPsp(double psp)
            {
                if (psp < 0.0 || psp > 10.0)
                {
                    throw new ArgumentException("PSP must be between 0.0 and 10.0");
                }
                _psp = psp;
                return this;
            }

            public Builder WithGradYear(int gradYear)
            {
                if (gradYear < 0)
                {
                    throw new ArgumentException("Graduation year cannot be negative");
                }
                _gradYear = gradYear;
                return this;
            }

            // Build method with final validation
            public StudentValidated Build()
            {
                return new StudentValidated(this);  // Constructor does final validation
            }

            public override string ToString()
            {
                return $"Building: Name={_name}, Age={_age}, Batch={_batch}, Psp={_psp}, GradYear={_gradYear}";
            }
        }
    }
}
