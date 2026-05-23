using System;

namespace Builder.Step5_RealWorld
{
    /// <summary>
    /// STEP 5: REAL-WORLD SCENARIOS AND ADVANCED PATTERNS
    /// 
    /// This demonstrates practical usage patterns:
    /// - Default/base configurations
    /// - Builder reuse and composition
    /// - Copy constructor pattern
    /// - Immutability benefits
    /// - Production-ready best practices
    /// </summary>
    internal class StudentProduction
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Batch { get; private set; }
        public double Psp { get; private set; }
        public int GradYear { get; private set; }

        private StudentProduction(Builder builder)
        {
            if (builder.GetAge() < 18)
                throw new InvalidOperationException("Age must be at least 18");
            if (builder.GetGradYear() > 2025)
                throw new InvalidOperationException("Graduation year must be 2025 or earlier");

            Name = builder.GetName() ?? throw new InvalidOperationException("Name is required");
            Age = builder.GetAge();
            Batch = builder.GetBatch();
            Psp = builder.GetPsp();
            GradYear = builder.GetGradYear();
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
        /// Production-ready Builder with advanced features
        /// </summary>
        public class Builder
        {
            private string? _name;
            private int _age;
            private string _batch = "N/A";
            private double _psp = 0.0;
            private int _gradYear = 0;

            public string? GetName() => _name;
            public int GetAge() => _age;
            public string GetBatch() => _batch;
            public double GetPsp() => _psp;
            public int GetGradYear() => _gradYear;

            public Builder WithName(string name)
            {
                _name = name ?? throw new ArgumentNullException(nameof(name));
                return this;
            }

            public Builder WithAge(int age)
            {
                if (age < 0) throw new ArgumentException("Age cannot be negative");
                _age = age;
                return this;
            }

            public Builder WithBatch(string batch)
            {
                _batch = batch ?? "N/A";
                return this;
            }

            public Builder WithPsp(double psp)
            {
                if (psp < 0.0 || psp > 10.0)
                    throw new ArgumentException("PSP must be between 0.0 and 10.0");
                _psp = psp;
                return this;
            }

            public Builder WithGradYear(int gradYear)
            {
                if (gradYear < 0) throw new ArgumentException("Year cannot be negative");
                _gradYear = gradYear;
                return this;
            }

            // Copy from existing student (for creating variants)
            public Builder CopyFrom(StudentProduction student)
            {
                _name = student.Name;
                _age = student.Age;
                _batch = student.Batch;
                _psp = student.Psp;
                _gradYear = student.GradYear;
                return this;
            }

            // Preset configurations
            public static Builder DefaultConfiguration()
            {
                return new Builder()
                    .WithBatch("General")
                    .WithPsp(7.0)
                    .WithGradYear(2024);
            }

            // Clone builder state
            public Builder Clone()
            {
                return new Builder()
                    .WithName(_name ?? "")
                    .WithAge(_age)
                    .WithBatch(_batch)
                    .WithPsp(_psp)
                    .WithGradYear(_gradYear);
            }

            public StudentProduction Build()
            {
                return new StudentProduction(this);
            }

            public override string ToString()
            {
                return $"Building: Name={_name}, Age={_age}, Batch={_batch}, Psp={_psp}, GradYear={_gradYear}";
            }
        }
    }
}
