namespace Design_Patterns.Creational_Patterns.Singleton
{
    public class Singleton
    {
        private static readonly Singleton _uniqueInstance = new Singleton();
        private Singleton()
        {

        }

        public static Singleton GetInstance()
        {
            return _uniqueInstance;
        }

        //internal class Program
        //{
        //    static void Main(string[] args)
        //    {
        //        var obj1 = Singleton.GetInstance();
        //        var obj2 = Singleton.GetInstance();

        //        Console.WriteLine(obj1 == obj2);

        //    }
        //}
    }
}