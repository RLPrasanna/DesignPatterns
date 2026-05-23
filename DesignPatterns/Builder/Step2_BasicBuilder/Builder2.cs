using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Step2_BasicBuilder
{
    /// <summary>
    /// Basic Builder Implementation (SEPARATE CLASS)
    /// Sets properties one by one
    /// No method chaining (yet!)
    /// 
    /// This is the BUILDER class - responsible for constructing Student2 objects
    /// </summary>
    internal class Builder2
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Batch { get; set; } = "N/A";
        public double Psp { get; set; } = 0.0;
        public int GradYear { get; set; } = 0;

        public Builder2()
        {
            // Default values are set via property initializers above
        }
    }
}
