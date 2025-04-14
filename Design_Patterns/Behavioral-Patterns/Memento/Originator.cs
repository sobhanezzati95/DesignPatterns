namespace Design_Patterns.Behavioral_Patterns.Memento;
public class Originator
{
    string state;
    public string State
    {
        get { return state; }
        set { state = value; }
    }

    public Memento CreateMemento()
    {
        return new Memento(state);
    }
    public void SetMemento(Memento memento)
    {
        State = memento.State;
    }
}
public class Memento
{
    string state;
    public Memento(string state)
    {
        this.state = state;
    }
    public string State
    {
        get { return state; }
    }
}
public class Caretaker
{
    Memento memento;
    public Memento Memento
    {
        get { return memento; }
        set { memento = value; }
    }
}
//internal class Program
//{
//    static void Main(string[] args)
//    {
//        Originator originator = new Originator();
//        originator.State = "Green";
//
//        Caretaker caretaker = new Caretaker();
//        caretaker.Memento = originator.CreateMemento();
//
//        originator.State = "Red";
//        originator.State = "Yellow";
//        originator.State = "Blue";
//
//        originator.SetMemento(caretaker.Memento);
//
//        Console.ReadKey();
//    }
//}