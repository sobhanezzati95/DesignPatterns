﻿namespace Design_Patterns.Structural_Patterns.Adapter
{
    // The Target defines the domain-specific interface used by the client code.
    public interface ITarget
    {
        string GetRequest();
    }

    // The Adaptee contains some useful behavior, but its interface is
    // incompatible with the existing client code. The Adaptee needs some
    // adaptation before the client code can use it.
    class Adaptee
    {
        public string GetSpecificRequest()
        {
            return "Specific request.";
        }
    }

    // The Adapter makes the Adaptee's interface compatible with the Target's
    // interface.
    class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public string GetRequest()
        {
            return $"This is '{_adaptee.GetSpecificRequest()}'";
        }
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Adaptee adaptee = new Adaptee();
    //        ITarget target = new Adapter(adaptee);

    //        Console.WriteLine("Adaptee interface is incompatible with the client.");
    //        Console.WriteLine("But with adapter client can call it's method.");

    //        Console.WriteLine(target.GetRequest());
    //    }
    //}
}
