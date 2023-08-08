///To ensure thread safety, we can use double-check locking to prevent multiple threads from simultaneously creating instances.
/// This variant checks for an existing instance before acquiring the lock, which can improve performance.

///Requirement: Create a logging service that multiple threads can use to write log entries.
///Reason: Ensuring thread safety is crucial when multiple threads are writing log entries concurrently to avoid data corruption and synchronization issues.

namespace Singleton.ThreadSafeSingleton_DualCheckLock_
{
    public class Singleton
    {
        private static readonly object LockObject= new object();
        private static Singleton _instance;

        private Singleton()
        {

        }

        public static Singleton Instance
        {
            get
            {
                #region DualCheckLock

                if (_instance == null)
                {
                    lock (LockObject)
                    {
                        if (_instance == null)
                        {
                            _instance = new Singleton();
                        }
                    }
                }
                return _instance;

                #endregion


                /// EnsureInitialized method itself internally handles the locking and double-checking.
                /// Initialization is called only once based on the value of the target property already being populated.

                #region LazyInitializer
                LazyInitializer.EnsureInitialized(ref _instance, () =>
                {
                    lock (LockObject)
                    {
                        if (_instance == null)
                        {
                            _instance = new Singleton();
                        }
                    }
                    return _instance;
                });
                return _instance;

                #endregion

            }
        }
    }
}
