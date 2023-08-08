///C# guarantees that static members are initialized only once, making this a simple and thread-safe way to implement a Singleton.

///Requirement: Implement a global counter for generating unique transaction IDs for financial transactions.
/// Reason: Static initialization guarantees that the counter is initialized before any transaction is processed, preventing potential duplicate transaction IDs.

namespace Singleton.StaticInitializationSingleton
{
    public class Singleton
    {
        private static readonly Singleton instance = new Singleton();

        private Singleton()
        {

        }

        public static Singleton Instance => instance;
    }
}
