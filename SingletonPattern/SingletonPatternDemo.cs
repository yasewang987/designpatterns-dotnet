namespace DesignPatterns.SingletonPattern
{
    public class SingletonPatternDemo
    {
        public static void Run()
        {
            var lazySingleton = LazySingleton.getInstanceDoubleCheck();
            lazySingleton.showMessage();

            var hungrySingleton = HungrySingleton.getInstance();
            hungrySingleton.showMessage();

            var staticInnerClassSingleton = StaticInnerClassSingleton.getInstance();
            staticInnerClassSingleton.showMessage();
        }
    }
}