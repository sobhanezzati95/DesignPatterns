namespace Design_Patterns.Creational_Patterns.Singleton
{
    public class LaziInitializerSingleton
    {
        private readonly static Lazy<LaziInitializerSingleton> _uniqueInstance = new Lazy<LaziInitializerSingleton>();
        private LaziInitializerSingleton() { }

        public static LaziInitializerSingleton GetInstance()
        {
            return _uniqueInstance.Value;
        }
    }
}
