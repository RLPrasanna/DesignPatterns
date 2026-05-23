using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    /// <summary>
    /// Client class demonstrates the Prototype design pattern.
    /// It uses pre-configured student prototypes and clones them to create new student instances
    /// with custom properties, avoiding expensive object creation from scratch.
    /// </summary>
    internal class Client
    {
        /// <summary>
        /// Initializes the registry with prototype student objects.
        /// These prototypes have common properties for different batches.
        /// </summary>
        /// <param name="registry">The StudentRegistry to populate</param>
        public static void fillRegistry(StudentRegistry registry)
        {
            // Create a prototype for the LLD MEF Evening Batch
            Student lldMwfEveningBatchPrototype = new Student();
            lldMwfEveningBatchPrototype.batch = "LLD MEF Evening Batch";
            lldMwfEveningBatchPrototype.avgPsp = 8.0;
            registry.add("LLDEveningPrototype", lldMwfEveningBatchPrototype);
            Console.WriteLine("✓ Registered LLD Evening Batch prototype with avgPsp: 8.0");

            // Create a prototype for the Intelligent Batch
            IntelligentStudent intelligentStudentPrototype = new IntelligentStudent();
            intelligentStudentPrototype.batch = "Intelligent Batch";
            intelligentStudentPrototype.avgPsp = 9.3;
            registry.add("intelligentStudentPrototype", intelligentStudentPrototype);
            Console.WriteLine("✓ Registered Intelligent Batch prototype with avgPsp: 9.3");
        }

        /// <summary>
        /// Entry point demonstrating the Prototype pattern usage.
        /// Shows how cloning prototypes creates new customized student instances.
        /// </summary>
        public static void Main(string[] args)
        {
            Console.WriteLine("\n========== PROTOTYPE DESIGN PATTERN DEMO ==========\n");

            // Create and populate the prototype registry
            StudentRegistry _studentRegistry = new StudentRegistry();
            Console.WriteLine("Step 1: Filling registry with student prototypes...");
            fillRegistry(_studentRegistry);

            // Clone the LLD Evening prototype and customize it
            Console.WriteLine("\nStep 2: Cloning LLD Evening prototype for Inesh...");
            Student inesh = _studentRegistry.get("LLDEveningPrototype").clone();
            inesh.name = "Inesh";
            inesh.psp = 8.5;
            Console.WriteLine($"✓ Created Student: Name={inesh.name}, Batch={inesh.batch}, PSP={inesh.psp}, AvgPSP={inesh.avgPsp}");

            // Clone the Intelligent Student prototype and customize it
            Console.WriteLine("\nStep 3: Cloning Intelligent Student prototype for Jignesh...");
            Student jignesh = _studentRegistry.get("intelligentStudentPrototype").clone();
            jignesh.name = "Jignesh";
            ((IntelligentStudent)jignesh).iq = 140;
            Console.WriteLine($"✓ Created IntelligentStudent: Name={jignesh.name}, Batch={jignesh.batch}, AvgPSP={jignesh.avgPsp}, IQ={((IntelligentStudent)jignesh).iq}");

            Console.WriteLine("\n========== PROTOTYPE PATTERN BENEFITS ==========");
            Console.WriteLine("• Reduced object creation overhead by reusing prototypes");
            Console.WriteLine("• Polymorphic cloning works correctly for derived classes");
            Console.WriteLine("• Easy to customize cloned instances with specific properties\n");
        }
    }
}
