///.NET Framework provides a Lazy<T> class that allows you to implement lazy initialization in a thread-safe manner without explicit locking.

///Requirement: Implement a configuration manager to provide application settings to various parts of the system.
/// Reason: Lazy initialization ensures that the configuration manager is only created when it's first accessed, saving resources if the configuration is not needed.

namespace Singleton.LazySingleton
{
    public class Singleton
    {
        private static readonly Lazy<Singleton> LazyInstance= new Lazy<Singleton>(() => new Singleton());

        private Singleton()
        {

        }

        public static Singleton Instance => LazyInstance.Value;
    }
}
