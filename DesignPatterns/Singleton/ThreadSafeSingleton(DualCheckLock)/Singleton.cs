///To ensure thread safety, we can use double-check locking to prevent multiple threads from simultaneously creating instances.
/// This variant checks for an existing instance before acquiring the lock, which can improve performance.

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
                if (_instance == null)
                {
                    lock (LockObject)
                    {
                        if (_instance == null)
                        {
                            _instance=new Singleton();
                        }
                    }
                }
                return _instance;
            }
        }
    }
}
