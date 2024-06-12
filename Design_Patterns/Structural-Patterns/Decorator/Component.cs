namespace Design_Patterns.Structural_Patterns.Decorator
{
    public abstract class Component
    {
        public abstract void Operation();
    }
    public class ConcreateComponent : Component
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreateComponent...Operation()");
        }
    }
    public abstract class Decorator : Component
    {
        private readonly Component _component;

        protected Decorator(Component component)
        {
            _component = component;
        }

        public override void Operation()
        {
            _component.Operation();
        }
    }

    public class ConcreateDecorator : Decorator
    {
        public ConcreateDecorator(Component component) : base(component)
        {

        }

        public override void Operation()
        {
            base.Operation();
            NewFeature();
        }
        public void NewFeature()
        {
            Console.WriteLine("This Is NewFeature()");
        }
    }

    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        ConcreateComponent concreateComponent = new ConcreateComponent();
    //        ConcreateDecorator concreateDecorator = new ConcreateDecorator(concreateComponent);
    //        concreateDecorator.Operation();
    //    }
    //}
}
