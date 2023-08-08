///.NET Framework provides a Lazy<T> class that allows you to implement lazy initialization in a thread-safe manner without explicit locking.

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
