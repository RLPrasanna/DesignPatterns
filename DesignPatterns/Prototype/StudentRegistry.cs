using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    /// <summary>
    /// StudentRegistry acts as a registry/cache for prototype objects.
    /// It stores predefined student prototypes that can be cloned to create new instances.
    /// </summary>
    internal class StudentRegistry
    {
        private Dictionary<string, Student> _students = new Dictionary<string, Student>();

        /// <summary>
        /// Retrieves a prototype student from the registry by its key.
        /// </summary>
        /// <param name="key">The unique identifier for the prototype</param>
        /// <returns>The prototype Student object</returns>
        public Student get(String key)
        {
            return _students[key];
        }

        /// <summary>
        /// Adds a prototype student to the registry with a given key.
        /// </summary>
        /// <param name="key">The unique identifier for the prototype</param>
        /// <param name="student">The Student prototype to store</param>
        public void add(String key, Student student)
        {
            _students[key] = student;
        }
    }
}
