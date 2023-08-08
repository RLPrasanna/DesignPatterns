///This is the basic implementation of the Singleton pattern.
/// It ensures that a class has only one instance and provides a static method to access that instance.
/// The instance is created lazily when it is first requested.

//Not Thread Safe
namespace Singleton.ClassicSingleton
{
    public class Singleton
    {
        private static Singleton instance;

        private Singleton()
        {

        }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance=new Singleton();
                }
                return instance;
            }
        }
    }
}
