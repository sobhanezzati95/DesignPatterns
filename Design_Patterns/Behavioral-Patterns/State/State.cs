namespace Design_Patterns.Behavioral_Patterns.State
{
    public class Context
    {
        public State State { get; set; }
        public Context()
        {
            State = new ConcreateState_A();
        }

        public void Request()
        {
            State.Handle(this);
        }
    }

    public abstract class State
    {
        public abstract void Handle(Context context);
    }

    public class ConcreateState_A : State
    {
        public override void Handle(Context context)
        {
            Console.WriteLine("Request Handled By ConcreateState_A");
            context.State = new ConcreateState_B();
        }
    }

    public class ConcreateState_B : State
    {
        public override void Handle(Context context)
        {
            Console.WriteLine("Request Handled By ConcreateState_B");
            context.State = new ConcreateState_C();
        }
    }

    public class ConcreateState_C : State
    {
        public override void Handle(Context context)
        {
            Console.WriteLine("Request Handled By ConcreateState_C");
            context.State = new ConcreateState_A();
        }
    }

    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Context context = new Context();
    //        context.Request();
    //        context.Request();
    //        context.Request();
    //    }
    //}
}
