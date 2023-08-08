///This is the basic implementation of the Singleton pattern.
/// It ensures that a class has only one instance and provides a static method to access that instance.
/// The instance is created lazily when it is first requested.

///Requirement: Ensure that a single instance of a database connection manager is shared across the application.
///Reason: Having multiple instances of the database connection manager could lead to resource wastage and potential connection pool issues.

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
