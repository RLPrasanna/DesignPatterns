
Singleton.ClassicSingleton.Singleton singleton1 = Singleton.ClassicSingleton.Singleton.Instance;
Singleton.ClassicSingleton.Singleton singleton2 = Singleton.ClassicSingleton.Singleton.Instance;

Console.WriteLine($"singleton1 == singleton2: {singleton1 == singleton2}");

Singleton.ThreadSafeSingleton_DualCheckLock_.Singleton threadSafeSingleton1 = Singleton.ThreadSafeSingleton_DualCheckLock_.Singleton.Instance;
Singleton.ThreadSafeSingleton_DualCheckLock_.Singleton threadSafeSingleton2 = Singleton.ThreadSafeSingleton_DualCheckLock_.Singleton.Instance;

Console.WriteLine($"threadSafeSingleton1 == threadSafeSingleton2: {threadSafeSingleton1 == threadSafeSingleton2}");

Singleton.LazySingleton.Singleton lazySingleton1 = Singleton.LazySingleton.Singleton.Instance;
Singleton.LazySingleton.Singleton lazySingleton2 = Singleton.LazySingleton.Singleton.Instance;

Console.WriteLine($"lazySingleton1 == lazySingleton2: {lazySingleton1 == lazySingleton2}");

Singleton.StaticInitializationSingleton.Singleton staticInitializationSingleton1 = Singleton.StaticInitializationSingleton.Singleton.Instance;
Singleton.StaticInitializationSingleton.Singleton staticInitializationSingleton2 = Singleton.StaticInitializationSingleton.Singleton.Instance;

Console.WriteLine($"staticInitializationSingleton1 == staticInitializationSingleton2: {staticInitializationSingleton1 == staticInitializationSingleton2}");