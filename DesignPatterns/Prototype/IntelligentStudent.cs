using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    /// <summary>
    /// IntelligentStudent class extends Student and adds an IQ property.
    /// It overrides the clone method to ensure proper deep copying of the derived type.
    /// </summary>
    internal class IntelligentStudent: Student
    {
        public int iq { get; set; }

        /// <summary>
        /// Copy constructor that calls base copy constructor and copies the IQ property.
        /// </summary>
        /// <param name="student">The IntelligentStudent object to copy from</param>
        public IntelligentStudent(IntelligentStudent student) : base(student)
        {            
            this.iq = student.iq;
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public IntelligentStudent(){ }

        /// <summary>
        /// Overrides the clone method to return an IntelligentStudent instance instead of a base Student.
        /// This ensures polymorphic cloning works correctly.
        /// </summary>
        /// <returns>A new IntelligentStudent object with the same properties</returns>
        public override Student clone()
        {
            return new IntelligentStudent(this);
        }
    }
}
