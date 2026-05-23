using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    /// <summary>
    /// Student class is a concrete prototype that implements the IPrototype interface.
    /// It represents a standard student with basic properties.
    /// </summary>
    internal class Student : IPrototype<Student>
    {
        public string name { get; set; }
        public int age { get; set; }
        public string batch { get; set; }
        public double psp { get; set; }
        public double avgPsp { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Student(){ }

        /// <summary>
        /// Copy constructor used for cloning. Creates a new Student instance by copying all properties.
        /// </summary>
        /// <param name="student">The student object to copy from</param>
        public Student(Student student)
        {
            this.name = student.name;
            this.age = student.age;
            this.batch = student.batch;
            this.psp = student.psp;
            this.avgPsp = student.avgPsp;
        }

        /// <summary>
        /// Creates a deep copy of the current Student instance.
        /// This is the clone method required by the Prototype pattern.
        /// </summary>
        /// <returns>A new Student object with the same properties</returns>
        public virtual Student clone()
        {
            return new Student(this);
        }
    }
}
